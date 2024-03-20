using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkEventControllerMotionExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_motion_contains_pointer")]
	internal static extern int gtk_event_controller_motion_contains_pointer(this GtkEventControllerMotionHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_motion_is_pointer")]
	internal static extern int gtk_event_controller_motion_is_pointer(this GtkEventControllerMotionHandle self);
}
