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

public class GtkEventControllerMotionHandle : GtkEventControllerHandle
{
	public static GtkEventControllerMotionHandle New()
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_new();
	}

}

public class GtkEventControllerMotionSignal
{
	public string Value { get; set; }
	public GtkEventControllerMotionSignal(string value) => Value = value;
}

public static class GtkEventControllerMotionSignals
{
	public static GtkEventControllerMotionSignal Enter = new("enter");
	public static GtkEventControllerMotionSignal Leave = new("leave");
	public static GtkEventControllerMotionSignal Motion = new("motion");
}

public static class GtkEventControllerMotionHandleExtensions
{
	public static bool ContainsPointer(this GtkEventControllerMotionHandle self)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_contains_pointer(self);
	}

	public static bool IsPointer(this GtkEventControllerMotionHandle self)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_is_pointer(self);
	}

	public static GtkEventControllerMotionHandle Connect(this GtkEventControllerMotionHandle instance, GtkEventControllerMotionSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkEventControllerMotionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerMotionHandle gtk_event_controller_motion_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_motion_contains_pointer(GtkEventControllerMotionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_motion_is_pointer(GtkEventControllerMotionHandle self);
}
