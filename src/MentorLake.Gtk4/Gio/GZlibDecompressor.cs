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

public class GZlibDecompressorHandle : GObjectHandle
{
	public static GZlibDecompressorHandle New(GZlibCompressorFormat format)
	{
		return GZlibDecompressorExterns.g_zlib_decompressor_new(format);
	}
}

public static class GZlibDecompressorSignals
{
}

public static class GZlibDecompressorHandleExtensions
{
	public static GFileInfoHandle GetFileInfo(this GZlibDecompressorHandle decompressor)
	{
		return GZlibDecompressorExterns.g_zlib_decompressor_get_file_info(decompressor);
	}

}

internal class GZlibDecompressorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_zlib_decompressor_get_file_info(GZlibDecompressorHandle decompressor);
	[DllImport(Libraries.Gio)]
	internal static extern GZlibDecompressorHandle g_zlib_decompressor_new(GZlibCompressorFormat format);
}
