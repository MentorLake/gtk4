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

public class GFileIOStreamHandle : GIOStreamHandle
{
}

public static class GFileIOStreamHandleExtensions
{
	public static string GFileIoStreamGetEtag(this GFileIOStreamHandle stream)
	{
		return GFileIOStreamExterns.g_file_io_stream_get_etag(stream);
	}

	public static GFileInfoHandle GFileIoStreamQueryInfo(this GFileIOStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileIOStreamExterns.g_file_io_stream_query_info(stream, attributes, cancellable, out error);
	}

	public static GFileIOStreamHandle GFileIoStreamQueryInfoAsync(this GFileIOStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileIOStreamExterns.g_file_io_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static GFileInfoHandle GFileIoStreamQueryInfoFinish(this GFileIOStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileIOStreamExterns.g_file_io_stream_query_info_finish(stream, result, out error);
	}

}

internal class GFileIOStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_file_io_stream_get_etag(GFileIOStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_io_stream_query_info(GFileIOStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_file_io_stream_query_info_async(GFileIOStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_io_stream_query_info_finish(GFileIOStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
}
