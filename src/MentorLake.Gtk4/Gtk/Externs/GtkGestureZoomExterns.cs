using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureZoomExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_zoom_get_scale_delta")]
	internal static extern double gtk_gesture_zoom_get_scale_delta(this GtkGestureZoomHandle gesture);
}
