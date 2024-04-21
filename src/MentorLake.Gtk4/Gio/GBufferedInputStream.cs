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

public class GBufferedInputStreamHandle : GFilterInputStreamHandle, GSeekableHandle
{
	public static GBufferedInputStreamHandle New(GInputStreamHandle base_stream)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_new(base_stream);
	}

	public static GBufferedInputStreamHandle NewSized(GInputStreamHandle base_stream, int size)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedInputStreamHandleExtensions
{
	public static int Fill(this GBufferedInputStreamHandle stream, int count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_fill(stream, count, cancellable, out error);
	}

	public static GBufferedInputStreamHandle FillAsync(this GBufferedInputStreamHandle stream, int count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GBufferedInputStreamExterns.g_buffered_input_stream_fill_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static int FillFinish(this GBufferedInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_fill_finish(stream, result, out error);
	}

	public static int GetAvailable(this GBufferedInputStreamHandle stream)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_get_available(stream);
	}

	public static int GetBufferSize(this GBufferedInputStreamHandle stream)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_get_buffer_size(stream);
	}

	public static int Peek(this GBufferedInputStreamHandle stream, IntPtr buffer, int offset, int count)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_peek(stream, buffer, offset, count);
	}

	public static IntPtr PeekBuffer(this GBufferedInputStreamHandle stream, out int count)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_peek_buffer(stream, out count);
	}

	public static int ReadByte(this GBufferedInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_read_byte(stream, cancellable, out error);
	}

	public static GBufferedInputStreamHandle SetBufferSize(this GBufferedInputStreamHandle stream, int size)
	{
		GBufferedInputStreamExterns.g_buffered_input_stream_set_buffer_size(stream, size);
		return stream;
	}

}

internal class GBufferedInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GBufferedInputStreamHandle g_buffered_input_stream_new(GInputStreamHandle base_stream);

	[DllImport(Libraries.Gio)]
	internal static extern GBufferedInputStreamHandle g_buffered_input_stream_new_sized(GInputStreamHandle base_stream, int size);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_fill(GBufferedInputStreamHandle stream, int count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_buffered_input_stream_fill_async(GBufferedInputStreamHandle stream, int count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_fill_finish(GBufferedInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_get_available(GBufferedInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_get_buffer_size(GBufferedInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_peek(GBufferedInputStreamHandle stream, IntPtr buffer, int offset, int count);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_buffered_input_stream_peek_buffer(GBufferedInputStreamHandle stream, out int count);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_read_byte(GBufferedInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_buffered_input_stream_set_buffer_size(GBufferedInputStreamHandle stream, int size);

}
