using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GdkDragExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_icon_get_for_drag")]
	internal static extern GtkWidgetHandle gtk_drag_icon_get_for_drag(this GdkDragHandle drag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_icon_set_from_paintable")]
	internal static extern void gtk_drag_icon_set_from_paintable(this GdkDragHandle drag, GdkPaintableHandle paintable, int hot_x, int hot_y);
}
