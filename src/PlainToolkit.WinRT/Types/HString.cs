namespace PlainToolkit.WinRT.Types;

/// <summary>
/// 表示一个 WinRT HSTRING 句柄的只读包装。
/// </summary>
/// <param name="value">HSTRING 的底层指针句柄（<see cref="IntPtr"/>）。</param>
public readonly struct HString(IntPtr value)
{
    public readonly IntPtr Value = value;

    
    
    public bool IsNull => Value == IntPtr.Zero;
    public static implicit operator IntPtr(HString h) => h.Value;
    public static explicit operator HString(IntPtr ptr) => new(ptr);
}