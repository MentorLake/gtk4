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

public class GtkEventControllerKeyHandle : GtkEventControllerHandle
{
	public static GtkEventControllerKeyHandle New()
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_new();
	}
}

public class GtkEventControllerKeySignal
{
	public string Value { get; set; }
	public GtkEventControllerKeySignal(string value) => Value = value;
}

public static class GtkEventControllerKeySignals
{
	public static GtkEventControllerKeySignal ImUpdate = new("im-update");
	public static GtkEventControllerKeySignal KeyPressed = new("key-pressed");
	public static GtkEventControllerKeySignal KeyReleased = new("key-released");
	public static GtkEventControllerKeySignal Modifiers = new("modifiers");
}

public static class GtkEventControllerKeyHandleExtensions
{
	public static bool Forward(this GtkEventControllerKeyHandle controller, GtkWidgetHandle widget)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_forward(controller, widget);
	}

	public static uint GetGroup(this GtkEventControllerKeyHandle controller)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_get_group(controller);
	}

	public static GtkIMContextHandle GetImContext(this GtkEventControllerKeyHandle controller)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_get_im_context(controller);
	}

	public static GtkEventControllerKeyHandle SetImContext(this GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context)
	{
		GtkEventControllerKeyExterns.gtk_event_controller_key_set_im_context(controller, im_context);
		return controller;
	}

	public static GtkEventControllerKeyHandle Connect(this GtkEventControllerKeyHandle instance, GtkEventControllerKeySignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkEventControllerKeyExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_key_forward(GtkEventControllerKeyHandle controller, GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_event_controller_key_get_group(GtkEventControllerKeyHandle controller);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIMContextHandle gtk_event_controller_key_get_im_context(GtkEventControllerKeyHandle controller);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_key_set_im_context(GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerKeyHandle gtk_event_controller_key_new();
}
