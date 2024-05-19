using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GTcpWrapperConnectionHandle : GTcpConnectionHandle
{
	public static GTcpWrapperConnectionHandle New(GIOStreamHandle base_io_stream, GSocketHandle socket)
	{
		return GTcpWrapperConnectionExterns.g_tcp_wrapper_connection_new(base_io_stream, socket);
	}

}

public static class GTcpWrapperConnectionHandleExtensions
{
	public static GIOStreamHandle GetBaseIoStream(this GTcpWrapperConnectionHandle conn)
	{
		return GTcpWrapperConnectionExterns.g_tcp_wrapper_connection_get_base_io_stream(conn);
	}

}

internal class GTcpWrapperConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTcpWrapperConnectionHandle g_tcp_wrapper_connection_new(GIOStreamHandle base_io_stream, GSocketHandle socket);

	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_tcp_wrapper_connection_get_base_io_stream(GTcpWrapperConnectionHandle conn);

}
