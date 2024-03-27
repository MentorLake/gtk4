using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkGestureRotateHandle : GtkGestureHandle
{
	public static GtkGestureRotateHandle New()
	{
		return GtkGestureRotateExterns.gtk_gesture_rotate_new();
	}
}

public class GtkGestureRotateSignal
{
	public string Value { get; set; }
	public GtkGestureRotateSignal(string value) => Value = value;
}

public static class GtkGestureRotateSignals
{
	public static GtkGestureRotateSignal AngleChanged = new("angle-changed");
}

public static class GtkGestureRotateHandleExtensions
{
	public static double GetAngleDelta(this GtkGestureRotateHandle gesture)
	{
		return GtkGestureRotateExterns.gtk_gesture_rotate_get_angle_delta(gesture);
	}

	public static GtkGestureRotateHandle Connect(this GtkGestureRotateHandle instance, GtkGestureRotateSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkGestureRotateExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_gesture_rotate_get_angle_delta(GtkGestureRotateHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureRotateHandle gtk_gesture_rotate_new();
}
