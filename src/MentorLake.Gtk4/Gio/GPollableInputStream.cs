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

public interface GPollableInputStreamHandle
{
}

public static class GPollableInputStreamHandleExtensions
{
	public static bool CanPoll(this GPollableInputStreamHandle stream)
	{
		return GPollableInputStreamExterns.g_pollable_input_stream_can_poll(stream);
	}

	public static GSourceHandle CreateSource(this GPollableInputStreamHandle stream, GCancellableHandle cancellable)
	{
		return GPollableInputStreamExterns.g_pollable_input_stream_create_source(stream, cancellable);
	}

	public static bool IsReadable(this GPollableInputStreamHandle stream)
	{
		return GPollableInputStreamExterns.g_pollable_input_stream_is_readable(stream);
	}

	public static int ReadNonblocking(this GPollableInputStreamHandle stream, out IntPtr buffer, int count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPollableInputStreamExterns.g_pollable_input_stream_read_nonblocking(stream, out buffer, count, cancellable, out error);
	}

}

internal class GPollableInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_input_stream_can_poll(GPollableInputStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_pollable_input_stream_create_source(GPollableInputStreamHandle stream, GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_input_stream_is_readable(GPollableInputStreamHandle stream);
	[DllImport(Libraries.Gio)]
	internal static extern int g_pollable_input_stream_read_nonblocking(GPollableInputStreamHandle stream, out IntPtr buffer, int count, GCancellableHandle cancellable, out GErrorHandle error);
}
