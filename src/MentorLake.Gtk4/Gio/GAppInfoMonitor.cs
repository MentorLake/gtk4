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

namespace MentorLake.Gtk4.Gio;

public class GAppInfoMonitorHandle : GObjectHandle
{
}

public class GAppInfoMonitorSignal
{
	public string Value { get; set; }
	public GAppInfoMonitorSignal(string value) => Value = value;
}

public static class GAppInfoMonitorSignals
{
	public static GAppInfoMonitorSignal Changed = new("changed");
}

public static class GAppInfoMonitorHandleExtensions
{
	public static GAppInfoMonitorHandle Connect(this GAppInfoMonitorHandle instance, GAppInfoMonitorSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GAppInfoMonitorExterns
{
}
