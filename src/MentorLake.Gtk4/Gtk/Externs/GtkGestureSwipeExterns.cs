using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureSwipeExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_swipe_get_velocity")]
	internal static extern int gtk_gesture_swipe_get_velocity(this GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y);
}
