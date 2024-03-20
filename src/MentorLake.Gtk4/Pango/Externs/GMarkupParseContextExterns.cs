using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class GMarkupParseContextExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_markup_parser_finish")]
    internal static extern int pango_markup_parser_finish(this GMarkupParseContextHandle context, out PangoAttrListHandle attr_list, string[] text, out uint accel_char, out GErrorHandle error);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMarkupParseContextHandle pango_markup_parser_new(uint accel_marker);
}
