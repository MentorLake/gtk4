namespace MentorLake.Gtk4.GObject;

public class GValueArrayHandle : BaseSafeHandle
{
	public static GValueArrayHandle New(uint n_prealloced)
	{
		return GValueArrayExterns.g_value_array_new(n_prealloced);
	}

}


public static class GValueArrayHandleExtensions
{
	public static GValueArrayHandle Append(this GValueArrayHandle value_array, GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_append(value_array, value);
	}

	public static GValueArrayHandle Copy(this GValueArrayHandle value_array)
	{
		return GValueArrayExterns.g_value_array_copy(value_array);
	}

	public static GValueArrayHandle Free(this GValueArrayHandle value_array)
	{
		GValueArrayExterns.g_value_array_free(value_array);
		return value_array;
	}

	public static GValueHandle GetNth(this GValueArrayHandle value_array, uint index_)
	{
		return GValueArrayExterns.g_value_array_get_nth(value_array, index_);
	}

	public static GValueArrayHandle Insert(this GValueArrayHandle value_array, uint index_, GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_insert(value_array, index_, value);
	}

	public static GValueArrayHandle Prepend(this GValueArrayHandle value_array, GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_prepend(value_array, value);
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
internal class GValueArrayExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_new(uint n_prealloced);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_append(GValueArrayHandle value_array, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_copy(GValueArrayHandle value_array);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_array_free(GValueArrayHandle value_array);

	[DllImport(Libraries.GObject)]
	internal static extern GValueHandle g_value_array_get_nth(GValueArrayHandle value_array, uint index_);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_insert(GValueArrayHandle value_array, uint index_, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_prepend(GValueArrayHandle value_array, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_remove(GValueArrayHandle value_array, uint index_);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_sort(GValueArrayHandle value_array, GCompareFunc compare_func);

	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_sort_with_data(GValueArrayHandle value_array, GCompareDataFunc compare_func, IntPtr user_data);

}

public struct GValueArray
{
	public uint n_values;
	public GValueHandle values;
}
