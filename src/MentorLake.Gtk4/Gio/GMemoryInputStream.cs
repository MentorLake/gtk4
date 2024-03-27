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

public class GMemoryInputStreamHandle : GInputStreamHandle
{
	public static GMemoryInputStreamHandle New()
	{
		return GMemoryInputStreamExterns.g_memory_input_stream_new();
	}
	public static GMemoryInputStreamHandle NewFromBytes(GBytesHandle bytes)
	{
		return GMemoryInputStreamExterns.g_memory_input_stream_new_from_bytes(bytes);
	}
	public static GMemoryInputStreamHandle NewFromData(IntPtr data, int len, GDestroyNotify destroy)
	{
		return GMemoryInputStreamExterns.g_memory_input_stream_new_from_data(data, len, destroy);
	}
}

public static class GMemoryInputStreamSignals
{
}

public static class GMemoryInputStreamHandleExtensions
{
	public static GMemoryInputStreamHandle AddBytes(this GMemoryInputStreamHandle stream, GBytesHandle bytes)
	{
		GMemoryInputStreamExterns.g_memory_input_stream_add_bytes(stream, bytes);
		return stream;
	}

	public static GMemoryInputStreamHandle AddData(this GMemoryInputStreamHandle stream, IntPtr data, int len, GDestroyNotify destroy)
	{
		GMemoryInputStreamExterns.g_memory_input_stream_add_data(stream, data, len, destroy);
		return stream;
	}

}

internal class GMemoryInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_memory_input_stream_add_bytes(GMemoryInputStreamHandle stream, GBytesHandle bytes);
	[DllImport(Libraries.Gio)]
	internal static extern void g_memory_input_stream_add_data(GMemoryInputStreamHandle stream, IntPtr data, int len, GDestroyNotify destroy);
	[DllImport(Libraries.Gio)]
	internal static extern GMemoryInputStreamHandle g_memory_input_stream_new();
	[DllImport(Libraries.Gio)]
	internal static extern GMemoryInputStreamHandle g_memory_input_stream_new_from_bytes(GBytesHandle bytes);
	[DllImport(Libraries.Gio)]
	internal static extern GMemoryInputStreamHandle g_memory_input_stream_new_from_data(IntPtr data, int len, GDestroyNotify destroy);
}
