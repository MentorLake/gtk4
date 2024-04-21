using System.Runtime.InteropServices;

namespace MentorLake.Gtk4;

public sealed class DelegateSafeHandleMarshaller<T> : ICustomMarshaler where T : SafeHandle, new()
{
	private static readonly DelegateSafeHandleMarshaller<T> s_instance = new();

	public void CleanUpManagedData(object o)
	{
		var p = (T)o;
		p.Dispose();
	}

	public void CleanUpNativeData(IntPtr ptr)
	{
	}

	public int GetNativeDataSize()
	{
		return IntPtr.Size;
	}

	public IntPtr MarshalManagedToNative(object o)
	{
		var p = (T)o;
		return p.DangerousGetHandle();
	}

	public object MarshalNativeToManaged(IntPtr ptr)
	{
		var safeHandle = new T();
		Marshal.InitHandle(safeHandle, ptr);
		return safeHandle;
	}

	public static ICustomMarshaler GetInstance(string s)
	{
		return s_instance;
	}
}
