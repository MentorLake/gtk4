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

public interface GPollableOutputStreamHandle
{
}

internal class GPollableOutputStreamHandleImpl : BaseSafeHandle, GPollableOutputStreamHandle
{
}

public static class GPollableOutputStreamHandleExtensions
{
	public static bool CanPoll(this GPollableOutputStreamHandle stream)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_can_poll(stream);
	}

	public static GSourceHandle CreateSource(this GPollableOutputStreamHandle stream, GCancellableHandle cancellable)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_create_source(stream, cancellable);
	}

	public static bool IsWritable(this GPollableOutputStreamHandle stream)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_is_writable(stream);
	}

	public static int WriteNonblocking(this GPollableOutputStreamHandle stream, IntPtr buffer, int count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_write_nonblocking(stream, buffer, count, cancellable, out error);
	}

	public static GPollableReturn WritevNonblocking(this GPollableOutputStreamHandle stream, GOutputVector[] vectors, int n_vectors, out int bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_writev_nonblocking(stream, vectors, n_vectors, out bytes_written, cancellable, out error);
	}

}

internal class GPollableOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_output_stream_can_poll(GPollableOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_pollable_output_stream_create_source(GPollableOutputStreamHandle stream, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_output_stream_is_writable(GPollableOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_pollable_output_stream_write_nonblocking(GPollableOutputStreamHandle stream, IntPtr buffer, int count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GPollableReturn g_pollable_output_stream_writev_nonblocking(GPollableOutputStreamHandle stream, GOutputVector[] vectors, int n_vectors, out int bytes_written, GCancellableHandle cancellable, out GErrorHandle error);

}
