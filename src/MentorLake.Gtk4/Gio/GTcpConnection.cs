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

public class GTcpConnectionHandle : GSocketConnectionHandle
{
}

public static class GTcpConnectionHandleExtensions
{
	public static bool GetGracefulDisconnect(this GTcpConnectionHandle connection)
	{
		return GTcpConnectionExterns.g_tcp_connection_get_graceful_disconnect(connection);
	}

	public static GTcpConnectionHandle SetGracefulDisconnect(this GTcpConnectionHandle connection, bool graceful_disconnect)
	{
		GTcpConnectionExterns.g_tcp_connection_set_graceful_disconnect(connection, graceful_disconnect);
		return connection;
	}

}

internal class GTcpConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_tcp_connection_get_graceful_disconnect(GTcpConnectionHandle connection);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tcp_connection_set_graceful_disconnect(GTcpConnectionHandle connection, bool graceful_disconnect);

}
