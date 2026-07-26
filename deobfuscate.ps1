@"
# ===== DEOBFUSCATION SCRIPT for Spider Backup.exe =====
# Run this in PowerShell on your Windows machine (Ryzen G15)

# Step 1: Create working directory
mkdir C:\deobfuscate -Force
cd C:\deobfuscate

# Step 2: Download de4dot (ConfuserEx compatible version)
# Latest de4dot build:
Invoke-WebRequest -Uri "https://github.com/x42en3l3g4nt/de4dot/releases/download/v3.1.0/de4dot.zip" -OutFile de4dot.zip
Expand-Archive de4dot.zip -Force

# Step 3: Copy the Spider Backup.exe
# (Copy from wherever you have it - USB, network share, etc.)
# For example:
# Copy-Item "D:\Spider Backup.exe" .

# Step 4: Run de4dot 
# Try standard mode first:
.\de4dot\de4dot.exe "Spider Backup.exe"

# If that fails due to virtualization, try with ConfuserEx detection:
.\de4dot\de4dot.exe --dont-rename "Spider Backup.exe"

# Step 5: Download ILSpy
Invoke-WebRequest -Uri "https://github.com/icsharpcode/ILSpy/releases/download/v9.0-preview3/ILSpy_binaries_9.0.0.7687-preview3.zip" -OutFile ilspy.zip
Expand-Archive ilspy.zip -Force

# Step 6: Decompile to C#
.\ILSpy\ilspycmd.exe -o decompiled_output -p "Spider Backup-cleaned.exe"

# Step 7: Package the results
Compress-Archive -Path decompiled_output -DestinationPath decompiled_source.zip

Write-Host "DONE! Results in C:\deobfuscate\decompiled_source.zip"
"@