using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PlainWinRT.Native;

public static partial class WinString
{
    [LibraryImport("combase.dll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static unsafe partial int WindowsCreateString(ushort* sourceString, int length, IntPtr* hstring);

    [LibraryImport("combase.dll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static unsafe partial int WindowsCreateStringReference(ushort* sourceString, int length, IntPtr* hstringHeader, IntPtr* hstring);

    [LibraryImport("combase.dll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial int WindowsDeleteString(IntPtr hstring);

    [LibraryImport("combase.dll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static unsafe partial char* WindowsGetStringRawBuffer(IntPtr hstring, uint* length);
}