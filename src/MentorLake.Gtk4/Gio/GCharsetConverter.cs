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

public class GCharsetConverterHandle : GObjectHandle, GConverterHandle, GInitableHandle
{
	public static GCharsetConverterHandle New(string to_charset, string from_charset, out GErrorHandle error)
	{
		return GCharsetConverterExterns.g_charset_converter_new(to_charset, from_charset, out error);
	}

}

public static class GCharsetConverterHandleExtensions
{
	public static uint GetNumFallbacks(this GCharsetConverterHandle converter)
	{
		return GCharsetConverterExterns.g_charset_converter_get_num_fallbacks(converter);
	}

	public static bool GetUseFallback(this GCharsetConverterHandle converter)
	{
		return GCharsetConverterExterns.g_charset_converter_get_use_fallback(converter);
	}

	public static GCharsetConverterHandle SetUseFallback(this GCharsetConverterHandle converter, bool use_fallback)
	{
		GCharsetConverterExterns.g_charset_converter_set_use_fallback(converter, use_fallback);
		return converter;
	}

}

internal class GCharsetConverterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GCharsetConverterHandle g_charset_converter_new(string to_charset, string from_charset, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_charset_converter_get_num_fallbacks(GCharsetConverterHandle converter);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_charset_converter_get_use_fallback(GCharsetConverterHandle converter);
	[DllImport(Libraries.Gio)]
	internal static extern void g_charset_converter_set_use_fallback(GCharsetConverterHandle converter, bool use_fallback);
}
