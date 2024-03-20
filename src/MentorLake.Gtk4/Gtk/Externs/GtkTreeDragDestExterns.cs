using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeDragDestExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_drag_dest_drag_data_received")]
	internal static extern int gtk_tree_drag_dest_drag_data_received(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest, GValueHandle value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_drag_dest_row_drop_possible")]
	internal static extern int gtk_tree_drag_dest_row_drop_possible(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest_path, GValueHandle value);
}
