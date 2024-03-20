using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBitsetIterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_init_first")]
	internal static extern int gtk_bitset_iter_init_first(this GtkBitsetIterHandle iter, GtkBitsetHandle set, out uint value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_init_last")]
	internal static extern int gtk_bitset_iter_init_last(this GtkBitsetIterHandle iter, GtkBitsetHandle set, out uint value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_init_at")]
	internal static extern int gtk_bitset_iter_init_at(this GtkBitsetIterHandle iter, GtkBitsetHandle set, uint target, out uint value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_next")]
	internal static extern int gtk_bitset_iter_next(this GtkBitsetIterHandle iter, out uint value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_previous")]
	internal static extern int gtk_bitset_iter_previous(this GtkBitsetIterHandle iter, out uint value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_get_value")]
	internal static extern uint gtk_bitset_iter_get_value(this GtkBitsetIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_iter_is_valid")]
	internal static extern int gtk_bitset_iter_is_valid(this GtkBitsetIterHandle iter);
}
