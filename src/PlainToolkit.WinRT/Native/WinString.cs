using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PlainToolkit.WinRT.Native;

public static class WinString
{
    [DllImport("combase.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern unsafe int WindowsCreateString(ushort* sourceString, int length, IntPtr* hstring);

    [DllImport("combase.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern unsafe int WindowsCreateStringReference(ushort* sourceString, int length, IntPtr* hstringHeader, IntPtr* hstring);

    [DllImport("combase.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int WindowsDeleteString(IntPtr hstring);

    [DllImport("combase.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern unsafe char* WindowsGetStringRawBuffer(IntPtr hstring, uint* length);
}