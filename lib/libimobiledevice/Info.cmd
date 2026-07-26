@echo off
lib\libimobiledevice\ideviceinfo.exe | lib\libimobiledevice\grep.exe -w UniqueDeviceID | lib\libimobiledevice\awk.exe '{printf $NF}'