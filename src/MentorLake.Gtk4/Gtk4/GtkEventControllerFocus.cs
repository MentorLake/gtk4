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

public class GtkEventControllerFocusHandle : GtkEventControllerHandle
{
	public static GtkEventControllerFocusHandle New()
	{
		return GtkEventControllerFocusExterns.gtk_event_controller_focus_new();
	}

}

public class GtkEventControllerFocusSignal
{
	public string Value { get; set; }
	public GtkEventControllerFocusSignal(string value) => Value = value;
}

public static class GtkEventControllerFocusSignals
{
	public static GtkEventControllerFocusSignal Enter = new("enter");
	public static GtkEventControllerFocusSignal Leave = new("leave");
}

public static class GtkEventControllerFocusHandleExtensions
{
	public static bool ContainsFocus(this GtkEventControllerFocusHandle self)
	{
		return GtkEventControllerFocusExterns.gtk_event_controller_focus_contains_focus(self);
	}

	public static bool IsFocus(this GtkEventControllerFocusHandle self)
	{
		return GtkEventControllerFocusExterns.gtk_event_controller_focus_is_focus(self);
	}

	public static GtkEventControllerFocusHandle Connect(this GtkEventControllerFocusHandle instance, GtkEventControllerFocusSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkEventControllerFocusExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerFocusHandle gtk_event_controller_focus_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_focus_contains_focus(GtkEventControllerFocusHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_focus_is_focus(GtkEventControllerFocusHandle self);
}
