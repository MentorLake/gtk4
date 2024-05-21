namespace MentorLake.Gtk4.GLib;

public class GSequenceHandle : BaseSafeHandle
{
}


public static class GSequenceHandleExtensions
{
	public static GSequenceIterHandle Append(this GSequenceHandle seq, IntPtr data)
	{
		return GSequenceExterns.g_sequence_append(seq, data);
	}

	public static GSequenceHandle Foreach(this GSequenceHandle seq, GFunc func, IntPtr user_data)
	{
		GSequenceExterns.g_sequence_foreach(seq, func, user_data);
		return seq;
	}

	public static GSequenceHandle Free(this GSequenceHandle seq)
	{
		GSequenceExterns.g_sequence_free(seq);
		return seq;
	}

	public static GSequenceIterHandle GetBeginIter(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_get_begin_iter(seq);
	}

	public static GSequenceIterHandle GetEndIter(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_get_end_iter(seq);
	}

	public static GSequenceIterHandle GetIterAtPos(this GSequenceHandle seq, int pos)
	{
		return GSequenceExterns.g_sequence_get_iter_at_pos(seq, pos);
	}

	public static int GetLength(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_get_length(seq);
	}

	public static GSequenceIterHandle InsertSorted(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_insert_sorted(seq, data, cmp_func, cmp_data);
	}

	public static GSequenceIterHandle InsertSortedIter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_insert_sorted_iter(seq, data, iter_cmp, cmp_data);
	}

	public static bool IsEmpty(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_is_empty(seq);
	}

	public static GSequenceIterHandle Lookup(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_lookup(seq, data, cmp_func, cmp_data);
	}

	public static GSequenceIterHandle LookupIter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_lookup_iter(seq, data, iter_cmp, cmp_data);
	}

	public static GSequenceIterHandle Prepend(this GSequenceHandle seq, IntPtr data)
	{
		return GSequenceExterns.g_sequence_prepend(seq, data);
	}

	public static GSequenceIterHandle Search(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_search(seq, data, cmp_func, cmp_data);
	}

	public static GSequenceIterHandle SearchIter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_search_iter(seq, data, iter_cmp, cmp_data);
	}

	public static GSequenceHandle Sort(this GSequenceHandle seq, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort(seq, cmp_func, cmp_data);
		return seq;
	}

	public static GSequenceHandle SortIter(this GSequenceHandle seq, GSequenceIterCompareFunc cmp_func, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_iter(seq, cmp_func, cmp_data);
		return seq;
	}

}
internal class GSequenceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_append(GSequenceHandle seq, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_foreach(GSequenceHandle seq, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_free(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_get_begin_iter(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_get_end_iter(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_get_iter_at_pos(GSequenceHandle seq, int pos);

	[DllImport(Libraries.GLib)]
	internal static extern int g_sequence_get_length(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_insert_sorted(GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_insert_sorted_iter(GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_sequence_is_empty(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_lookup(GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_lookup_iter(GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_prepend(GSequenceHandle seq, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_search(GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_search_iter(GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_sort(GSequenceHandle seq, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_sort_iter(GSequenceHandle seq, GSequenceIterCompareFunc cmp_func, IntPtr cmp_data);

}

public struct GSequence
{
}
