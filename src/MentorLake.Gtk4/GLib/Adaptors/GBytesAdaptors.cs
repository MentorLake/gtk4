using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GBytesAdaptors
{
	public static GBytesHandle NewFromBytes(this GBytesHandle bytes, nuint offset, nuint length)
	{
		return GBytesExterns.g_bytes_new_from_bytes(bytes, offset, length);
	}

	public static IntPtr GetData(this GBytesHandle bytes, out nuint size)
	{
		return GBytesExterns.g_bytes_get_data(bytes, out size);
	}

	public static nuint GetSize(this GBytesHandle bytes)
	{
		return GBytesExterns.g_bytes_get_size(bytes);
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

	public static IntPtr UnrefToData(this GBytesHandle bytes, out nuint size)
	{
		return GBytesExterns.g_bytes_unref_to_data(bytes, out size);
	}

	public static GByteArrayHandle UnrefToArray(this GBytesHandle bytes)
	{
		return GBytesExterns.g_bytes_unref_to_array(bytes);
	}

	public static IntPtr GetRegion(this GBytesHandle bytes, nuint element_size, nuint offset, nuint n_elements)
	{
		return GBytesExterns.g_bytes_get_region(bytes, element_size, offset, n_elements);
	}

	public static GBytesHandle NewTake(IntPtr data, nuint size)
	{
		return GBytesExterns.g_bytes_new_take(data, size);
	}

	public static GBytesHandle NewStatic(IntPtr data, nuint size)
	{
		return GBytesExterns.g_bytes_new_static(data, size);
	}

	public static GBytesHandle NewWithFreeFunc(IntPtr data, nuint size, GDestroyNotify free_func, IntPtr user_data)
	{
		return GBytesExterns.g_bytes_new_with_free_func(data, size, free_func, user_data);
	}
}
