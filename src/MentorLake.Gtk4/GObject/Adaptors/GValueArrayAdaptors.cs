using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GValueArrayAdaptors
{
	public static GValueHandle GetNth(this GValueArrayHandle value_array, uint index_)
	{
		return GValueArrayExterns.g_value_array_get_nth(value_array, index_);
	}

	public static GValueArrayHandle Free(this GValueArrayHandle value_array)
	{
		GValueArrayExterns.g_value_array_free(value_array);
		return value_array;
	}

	public static GValueArrayHandle Copy(this GValueArrayHandle value_array)
	{
		return GValueArrayExterns.g_value_array_copy(value_array);
	}

	public static GValueArrayHandle Prepend(this GValueArrayHandle value_array, GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_prepend(value_array, value);
	}

	public static GValueArrayHandle Append(this GValueArrayHandle value_array, GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_append(value_array, value);
	}

	public static GValueArrayHandle Insert(this GValueArrayHandle value_array, uint index_, GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_insert(value_array, index_, value);
	}

	public static GValueArrayHandle Remove(this GValueArrayHandle value_array, uint index_)
	{
		return GValueArrayExterns.g_value_array_remove(value_array, index_);
	}

	public static GValueArrayHandle Sort(this GValueArrayHandle value_array, GCompareFunc compare_func)
	{
		return GValueArrayExterns.g_value_array_sort(value_array, compare_func);
	}

	public static GValueArrayHandle SortWithData(this GValueArrayHandle value_array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GValueArrayExterns.g_value_array_sort_with_data(value_array, compare_func, user_data);
	}
}
