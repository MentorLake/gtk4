using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPtrArrayAdaptors
{
	public static IntPtr[] Steal(this GPtrArrayHandle array, ref nuint len)
	{
		return GPtrArrayExterns.g_ptr_array_steal(array, ref len);
	}

	public static GPtrArrayHandle Copy(this GPtrArrayHandle array, GCopyFunc func, IntPtr user_data)
	{
		return GPtrArrayExterns.g_ptr_array_copy(array, func, user_data);
	}

	public static IntPtr[] Free(this GPtrArrayHandle array, int free_seg)
	{
		return GPtrArrayExterns.g_ptr_array_free(array, free_seg);
	}

	public static GPtrArrayHandle Ref(this GPtrArrayHandle array)
	{
		return GPtrArrayExterns.g_ptr_array_ref(array);
	}

	public static GPtrArrayHandle Unref(this GPtrArrayHandle array)
	{
		GPtrArrayExterns.g_ptr_array_unref(array);
		return array;
	}

	public static GPtrArrayHandle SetFreeFunc(this GPtrArrayHandle array, GDestroyNotify element_free_func)
	{
		GPtrArrayExterns.g_ptr_array_set_free_func(array, element_free_func);
		return array;
	}

	public static GPtrArrayHandle SetSize(this GPtrArrayHandle array, int length)
	{
		GPtrArrayExterns.g_ptr_array_set_size(array, length);
		return array;
	}

	public static IntPtr RemoveIndex(this GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index(array, index_);
	}

	public static IntPtr RemoveIndexFast(this GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index_fast(array, index_);
	}

	public static IntPtr StealIndex(this GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index(array, index_);
	}

	public static IntPtr StealIndexFast(this GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index_fast(array, index_);
	}

	public static int Remove(this GPtrArrayHandle array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove(array, data);
	}

	public static int RemoveFast(this GPtrArrayHandle array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove_fast(array, data);
	}

	public static GPtrArrayHandle RemoveRange(this GPtrArrayHandle array, uint index_, uint length)
	{
		return GPtrArrayExterns.g_ptr_array_remove_range(array, index_, length);
	}

	public static GPtrArrayHandle Add(this GPtrArrayHandle array, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_add(array, data);
		return array;
	}

	public static GPtrArrayHandle Extend(this GPtrArrayHandle array_to_extend, GPtrArrayHandle array, GCopyFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_extend(array_to_extend, array, func, user_data);
		return array_to_extend;
	}

	public static GPtrArrayHandle ExtendAndSteal(this GPtrArrayHandle array_to_extend, GPtrArrayHandle array)
	{
		GPtrArrayExterns.g_ptr_array_extend_and_steal(array_to_extend, array);
		return array_to_extend;
	}

	public static GPtrArrayHandle Insert(this GPtrArrayHandle array, int index_, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_insert(array, index_, data);
		return array;
	}

	public static GPtrArrayHandle Sort(this GPtrArrayHandle array, GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort(array, compare_func);
		return array;
	}

	public static GPtrArrayHandle SortWithData(this GPtrArrayHandle array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_with_data(array, compare_func, user_data);
		return array;
	}

	public static GPtrArrayHandle Foreach(this GPtrArrayHandle array, IntPtr func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_foreach(array, func, user_data);
		return array;
	}

	public static int Find(this GPtrArrayHandle haystack, IntPtr needle, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find(haystack, needle, out index_);
	}

	public static int FindWithEqualFunc(this GPtrArrayHandle haystack, IntPtr needle, GEqualFunc equal_func, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find_with_equal_func(haystack, needle, equal_func, out index_);
	}

	public static GPtrArrayHandle NewWithFreeFunc(GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_with_free_func(element_free_func);
	}

	public static GPtrArrayHandle SizedNew(uint reserved_size)
	{
		return GPtrArrayExterns.g_ptr_array_sized_new(reserved_size);
	}

	public static GPtrArrayHandle NewFull(uint reserved_size, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_full(reserved_size, element_free_func);
	}
}
