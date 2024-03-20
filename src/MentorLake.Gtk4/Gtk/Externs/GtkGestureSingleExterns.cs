using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureSingleExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_get_touch_only")]
	internal static extern int gtk_gesture_single_get_touch_only(this GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_set_touch_only")]
	internal static extern void gtk_gesture_single_set_touch_only(this GtkGestureSingleHandle gesture, int touch_only);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_get_exclusive")]
	internal static extern int gtk_gesture_single_get_exclusive(this GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_set_exclusive")]
	internal static extern void gtk_gesture_single_set_exclusive(this GtkGestureSingleHandle gesture, int exclusive);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_get_button")]
	internal static extern uint gtk_gesture_single_get_button(this GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_set_button")]
	internal static extern void gtk_gesture_single_set_button(this GtkGestureSingleHandle gesture, uint button);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_get_current_button")]
	internal static extern uint gtk_gesture_single_get_current_button(this GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_single_get_current_sequence")]
	internal static extern GdkEventSequenceHandle gtk_gesture_single_get_current_sequence(this GtkGestureSingleHandle gesture);
}
