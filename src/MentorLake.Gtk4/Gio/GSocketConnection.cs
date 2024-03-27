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

public class GSocketConnectionHandle : GIOStreamHandle
{
}

public static class GSocketConnectionSignals
{
}

public static class GSocketConnectionHandleExtensions
{
	public static bool Connect(this GSocketConnectionHandle connection, GSocketAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketConnectionExterns.g_socket_connection_connect(connection, address, cancellable, out error);
	}

	public static GSocketConnectionHandle ConnectAsync(this GSocketConnectionHandle connection, GSocketAddressHandle address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketConnectionExterns.g_socket_connection_connect_async(connection, address, cancellable, callback, user_data);
		return connection;
	}

	public static bool ConnectFinish(this GSocketConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketConnectionExterns.g_socket_connection_connect_finish(connection, result, out error);
	}

	public static GSocketAddressHandle GetLocalAddress(this GSocketConnectionHandle connection, out GErrorHandle error)
	{
		return GSocketConnectionExterns.g_socket_connection_get_local_address(connection, out error);
	}

	public static GSocketAddressHandle GetRemoteAddress(this GSocketConnectionHandle connection, out GErrorHandle error)
	{
		return GSocketConnectionExterns.g_socket_connection_get_remote_address(connection, out error);
	}

	public static GSocketHandle GetSocket(this GSocketConnectionHandle connection)
	{
		return GSocketConnectionExterns.g_socket_connection_get_socket(connection);
	}

	public static bool IsConnected(this GSocketConnectionHandle connection)
	{
		return GSocketConnectionExterns.g_socket_connection_is_connected(connection);
	}

}

internal class GSocketConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_connection_connect(GSocketConnectionHandle connection, GSocketAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_connection_connect_async(GSocketConnectionHandle connection, GSocketAddressHandle address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_connection_connect_finish(GSocketConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_connection_get_local_address(GSocketConnectionHandle connection, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_connection_get_remote_address(GSocketConnectionHandle connection, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketHandle g_socket_connection_get_socket(GSocketConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_connection_is_connected(GSocketConnectionHandle connection);
}
