using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGesturePanExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_pan_get_orientation")]
	internal static extern GtkOrientation gtk_gesture_pan_get_orientation(this GtkGesturePanHandle gesture);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_pan_set_orientation")]
	internal static extern void gtk_gesture_pan_set_orientation(this GtkGesturePanHandle gesture, GtkOrientation orientation);
}
