using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeDragSourceExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_drag_source_row_draggable")]
	internal static extern int gtk_tree_drag_source_row_draggable(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_drag_source_drag_data_delete")]
	internal static extern int gtk_tree_drag_source_drag_data_delete(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_drag_source_drag_data_get")]
	internal static extern GdkContentProviderHandle gtk_tree_drag_source_drag_data_get(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);
}
