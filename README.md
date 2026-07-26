# iClBackupTool — ConfuserEx Deobfuscation Toolchain

Deobfuscation pipeline for **ConfuserEx-protected .NET assemblies** using a combination of in-memory runtime decryption, XOR key recovery, raw PE patching, and dnlib-based IL body reconstruction.

Target: `SpiderBackup.exe` — a ConfuserEx-protected WinForms application using **Anti-Tamper** (method body XOR encryption) and **Proxy Call** protection.

---

## How ConfuserEx Obfuscates

### Anti-Tamper
1. All method bodies are moved from `.text` into the `.zN|` section.
2. The `.text` section's `SizeOfRawData` is set to **zero** — it exists only in virtual memory.
3. The `.zN|` section is XOR-encrypted using a key derived from a **reference method** (token `0x06000497`).
4. A module-level `.cctor` decrypts each body at runtime, writing it to the method's RVA.
5. The XOR is applied per-method starting at each method's file-offset-within-`.zN|`, aligned to the key stream.

### Proxy Call Protection
- Direct calls (`call`, `callvirt`, `ldftn`, `ldtoken`) are replaced with indirect patterns using `ldtoken` + `calli`.
- A runtime proxy handler resolves these to real method pointers.

### PE Layout
| Section | RVA Range | Raw Data | Content |
|---------|-----------|----------|---------|
| `.text` | `0x2000 – 0xBD0B8` | `SizeOfRawData=0` | Zero-backed virtual allocation |
| `.5+.` | `0xBE000 – 0x19C390` | `SizeOfRawData=0` | Zero-backed virtual allocation |
| `.zN|` | `0x19E000 – 0x2D4DDC` | `0x400 – 0x137200` | Encrypted method bodies for ALL methods |
| `.rsrc` | `0x2D6000 – 0x304F64` | `0x137200 – 0x166200` | Resources |

**Critical:** Despite having distinct RVAs, BOTH `.text` and `.zN|` methods have their physical body data inside `.zN|`'s raw bytes. The order in `.zN|` is by **MethodDef token** (not by RVA).

---

## Pipeline Overview

```
full_decrypt ─► .dec files (proxy-resolved IL)
     │
     ▼
test_xoronly ─► XOR key derivation & section decryption
     │
     ▼
rebuild_resolved / final_rebuild ─► final deobfuscated PE
```

---

## Tool Reference

### Phase 1: Method Dumping & Key Recovery

| Tool | Description |
|------|-------------|
| **`full_decrypt.cs`** | Loads the obfuscated PE **at runtime** via `Assembly.Load()`, triggers the module cctor (anti-tamper handler), then enumerates all loaded types/methods and calls `GetILAsByteArray()` to extract proxy-resolved IL bytes. Saves as `{typeToken}_{methodToken}.dec`. Also derives the XOR key from the reference method and saves section-decrypted bodies as `{methodToken}.dec_xor`. |
| **`full_decrypt2.cs`** | Refined version with corrected section-based RVA-to-file-offset mapping. Handles `.zN|` section's zero `SizeOfRawData`. |
| **`dumper.cs`** | Uses `LoadLibraryEx` with `LOAD_LIBRARY_AS_IMAGE_RESOURCE` to map the PE as an image, then dumps method body bytes directly from the mapped view. |
| **`patcher.cs`** | Patches the anti-tamper cctor IL to skip the decryption loop, preventing double-XOR corruption when running the modified assembly. |

### Phase 2: XOR Key & Section Decryption

| Tool | Description |
|------|-------------|
| **`test_xoronly.cs`** | Extracts XOR key from reference method (`0x06000497`) by XORing the encrypted PE bytes against the saved `.dec_xor` reference file. Applies XOR across the entire `.zN|` section at the correct file-offset alignment, protecting the CLR header and metadata regions from corruption. |
| **`verify_key.cs`** | Verifies the XOR key by checking that decryption produces valid COR_ILMETHOD headers. |
| **`debug_xor2.cs`** | Compares reference method's decrypted bytes against raw PE bytes to validate the XOR relationship. |

### Phase 3: Rebuilding (Three Approaches)

#### Approach A: Raw Byte-Level Patching (in-place)

Overwrites method body data directly in the PE file.

| Tool | Description |
|------|-------------|
| **`raw_patch.cs`** | First iteration — raw patch using `.dec` files. XOR-decrypts `.zN|` section, replaces bodies. |
| **`raw_patch2.cs`** | Improved with body-size validation and CLR/metadata region protection. |
| **`raw_patch3.cs`** | Adds XOR key alignment relative to reference method offset within the section. |
| **`raw_patch4.cs`** | Handles section boundary protection, skips methods overlapping CLR header/metadata, restores CLR header from original after patching. |

#### Approach B: dnlib `ModuleDefMD.Write()` (metadata-safe)

Loads with dnlib, sets `method.Body` programmatically, then writes a new PE.

| Tool | Description |
|------|-------------|
| **`rebuild.cs`** | First iteration — replaces `.zN|` bodies from `.dec_xor` files. |
| **`rebuild2.cs`** | Reads XOR keys from reference method, applies per-method sliding XOR. |
| **`rebuild3.cs`** | Uses reference method's `.dec_xor` as the XOR key pattern. |
| **`rebuild4.cs`** | Handles `.zN|` section with zero `SizeOfRawData` by manual offset calculation. |
| **`rebuild5.cs`** | XOR-decrypts entire `.zN|` section, then uses dnlib to load and write. |
| **`rebuild_final.cs`** | Stubs RVA=0 methods, replaces `.zN|` bodies from `.dec_xor`, writes with `PreserveAll` metadata flag. |
| **`rebuild_resolved.cs`** | Uses `.dec` files (proxy-resolved, headerless IL) with `MethodBodyReader`. Prepends COR_ILMETHOD header. 663/663 `.zN|` methods replaced. |

#### Approach C: Hybrid — Final Integration

| Tool | Description |
|------|-------------|
| **`final_rebuild.cs`** | **Current best attempt.** Loads `.dec` files (proxy-resolved) for `.zN|` methods, falls back to `.dec_xor` files for all methods, then `mod.Write()` with `PreserveAll`. **Issue:** `.text` method `.dec_xor` files contain garbage because `ToFileOffset(RVA)` returns 0 for the `.text` section (zero raw data). Results in 560 multi-instr bodies + 646 stubs. |

### Phase 4: Verification

| Tool | Description |
|------|-------------|
| **`inspect_final.cs`** | Loads the output PE and counts multi-instruction methods vs single-`ret` stubs vs null bodies. |
| **`vrfy3.cs`** | Compares original vs resolved PE side-by-side (body counts, entry point). |
| **`verify.cs`** | Loads output and prints type/method counts and sample method IL. |
| **`verify_dec.cs`** | Prints first few instructions of non-trivial method bodies. |
| **`verify_dec2.cs`** | Counts stubs vs real bodies. |
| **`valid_check.cs`** | Sanity-check: loads output with dnlib in try-catch, reports body counts. |
| **`valid_check2.cs`** | Same, simpler output. |
| **`vrfy.cs`** | Loads `_resolved.exe`, prints body counts and sample IL. |
| **`vrfy2.cs`** | Loads `_resolved.exe`, prints entry point and `Main` methods. |

### Diagnostic / Analysis Tools

#### PE Structure
| Tool | Description |
|------|-------------|
| **`check_sections.cs`** | Prints section headers (RVA ranges, raw offsets, sizes) from dnlib `PEImage`. |
| **`check_pe.cs`** | Counts methods with/without bodies split by `.text` vs `.zN|` section. |
| **`check_pe2.cs`** | Manually parses PE headers from raw bytes. |
| **`check_meta.cs`** | Locates metadata blob from COR20 header and prints signature bytes. |
| **`check_meta2.cs`** | Manual PE parsing to locate CLR header and metadata, with hex dumps. |
| **`inspect_znz.cs`** | Hex dump of `.zN|` section raw bytes, counts valid COR_ILMETHOD headers. |
| **`check_raw.cs`** | Byte-level comparison of CLR data directory between original and output. |
| **`check_corrupt.cs`** | Loads PEs via low-level `NativePEImage`, prints CLR runtime info. |

#### Method Body Inspection
| Tool | Description |
|------|-------------|
| **`check_token.cs`** | Inspects a single method's `.dec_xor` file (bytes + `MethodBodyReader` parse attempt). |
| **`check_ref.cs`** | Inspects reference method token `0x06000497`. |
| **`check_fail.cs`** | Tests which `.dec_xor` files fail to parse, prints their header bytes. |
| **`check_bad.cs`** | Iterates ALL methods, attempts `MethodBodyReader` on each `.dec_xor` file, reports failures. |
| **`examine_bodies.cs`** | Hex dump of several `.dec_xor` files for manual analysis. |
| **`check_ep.cs`** | Prints entry point of `_final.exe`. |
| **`check_ep2.cs`** | Prints entry point raw bytes and body state from original PE. |
| **`check_old.cs`** | Loads older deobfuscated output and counts bodies. |
| **`debug_rva.cs`** | Counts null-body methods by abstract/runtime/native flags. |
| **`debug_decrypt.cs`** | Dumps encrypted section raw bytes with metadata bounds. |

#### Mapping & Cross-Reference
| Tool | Description |
|------|-------------|
| **`verify_order.cs`** | Compares dnlib's RVA-to-file-offset against manual section parsing. Tests the hypothesis that method bodies in `.zN|` are ordered by MethodDef token. |
| **`inspect_dump.cs`** | Cross-references module methods against `.dec`/`.dec_xor` files on disk. |
| **`find_meta_rva.cs`** | Locates COR20 header and metadata RVA/size. |
| **`find_meta.cs`** | Uses reflection on `dnlib.dll` to discover metadata-related API. |
| **`find_api.cs`** | Uses reflection on `dnlib.dll` to discover `MethodBodyReader`/`CilBody` API. |
| **`find_body.cs`** | Maps a given RVA to its containing section. |
| **`checkll.cs`** | Tests `LoadLibraryEx` mapping approach. |
| **`decrypt_reader.cs`** | Tests whether the module cctor can be triggered at runtime. |

### Utility
| Tool | Description |
|------|-------------|
| **`dumpbody.cs`** | Reads raw method body bytes at a hardcoded offset and parses the FAT header. |
| **`dumpbody2.cs`** | Finds a specific nested-type cctor and dumps its raw body bytes from the PE. |
| **`test_run.cs`** | Loads final output via `Assembly.LoadFrom` and attempts reflection enumeration. |
| **`test_xoronly.cs`** | (Also core tool) XOR-decrypt-only PE for validation. |

---

## Current State & Remaining Work

### ✅ What Works
- XOR key derivation & section decryption — **correct**
- `.zN|` method body replacement with proxy-resolved `.dec` data — **604/663 bodies replaced**
- `.zN|` method body replacement with anti-tamper-decrypted `.dec_xor` data — **58/663 bodies replaced**
- Anti-tamper cctor stubbing
- CLR header and metadata region protection during patching
- `final_rebuild.exe` produces `SpiderBackup_final.exe` with valid PE structure (1206 bodies)

### ❌ Remaining Issue
**544 `.text` section methods are stubbed** (single `ret`) because their `.dec_xor` files contain garbage. Root cause:

- `.text` section has `SizeOfRawData = 0`, so `ToFileOffset(RVA)` returns 0 for `.text` methods.
- `full_decrypt.cs` uses a manual `rvaToFileOff()` that returns `PointerToRawData + (RVA - VirtualAddress)` **ignoring** `SizeOfRawData`.
- For `.text` methods (RVA < `0x19E000`), this computes `0 + (RVA - 0x2000)` = offset within `.zN|` section data — but this is the **wrong offset** because method bodies in `.zN|` are stored in **MethodDef token order**, not RVA order.
- The `.dec_xor` files for `.text` methods were XOR-decrypted from bytes at the wrong location → garbage.

### 🔧 Fix
The real `.text` method body offsets within `.zN|` section follow token order:
```
offset_in_zN| = sum(body_sizes_of_all_methods_with_smaller_tokens)
```

For `.zN|` methods, the cumulative offset happens to equal `RVA - 0x19E000` (because ConfuserEx assigned their RVAs sequentially within `.zN|`). For `.text` methods, this equality doesn't hold.

**Fix `full_decrypt.cs`** to:
1. Sort all methods by token
2. Compute body sizes from `.zN|` methods' RVA gaps (they're sequential)  
3. Backfill `.text` method body sizes from the known cumulative offset of the first `.zN|` method
4. Read encrypted bytes at the correct sequential offset within `.zN|`

See `verify_order.cs` for the start of this approach.

### 🚀 Running on the Ryzen

```cmd
cd /d "C:\Users\premi\Documents\Github\iClBackupTool"
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /nologo /reference:dnlib.dll /out:tool.exe tool.cs && tool.exe
```

---

## Output File Naming

| Suffix | Meaning |
|--------|---------|
| `.dec` | Proxy-resolved IL bytes (raw, no COR_ILMETHOD header). From `GetILAsByteArray()` after CLR resolved proxies. |
| `.dec_xor` | Anti-tamper-only decrypted body (has COR_ILMETHOD header). XOR-decrypted from `.zN|` section data. Valid for `.zN|` methods only. |
| `_rawpatched*.exe` | In-place byte-level patching output. |
| `_resolved.exe` | dnlib rebuild using `.dec` files (proxy-resolved). |
| `_xoronly.exe` | PE with only XOR decryption applied (no body replacement). |
| `_final.exe` | Latest dnlib rebuild attempt (`.dec` + `.dec_xor` combined). |
