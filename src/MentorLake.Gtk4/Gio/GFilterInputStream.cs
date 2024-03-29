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

public class GFilterInputStreamHandle : GInputStreamHandle
{
}

public static class GFilterInputStreamHandleExtensions
{
	public static GInputStreamHandle GetBaseStream(this GFilterInputStreamHandle stream)
	{
		return GFilterInputStreamExterns.g_filter_input_stream_get_base_stream(stream);
	}

	public static bool GetCloseBaseStream(this GFilterInputStreamHandle stream)
	{
		return GFilterInputStreamExterns.g_filter_input_stream_get_close_base_stream(stream);
	}

	public static GFilterInputStreamHandle SetCloseBaseStream(this GFilterInputStreamHandle stream, bool close_base)
	{
		GFilterInputStreamExterns.g_filter_input_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_filter_input_stream_get_base_stream(GFilterInputStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_filter_input_stream_get_close_base_stream(GFilterInputStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern void g_filter_input_stream_set_close_base_stream(GFilterInputStreamHandle stream, bool close_base);
}
