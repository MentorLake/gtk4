using System.Runtime.InteropServices;

namespace MentorLake.Gtk4;

public sealed class NoNativeFreeStringMarshaller : ICustomMarshaler
{
	private static readonly NoNativeFreeStringMarshaller s_instance = new();

	public void CleanUpManagedData(object o)
	{

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
		return Marshal.StringToHGlobalAuto((string)o);
	}

	public object MarshalNativeToManaged(IntPtr ptr)
	{
		return Marshal.PtrToStringAuto(ptr);
	}

	public static ICustomMarshaler GetInstance(string s)
	{
		return s_instance;
	}
}
