namespace MentorLake.Gtk4.Gtk4;

public class GtkBitsetIterHandle : BaseSafeHandle
{
}


public static class GtkBitsetIterHandleExtensions
{
	public static uint GetValue(this GtkBitsetIterHandle iter)
	{
		return GtkBitsetIterExterns.gtk_bitset_iter_get_value(iter);
	}

	public static bool IsValid(this GtkBitsetIterHandle iter)
	{
		return GtkBitsetIterExterns.gtk_bitset_iter_is_valid(iter);
	}

	public static bool Next(this GtkBitsetIterHandle iter, out uint value)
	{
		return GtkBitsetIterExterns.gtk_bitset_iter_next(iter, out value);
	}

	public static bool Previous(this GtkBitsetIterHandle iter, out uint value)
	{
		return GtkBitsetIterExterns.gtk_bitset_iter_previous(iter, out value);
	}

}
internal class GtkBitsetIterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_bitset_iter_get_value(GtkBitsetIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_bitset_iter_is_valid(GtkBitsetIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_bitset_iter_next(GtkBitsetIterHandle iter, out uint value);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_bitset_iter_previous(GtkBitsetIterHandle iter, out uint value);

}

public struct GtkBitsetIter
{
}
