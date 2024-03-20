using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureLongPressExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_long_press_set_delay_factor")]
	internal static extern void gtk_gesture_long_press_set_delay_factor(this GtkGestureLongPressHandle gesture, double delay_factor);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_long_press_get_delay_factor")]
	internal static extern double gtk_gesture_long_press_get_delay_factor(this GtkGestureLongPressHandle gesture);
}
