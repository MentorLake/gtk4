using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GArrayAdaptors
{
	public static IntPtr Steal(this GArrayHandle array, ref nuint len)
	{
		return GArrayExterns.g_array_steal(array, ref len);
	}

	public static GArrayHandle Copy(this GArrayHandle array)
	{
		return GArrayExterns.g_array_copy(array);
	}

	public static string Free(this GArrayHandle array, int free_segment)
	{
		return GArrayExterns.g_array_free(array, free_segment);
	}

	public static GArrayHandle Ref(this GArrayHandle array)
	{
		return GArrayExterns.g_array_ref(array);
	}

	public static GArrayHandle Unref(this GArrayHandle array)
	{
		GArrayExterns.g_array_unref(array);
		return array;
	}

	public static uint GetElementSize(this GArrayHandle array)
	{
		return GArrayExterns.g_array_get_element_size(array);
	}

	public static GArrayHandle AppendVals(this GArrayHandle array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_append_vals(array, data, len);
	}

	public static GArrayHandle PrependVals(this GArrayHandle array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_prepend_vals(array, data, len);
	}

	public static GArrayHandle InsertVals(this GArrayHandle array, uint index_, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_insert_vals(array, index_, data, len);
	}

	public static GArrayHandle SetSize(this GArrayHandle array, uint length)
	{
		return GArrayExterns.g_array_set_size(array, length);
	}

	public static GArrayHandle RemoveIndex(this GArrayHandle array, uint index_)
	{
		return GArrayExterns.g_array_remove_index(array, index_);
	}

	public static GArrayHandle RemoveIndexFast(this GArrayHandle array, uint index_)
	{
		return GArrayExterns.g_array_remove_index_fast(array, index_);
	}

	public static GArrayHandle RemoveRange(this GArrayHandle array, uint index_, uint length)
	{
		return GArrayExterns.g_array_remove_range(array, index_, length);
	}

	public static GArrayHandle Sort(this GArrayHandle array, GCompareFunc compare_func)
	{
		GArrayExterns.g_array_sort(array, compare_func);
		return array;
	}

	public static GArrayHandle SortWithData(this GArrayHandle array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GArrayExterns.g_array_sort_with_data(array, compare_func, user_data);
		return array;
	}

	public static int BinarySearch(this GArrayHandle array, IntPtr target, GCompareFunc compare_func, out uint out_match_index)
	{
		return GArrayExterns.g_array_binary_search(array, target, compare_func, out out_match_index);
	}

	public static GArrayHandle SetClearFunc(this GArrayHandle array, GDestroyNotify clear_func)
	{
		GArrayExterns.g_array_set_clear_func(array, clear_func);
		return array;
	}

	public static GArrayHandle SizedNew(int zero_terminated, int clear_, uint element_size, uint reserved_size)
	{
		return GArrayExterns.g_array_sized_new(zero_terminated, clear_, element_size, reserved_size);
	}
}
