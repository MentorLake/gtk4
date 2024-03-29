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

public class GtkGestureClickHandle : GtkGestureSingleHandle
{
	public static GtkGestureClickHandle New()
	{
		return GtkGestureClickExterns.gtk_gesture_click_new();
	}

}

public class GtkGestureClickSignal
{
	public string Value { get; set; }
	public GtkGestureClickSignal(string value) => Value = value;
}

public static class GtkGestureClickSignals
{
	public static GtkGestureClickSignal Pressed = new("pressed");
	public static GtkGestureClickSignal Released = new("released");
	public static GtkGestureClickSignal Stopped = new("stopped");
	public static GtkGestureClickSignal UnpairedRelease = new("unpaired-release");
}

public static class GtkGestureClickHandleExtensions
{
	public static GtkGestureClickHandle Connect(this GtkGestureClickHandle instance, GtkGestureClickSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkGestureClickExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureClickHandle gtk_gesture_click_new();
}
