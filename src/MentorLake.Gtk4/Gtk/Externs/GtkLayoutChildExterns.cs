using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkLayoutChildExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_child_get_layout_manager")]
	internal static extern GtkLayoutManagerHandle gtk_layout_child_get_layout_manager(this GtkLayoutChildHandle layout_child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_child_get_child_widget")]
	internal static extern GtkWidgetHandle gtk_layout_child_get_child_widget(this GtkLayoutChildHandle layout_child);
}
