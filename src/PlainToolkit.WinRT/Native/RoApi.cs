using System.Runtime.InteropServices;

namespace PlainToolkit.WinRT.Native;

public static class RoApi
{
    [DllImport("combase.dll")]
    public static extern unsafe int RoGetActivationFactory(IntPtr runtimeClassId, Guid* iid, IntPtr* factory);
}