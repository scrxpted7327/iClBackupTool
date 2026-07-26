using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

class MethodDumper
{
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);
    
    const uint LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x20;

    static void Main(string[] args)
    {
        string path = args.Length > 0 ? args[0] : @"C:\deobfuscate\SpiderBackup.exe";
        string outDir = args.Length > 1 ? args[1] : @"C:\deobfuscate\methods_dump";
        string patchedPath = Path.Combine(Path.GetDirectoryName(path), "Patched_" + Path.GetFileName(path));
        Directory.CreateDirectory(outDir);

        // Get PE mapping via LoadLibraryEx
        IntPtr hMod = LoadLibraryEx(path, IntPtr.Zero, LOAD_LIBRARY_AS_IMAGE_RESOURCE);
        if (hMod == IntPtr.Zero) { Console.WriteLine("LoadLibraryEx failed"); return; }
        long correctBase = hMod.ToInt64() & ~3;
        Console.WriteLine("Mapping base: 0x" + correctBase.ToString("X16"));

        // Load with dnlib and modify the cctor
        ModuleDefMD module = ModuleDefMD.Load(path);
        MethodDef bcCctor = null;
        FieldDef baseField = null;
        
        foreach (var t in module.Types)
        {
            if (!t.Name.Contains("78492021")) continue;
            foreach (var nt in t.NestedTypes)
            {
                if (!nt.Name.Contains("6D2115ED")) continue;
                foreach (var m in nt.Methods)
                    if (m.IsStatic && m.IsConstructor && !m.IsInstanceConstructor) bcCctor = m;
                foreach (var f in nt.Fields)
                    if (f.IsStatic && f.FieldType.GetFullName() == "System.Int64") baseField = f;
            }
        }
        
        if (bcCctor == null || baseField == null) { Console.WriteLine("Not found"); return; }
        Console.WriteLine("Found cctor and field: {0} token=0x{1:X8}", baseField.Name, baseField.MDToken.Raw);
        
        // Create new CilBody with our IL
        var instrs = new System.Collections.Generic.List<Instruction>();
        instrs.Add(Instruction.Create(OpCodes.Ldc_I8, correctBase));
        instrs.Add(Instruction.Create(OpCodes.Stsfld, baseField));
        instrs.Add(Instruction.Create(OpCodes.Ret));
        
        var newBody = new CilBody();
        newBody.InitLocals = true;
        foreach (var inst in instrs)
            newBody.Instructions.Add(inst);
        
        Console.WriteLine("New body: {0} instructions", newBody.Instructions.Count);
        
        bcCctor.Body = newBody;
        
        // Save patched module with preserved metadata tokens
        var opts = new dnlib.DotNet.Writer.ModuleWriterOptions(module);
        opts.MetadataOptions.Flags = dnlib.DotNet.Writer.MetadataFlags.PreserveAll;
        module.Write(patchedPath, opts);
        Console.WriteLine("Saved patched assembly to: " + patchedPath);
        
        // Load patched assembly
        byte[] patchedBytes = File.ReadAllBytes(patchedPath);
        var asm = Assembly.Load(patchedBytes);
        Console.WriteLine("Assembly: " + asm.FullName);
        Module managedModule = asm.ManifestModule;

        // Trigger module constructor
        Console.WriteLine("Triggering module constructor...");
        try
        {
            RuntimeHelpers.RunModuleConstructor(managedModule.ModuleHandle);
            Console.WriteLine("Module constructor succeeded!");
        }
        catch (Exception ex)
        {
            Exception e = ex;
            int depth = 0;
            while (e != null && depth < 5)
            {
                Console.WriteLine("[{0}] {1}: {2}", depth, e.GetType().Name, e.Message);
                string st = e.StackTrace;
                if (st != null)
                {
                    var lines = st.Split('\n');
                    for (int i = 0; i < Math.Min(lines.Length, 8); i++)
                        Console.WriteLine("  {0}", lines[i].Trim());
                }
                e = e.InnerException;
                depth++;
            }
        }

        // Dump method bodies
        Console.WriteLine("\nDumping method bodies...");
        Type[] allTypes = null;
        try { allTypes = asm.GetTypes(); }
        catch (ReflectionTypeLoadException rtl) { allTypes = rtl.Types; }
        
        if (allTypes != null)
        {
            int total = 0, dumped = 0;
            foreach (var typ in allTypes)
            {
                if (typ == null) continue;
                foreach (var method in typ.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    total++;
                    try
                    {
                        var mbody = method.GetMethodBody();
                        if (mbody != null)
                        {
                            byte[] il = mbody.GetILAsByteArray();
                            if (il != null && il.Length > 0 && il.Length < 1000000)
                            {
                                string fn = typ.Name + "_" + method.Name + ".il";
                                fn = fn.Replace('<', '_').Replace('>', '_').Replace(':', '_').Replace('/', '_');
                                string fpath = Path.Combine(outDir, fn);
                                if (!File.Exists(fpath))
                                {
                                    File.WriteAllBytes(fpath, il);
                                    dumped++;
                                    if (dumped <= 5 || dumped % 200 == 0)
                                        Console.WriteLine("  [{0}] {1}.{2}: {3} bytes", dumped, typ.Name, method.Name, il.Length);
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
            Console.WriteLine("\nTotal: {0} methods, {1} dumped", total, dumped);
        }
    }
}
