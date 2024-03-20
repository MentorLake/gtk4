using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeIterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_iter_copy")]
	internal static extern GtkTreeIterHandle gtk_tree_iter_copy(this GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_iter_free")]
	internal static extern void gtk_tree_iter_free(this GtkTreeIterHandle iter);
}
