using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;

class InspectDump {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        
        // Collect all method tokens in mod
        var modMethods = new Dictionary<int, MethodDef>();
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                modMethods[(int)m.MDToken.Raw] = m;
                
        Console.WriteLine("Module has {0} total methods", modMethods.Count);
        
        // Check .dec files
        var decFiles = Directory.GetFiles(dumpDir, "*.dec");
        Console.WriteLine("Found {0} .dec files on disk", decFiles.Length);
        
        int matchedInMod = 0;
        int textMatched = 0;
        int znzMatched = 0;
        
        foreach (var f in decFiles) {
            string name = Path.GetFileNameWithoutExtension(f);
            string[] parts = name.Split('_');
            if (parts.Length == 2) {
                int mToken = Convert.ToInt32(parts[1], 16);
                MethodDef m;
                if (modMethods.TryGetValue(mToken, out m)) {
                    matchedInMod++;
                    if ((uint)m.RVA < 0x19E000) textMatched++;
                    else znzMatched++;
                } else {
                    // Token not in module?
                }
            }
        }
        Console.WriteLine("Matched in module: {0} (text={1}, znz={2})", matchedInMod, textMatched, znzMatched);
        
        // Print first 10 unmatched filenames
        int unmatchedCount = 0;
        foreach (var f in decFiles) {
            string name = Path.GetFileNameWithoutExtension(f);
            string[] parts = name.Split('_');
            if (parts.Length == 2) {
                int mToken = Convert.ToInt32(parts[1], 16);
                if (!modMethods.ContainsKey(mToken)) {
                    if (unmatchedCount < 10)
                        Console.WriteLine("Unmatched .dec file: {0} (mToken=0x{1:X8})", Path.GetFileName(f), mToken);
                    unmatchedCount++;
                }
            } else {
                Console.WriteLine("Non-standard filename format: {0}", Path.GetFileName(f));
            }
        }
        Console.WriteLine("Total unmatched .dec files: {0}", unmatchedCount);
    }
}
