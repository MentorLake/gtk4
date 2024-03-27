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

public class GConverterHandle  : GObjectHandle
{
}

public static class GConverterHandleExtensions
{
	public static GConverterResult Convert(this GConverterHandle converter, IntPtr inbuf, int inbuf_size, IntPtr outbuf, int outbuf_size, GConverterFlags flags, out int bytes_read, out int bytes_written, out GErrorHandle error)
	{
		return GConverterExterns.g_converter_convert(converter, inbuf, inbuf_size, outbuf, outbuf_size, flags, out bytes_read, out bytes_written, out error);
	}

	public static GConverterHandle Reset(this GConverterHandle converter)
	{
		GConverterExterns.g_converter_reset(converter);
		return converter;
	}

}

internal class GConverterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GConverterResult g_converter_convert(GConverterHandle converter, IntPtr inbuf, int inbuf_size, IntPtr outbuf, int outbuf_size, GConverterFlags flags, out int bytes_read, out int bytes_written, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_converter_reset(GConverterHandle converter);
}
