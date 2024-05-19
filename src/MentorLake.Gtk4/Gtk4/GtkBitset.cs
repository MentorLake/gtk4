namespace MentorLake.Gtk4.Gtk4;

public class GtkBitsetHandle : BaseSafeHandle
{
	public static GtkBitsetHandle NewEmpty()
	{
		return GtkBitsetExterns.gtk_bitset_new_empty();
	}

	public static GtkBitsetHandle NewRange(uint start, uint n_items)
	{
		return GtkBitsetExterns.gtk_bitset_new_range(start, n_items);
	}

}

internal class GtkBitsetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBitsetHandle gtk_bitset_new_empty();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBitsetHandle gtk_bitset_new_range(uint start, uint n_items);

}

public struct GtkBitset
{
}
