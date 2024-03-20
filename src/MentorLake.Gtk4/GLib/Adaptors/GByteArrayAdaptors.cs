using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GByteArrayAdaptors
{
	public static byte[] Steal(this GByteArrayHandle array, ref nuint len)
	{
		return GByteArrayExterns.g_byte_array_steal(array, ref len);
	}

	public static byte[] Free(this GByteArrayHandle array, int free_segment)
	{
		return GByteArrayExterns.g_byte_array_free(array, free_segment);
	}

	public static GBytesHandle FreeToBytes(this GByteArrayHandle array)
	{
		return GByteArrayExterns.g_byte_array_free_to_bytes(array);
	}

	public static GByteArrayHandle Ref(this GByteArrayHandle array)
	{
		return GByteArrayExterns.g_byte_array_ref(array);
	}

	public static GByteArrayHandle Unref(this GByteArrayHandle array)
	{
		GByteArrayExterns.g_byte_array_unref(array);
		return array;
	}

	public static GByteArrayHandle Append(this GByteArrayHandle array, byte[] data, uint len)
	{
		return GByteArrayExterns.g_byte_array_append(array, data, len);
	}

	public static GByteArrayHandle Prepend(this GByteArrayHandle array, byte[] data, uint len)
	{
		return GByteArrayExterns.g_byte_array_prepend(array, data, len);
	}

	public static GByteArrayHandle SetSize(this GByteArrayHandle array, uint length)
	{
		return GByteArrayExterns.g_byte_array_set_size(array, length);
	}

	public static GByteArrayHandle RemoveIndex(this GByteArrayHandle array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index(array, index_);
	}

	public static GByteArrayHandle RemoveIndexFast(this GByteArrayHandle array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index_fast(array, index_);
	}

	public static GByteArrayHandle RemoveRange(this GByteArrayHandle array, uint index_, uint length)
	{
		return GByteArrayExterns.g_byte_array_remove_range(array, index_, length);
	}

	public static GByteArrayHandle Sort(this GByteArrayHandle array, GCompareFunc compare_func)
	{
		GByteArrayExterns.g_byte_array_sort(array, compare_func);
		return array;
	}

	public static GByteArrayHandle SortWithData(this GByteArrayHandle array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GByteArrayExterns.g_byte_array_sort_with_data(array, compare_func, user_data);
		return array;
	}

	public static GByteArrayHandle NewTake(byte[] data, nuint len)
	{
		return GByteArrayExterns.g_byte_array_new_take(data, len);
	}

	public static GByteArrayHandle SizedNew(uint reserved_size)
	{
		return GByteArrayExterns.g_byte_array_sized_new(reserved_size);
	}
}
