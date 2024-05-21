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


public static class GBytesHandleExtensions
{
	public static int Compare(this IntPtr bytes1, IntPtr bytes2)
	{
		return GBytesExterns.g_bytes_compare(bytes1, bytes2);
	}

	public static bool Equal(this IntPtr bytes1, IntPtr bytes2)
	{
		return GBytesExterns.g_bytes_equal(bytes1, bytes2);
	}

	public static IntPtr GetData(this GBytesHandle bytes, out UIntPtr size)
	{
		return GBytesExterns.g_bytes_get_data(bytes, out size);
	}

	public static IntPtr GetRegion(this GBytesHandle bytes, UIntPtr element_size, UIntPtr offset, UIntPtr n_elements)
	{
		return GBytesExterns.g_bytes_get_region(bytes, element_size, offset, n_elements);
	}

	public static UIntPtr GetSize(this GBytesHandle bytes)
	{
		return GBytesExterns.g_bytes_get_size(bytes);
	}

	public static uint Hash(this IntPtr bytes)
	{
		return GBytesExterns.g_bytes_hash(bytes);
	}

	public static GBytesHandle NewFromBytes(this GBytesHandle bytes, UIntPtr offset, UIntPtr length)
	{
		return GBytesExterns.g_bytes_new_from_bytes(bytes, offset, length);
	}

	public static GBytesHandle Ref(this GBytesHandle bytes)
	{
		return GBytesExterns.g_bytes_ref(bytes);
	}

	public static GBytesHandle Unref(this GBytesHandle bytes)
	{
		GBytesExterns.g_bytes_unref(bytes);
		return bytes;
	}

	public static IntPtr UnrefToArray(this GBytesHandle bytes)
	{
		return GBytesExterns.g_bytes_unref_to_array(bytes);
	}

	public static IntPtr UnrefToData(this GBytesHandle bytes, out UIntPtr size)
	{
		return GBytesExterns.g_bytes_unref_to_data(bytes, out size);
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

	[DllImport(Libraries.GLib)]
	internal static extern int g_bytes_compare(IntPtr bytes1, IntPtr bytes2);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bytes_equal(IntPtr bytes1, IntPtr bytes2);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bytes_get_data(GBytesHandle bytes, out UIntPtr size);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bytes_get_region(GBytesHandle bytes, UIntPtr element_size, UIntPtr offset, UIntPtr n_elements);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_bytes_get_size(GBytesHandle bytes);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_bytes_hash(IntPtr bytes);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_from_bytes(GBytesHandle bytes, UIntPtr offset, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_ref(GBytesHandle bytes);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bytes_unref(GBytesHandle bytes);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bytes_unref_to_array(GBytesHandle bytes);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bytes_unref_to_data(GBytesHandle bytes, out UIntPtr size);

}

public struct GBytes
{
}
