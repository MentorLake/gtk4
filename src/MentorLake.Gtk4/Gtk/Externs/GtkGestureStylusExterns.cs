using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGestureStylusExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_stylus_get_axis")]
	internal static extern int gtk_gesture_stylus_get_axis(this GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_stylus_get_axes")]
	internal static extern int gtk_gesture_stylus_get_axes(this GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_stylus_get_backlog")]
	internal static extern int gtk_gesture_stylus_get_backlog(this GtkGestureStylusHandle gesture, out GdkTimeCoord[] backlog, out uint n_elems);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_stylus_get_device_tool")]
	internal static extern GdkDeviceToolHandle gtk_gesture_stylus_get_device_tool(this GtkGestureStylusHandle gesture);
}
