using System.Runtime.InteropServices;
using PlainToolkit.WinRT.Native;
using PlainToolkit.WinRT.Runtime;

namespace PlainToolkit.WinRT.Helper;

public static class HStringHelper
{
    public static unsafe HString ToHString(string? value)
    {
        if (value is null)
        {
            return new HString(IntPtr.Zero);
        }
        IntPtr handle;
        fixed (char* lpValue = value)
        {
            Marshal.ThrowExceptionForHR(
                WinString.WindowsCreateString((ushort*)lpValue, value.Length, &handle));
        }
        return new HString(handle);
    }
    
    public static unsafe string ToManagedString(HString value)
    {
        if (value == IntPtr.Zero)
            return "";
        uint length;
        var buffer = WinString.WindowsGetStringRawBuffer(value, &length);
        return new string(buffer, 0, (int)length);
    }
}