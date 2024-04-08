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

public class GBufferedOutputStreamHandle : GFilterOutputStreamHandle, GSeekableHandle
{
	public static GBufferedOutputStreamHandle New(GOutputStreamHandle base_stream)
	{
		return GBufferedOutputStreamExterns.g_buffered_output_stream_new(base_stream);
	}

	public static GBufferedOutputStreamHandle NewSized(GOutputStreamHandle base_stream, int size)
	{
		return GBufferedOutputStreamExterns.g_buffered_output_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedOutputStreamHandleExtensions
{
	public static bool GetAutoGrow(this GBufferedOutputStreamHandle stream)
	{
		return GBufferedOutputStreamExterns.g_buffered_output_stream_get_auto_grow(stream);
	}

	public static int GetBufferSize(this GBufferedOutputStreamHandle stream)
	{
		return GBufferedOutputStreamExterns.g_buffered_output_stream_get_buffer_size(stream);
	}

	public static GBufferedOutputStreamHandle SetAutoGrow(this GBufferedOutputStreamHandle stream, bool auto_grow)
	{
		GBufferedOutputStreamExterns.g_buffered_output_stream_set_auto_grow(stream, auto_grow);
		return stream;
	}

	public static GBufferedOutputStreamHandle SetBufferSize(this GBufferedOutputStreamHandle stream, int size)
	{
		GBufferedOutputStreamExterns.g_buffered_output_stream_set_buffer_size(stream, size);
		return stream;
	}

}

internal class GBufferedOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GBufferedOutputStreamHandle g_buffered_output_stream_new(GOutputStreamHandle base_stream);
	[DllImport(Libraries.Gio)]
	internal static extern GBufferedOutputStreamHandle g_buffered_output_stream_new_sized(GOutputStreamHandle base_stream, int size);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_buffered_output_stream_get_auto_grow(GBufferedOutputStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_output_stream_get_buffer_size(GBufferedOutputStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern void g_buffered_output_stream_set_auto_grow(GBufferedOutputStreamHandle stream, bool auto_grow);
	[DllImport(Libraries.Gio)]
	internal static extern void g_buffered_output_stream_set_buffer_size(GBufferedOutputStreamHandle stream, int size);
}
