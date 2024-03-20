using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkDropControllerMotionExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_controller_motion_contains_pointer")]
	internal static extern int gtk_drop_controller_motion_contains_pointer(this GtkDropControllerMotionHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_controller_motion_get_drop")]
	internal static extern GdkDropHandle gtk_drop_controller_motion_get_drop(this GtkDropControllerMotionHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_controller_motion_is_pointer")]
	internal static extern int gtk_drop_controller_motion_is_pointer(this GtkDropControllerMotionHandle self);
}
