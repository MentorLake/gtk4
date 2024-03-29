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

public class GUnixConnectionHandle : GSocketConnectionHandle
{
}

public static class GUnixConnectionHandleExtensions
{
	public static GCredentialsHandle ReceiveCredentials(this GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_receive_credentials(connection, cancellable, out error);
	}

	public static GUnixConnectionHandle ReceiveCredentialsAsync(this GUnixConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GUnixConnectionExterns.g_unix_connection_receive_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static GCredentialsHandle ReceiveCredentialsFinish(this GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_receive_credentials_finish(connection, result, out error);
	}

	public static int ReceiveFd(this GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_receive_fd(connection, cancellable, out error);
	}

	public static bool SendCredentials(this GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_send_credentials(connection, cancellable, out error);
	}

	public static GUnixConnectionHandle SendCredentialsAsync(this GUnixConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GUnixConnectionExterns.g_unix_connection_send_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool SendCredentialsFinish(this GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_send_credentials_finish(connection, result, out error);
	}

	public static bool SendFd(this GUnixConnectionHandle connection, int fd, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_send_fd(connection, fd, cancellable, out error);
	}

}

internal class GUnixConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_unix_connection_receive_credentials(GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_connection_receive_credentials_async(GUnixConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_unix_connection_receive_credentials_finish(GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_connection_receive_fd(GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_connection_send_credentials(GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_connection_send_credentials_async(GUnixConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_connection_send_credentials_finish(GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_connection_send_fd(GUnixConnectionHandle connection, int fd, GCancellableHandle cancellable, out GErrorHandle error);
}
