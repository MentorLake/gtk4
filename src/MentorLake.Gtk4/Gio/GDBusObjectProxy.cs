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

public class GDBusObjectProxyHandle : GObjectHandle
{
	public static GDBusObjectProxyHandle GDbusObjectProxyNew(GDBusConnectionHandle connection, string object_path)
	{
		return GDBusObjectProxyExterns.g_dbus_object_proxy_new(connection, object_path);
	}

}

public static class GDBusObjectProxyHandleExtensions
{
	public static GDBusConnectionHandle GDbusObjectProxyGetConnection(this GDBusObjectProxyHandle proxy)
	{
		return GDBusObjectProxyExterns.g_dbus_object_proxy_get_connection(proxy);
	}

}

internal class GDBusObjectProxyExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectProxyHandle g_dbus_object_proxy_new(GDBusConnectionHandle connection, string object_path);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_object_proxy_get_connection(GDBusObjectProxyHandle proxy);
}
