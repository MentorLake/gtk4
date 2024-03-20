using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkDragIconExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_icon_set_child")]
	internal static extern void gtk_drag_icon_set_child(this GtkDragIconHandle self, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_icon_get_child")]
	internal static extern GtkWidgetHandle gtk_drag_icon_get_child(this GtkDragIconHandle self);
}
