namespace MentorLake.Gtk4.GLib;

public class GSequenceIterHandle : BaseSafeHandle
{
}


public static class GSequenceIterHandleExtensions
{
	public static int Compare(this GSequenceIterHandle a, GSequenceIterHandle b)
	{
		return GSequenceIterExterns.g_sequence_iter_compare(a, b);
	}

	public static int GetPosition(this GSequenceIterHandle iter)
	{
		return GSequenceIterExterns.g_sequence_iter_get_position(iter);
	}

	public static GSequenceHandle GetSequence(this GSequenceIterHandle iter)
	{
		return GSequenceIterExterns.g_sequence_iter_get_sequence(iter);
	}

	public static bool IsBegin(this GSequenceIterHandle iter)
	{
		return GSequenceIterExterns.g_sequence_iter_is_begin(iter);
	}

	public static bool IsEnd(this GSequenceIterHandle iter)
	{
		return GSequenceIterExterns.g_sequence_iter_is_end(iter);
	}

	public static GSequenceIterHandle Move(this GSequenceIterHandle iter, int delta)
	{
		return GSequenceIterExterns.g_sequence_iter_move(iter, delta);
	}

	public static GSequenceIterHandle Next(this GSequenceIterHandle iter)
	{
		return GSequenceIterExterns.g_sequence_iter_next(iter);
	}

	public static GSequenceIterHandle Prev(this GSequenceIterHandle iter)
	{
		return GSequenceIterExterns.g_sequence_iter_prev(iter);
	}

}
internal class GSequenceIterExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern int g_sequence_iter_compare(GSequenceIterHandle a, GSequenceIterHandle b);

	[DllImport(Libraries.GLib)]
	internal static extern int g_sequence_iter_get_position(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceHandle g_sequence_iter_get_sequence(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_sequence_iter_is_begin(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_sequence_iter_is_end(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_iter_move(GSequenceIterHandle iter, int delta);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_iter_next(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_iter_prev(GSequenceIterHandle iter);

}

public struct GSequenceIter
{
}
