using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureDragExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_drag_get_start_point")]
	internal static extern int gtk_gesture_drag_get_start_point(this GtkGestureDragHandle gesture, out double x, out double y);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_drag_get_offset")]
	internal static extern int gtk_gesture_drag_get_offset(this GtkGestureDragHandle gesture, out double x, out double y);
}
