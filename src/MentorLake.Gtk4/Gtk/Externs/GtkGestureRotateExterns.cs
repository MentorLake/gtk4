using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureRotateExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_rotate_get_angle_delta")]
	internal static extern double gtk_gesture_rotate_get_angle_delta(this GtkGestureRotateHandle gesture);
}
