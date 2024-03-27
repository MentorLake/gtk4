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

public class GtkSwitchHandle : GtkWidgetHandle
{
	public static GtkSwitchHandle New()
	{
		return GtkSwitchExterns.gtk_switch_new();
	}
}

public class GtkSwitchSignal
{
	public string Value { get; set; }
	public GtkSwitchSignal(string value) => Value = value;
}

public static class GtkSwitchSignals
{
	public static GtkSwitchSignal Activate = new("activate");
	public static GtkSwitchSignal StateSet = new("state-set");
}

public static class GtkSwitchHandleExtensions
{
	public static bool GetActive(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_active(self);
	}

	public static bool GetState(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_state(self);
	}

	public static GtkSwitchHandle SetActive(this GtkSwitchHandle self, bool is_active)
	{
		GtkSwitchExterns.gtk_switch_set_active(self, is_active);
		return self;
	}

	public static GtkSwitchHandle SetState(this GtkSwitchHandle self, bool state)
	{
		GtkSwitchExterns.gtk_switch_set_state(self, state);
		return self;
	}

	public static GtkSwitchHandle Connect(this GtkSwitchHandle instance, GtkSwitchSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkSwitchExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_switch_get_active(GtkSwitchHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_switch_get_state(GtkSwitchHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_switch_set_active(GtkSwitchHandle self, bool is_active);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_switch_set_state(GtkSwitchHandle self, bool state);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSwitchHandle gtk_switch_new();
}
