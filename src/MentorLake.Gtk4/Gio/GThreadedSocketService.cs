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

public class GThreadedSocketServiceHandle : GSocketServiceHandle
{
	public static GThreadedSocketServiceHandle New(int max_threads)
	{
		return GThreadedSocketServiceExterns.g_threaded_socket_service_new(max_threads);
	}
}

public class GThreadedSocketServiceSignal
{
	public string Value { get; set; }
	public GThreadedSocketServiceSignal(string value) => Value = value;
}

public static class GThreadedSocketServiceSignals
{
	public static GThreadedSocketServiceSignal Run = new("run");
}

public static class GThreadedSocketServiceHandleExtensions
{
	public static GThreadedSocketServiceHandle Connect(this GThreadedSocketServiceHandle instance, GThreadedSocketServiceSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GThreadedSocketServiceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GThreadedSocketServiceHandle g_threaded_socket_service_new(int max_threads);
}