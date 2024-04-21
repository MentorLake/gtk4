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

public class GFileOutputStreamHandle : GOutputStreamHandle, GSeekableHandle
{
}

public static class GFileOutputStreamHandleExtensions
{
	public static string GetEtag(this GFileOutputStreamHandle stream)
	{
		return GFileOutputStreamExterns.g_file_output_stream_get_etag(stream);
	}

	public static GFileInfoHandle QueryInfo(this GFileOutputStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileOutputStreamExterns.g_file_output_stream_query_info(stream, attributes, cancellable, out error);
	}

	public static GFileOutputStreamHandle QueryInfoAsync(this GFileOutputStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileOutputStreamExterns.g_file_output_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static GFileInfoHandle QueryInfoFinish(this GFileOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileOutputStreamExterns.g_file_output_stream_query_info_finish(stream, result, out error);
	}

}

internal class GFileOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_file_output_stream_get_etag(GFileOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_output_stream_query_info(GFileOutputStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_output_stream_query_info_async(GFileOutputStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_output_stream_query_info_finish(GFileOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

}
