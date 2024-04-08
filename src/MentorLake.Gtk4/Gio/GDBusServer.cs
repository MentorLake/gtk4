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

public class GDBusServerHandle : GObjectHandle, GInitableHandle
{
	public static GDBusServerHandle GDbusServerNewSync(string address, GDBusServerFlags flags, string guid, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusServerExterns.g_dbus_server_new_sync(address, flags, guid, observer, cancellable, out error);
	}

}

public class GDBusServerSignal
{
	public string Value { get; set; }
	public GDBusServerSignal(string value) => Value = value;
}

public static class GDBusServerSignals
{
	public static GDBusServerSignal NewConnection = new("new-connection");
}

public static class GDBusServerHandleExtensions
{
	public static string GDbusServerGetClientAddress(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_get_client_address(server);
	}

	public static GDBusServerFlags GDbusServerGetFlags(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_get_flags(server);
	}

	public static string GDbusServerGetGuid(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_get_guid(server);
	}

	public static bool GDbusServerIsActive(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_is_active(server);
	}

	public static GDBusServerHandle GDbusServerStart(this GDBusServerHandle server)
	{
		GDBusServerExterns.g_dbus_server_start(server);
		return server;
	}

	public static GDBusServerHandle GDbusServerStop(this GDBusServerHandle server)
	{
		GDBusServerExterns.g_dbus_server_stop(server);
		return server;
	}

	public static GDBusServerHandle Connect(this GDBusServerHandle instance, GDBusServerSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GDBusServerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusServerHandle g_dbus_server_new_sync(string address, GDBusServerFlags flags, string guid, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_server_get_client_address(GDBusServerHandle server);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusServerFlags g_dbus_server_get_flags(GDBusServerHandle server);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_server_get_guid(GDBusServerHandle server);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_server_is_active(GDBusServerHandle server);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_server_start(GDBusServerHandle server);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_server_stop(GDBusServerHandle server);
}
