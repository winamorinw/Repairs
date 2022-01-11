echo off
cls
subst f: \\nfs-sb\sys
xcopy "f:\bux\arc\Repairs\Repairs.exe" "C:\Repairs\" /D/Y
xcopy "f:\bux\arc\Repairs\Repairs_help.chm" "C:\Repairs\" /D/Y
xcopy "f:\bux\arc\Repairs\Repairs.exe.config" "C:\Repairs\" /D/Y
start Repairs.exe