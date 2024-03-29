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

public class GtkGestureZoomHandle : GtkGestureHandle
{
	public static GtkGestureZoomHandle New()
	{
		return GtkGestureZoomExterns.gtk_gesture_zoom_new();
	}

}

public class GtkGestureZoomSignal
{
	public string Value { get; set; }
	public GtkGestureZoomSignal(string value) => Value = value;
}

public static class GtkGestureZoomSignals
{
	public static GtkGestureZoomSignal ScaleChanged = new("scale-changed");
}

public static class GtkGestureZoomHandleExtensions
{
	public static double GetScaleDelta(this GtkGestureZoomHandle gesture)
	{
		return GtkGestureZoomExterns.gtk_gesture_zoom_get_scale_delta(gesture);
	}

	public static GtkGestureZoomHandle Connect(this GtkGestureZoomHandle instance, GtkGestureZoomSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkGestureZoomExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureZoomHandle gtk_gesture_zoom_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_gesture_zoom_get_scale_delta(GtkGestureZoomHandle gesture);
}
