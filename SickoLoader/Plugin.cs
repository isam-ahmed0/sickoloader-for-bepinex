using BepInEx;
using BepInEx.Unity.IL2CPP;
using System;
using System.Runtime.InteropServices;

namespace SickoLoader;

[BepInPlugin("dev.sicko.loader", "SickoLoader", "1.0.0")]
[BepInProcess("Among Us")]
public class Plugin : BasePlugin
{
    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern IntPtr LoadLibrary(string lpFileName);

    public override void Load()
    {
        Log.LogInfo("SickoLoader: Attempting to load SickoMenu.dll...");

        IntPtr result = LoadLibrary("SickoMenu.dll");
        if (result == IntPtr.Zero)
        {
            int error = Marshal.GetLastWin32Error();
            Log.LogError($"SickoLoader: Failed to load SickoMenu.dll (Win32 Error {error})");
        }
        else
        {
            Log.LogInfo("SickoLoader: SickoMenu.dll loaded successfully.");
        }
    }
}
