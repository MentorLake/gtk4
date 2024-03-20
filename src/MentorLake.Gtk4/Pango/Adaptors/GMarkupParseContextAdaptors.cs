using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class GMarkupParseContextAdaptors
{
	public static int PangoMarkupParserFinish(this GMarkupParseContextHandle context, out PangoAttrListHandle attr_list, string[] text, out uint accel_char, out GErrorHandle error)
	{
		return GMarkupParseContextExterns.pango_markup_parser_finish(context, out attr_list, text, out accel_char, out error);
	}

	public static GMarkupParseContextHandle PangoMarkupParserNew(uint accel_marker)
	{
		return GMarkupParseContextExterns.pango_markup_parser_new(accel_marker);
	}
}
