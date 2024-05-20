namespace MentorLake.Gtk4.GLib;

public class GBytesHandle : BaseSafeHandle
{
	public static GBytesHandle New(IntPtr data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new(data, size);
	}

	public static GBytesHandle NewStatic(IntPtr data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new_static(data, size);
	}

	public static GBytesHandle NewTake(IntPtr data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new_take(data, size);
	}

	public static GBytesHandle NewWithFreeFunc(IntPtr data, UIntPtr size, GDestroyNotify free_func, IntPtr user_data)
	{
		return GBytesExterns.g_bytes_new_with_free_func(data, size, free_func, user_data);
	}

}

internal class GBytesExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new(IntPtr data, UIntPtr size);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_static(IntPtr data, UIntPtr size);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_take(IntPtr data, UIntPtr size);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_with_free_func(IntPtr data, UIntPtr size, GDestroyNotify free_func, IntPtr user_data);

}

public struct GBytes
{
}
