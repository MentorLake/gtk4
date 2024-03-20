using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMarkupParseContextExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_ref")]
    internal static extern GMarkupParseContextHandle g_markup_parse_context_ref(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_unref")]
    internal static extern void g_markup_parse_context_unref(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_free")]
    internal static extern void g_markup_parse_context_free(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_parse")]
    internal static extern int g_markup_parse_context_parse(this GMarkupParseContextHandle context, string text, nint text_len, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_push")]
    internal static extern void g_markup_parse_context_push(this GMarkupParseContextHandle context, GMarkupParserHandle parser, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_pop")]
    internal static extern IntPtr g_markup_parse_context_pop(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_end_parse")]
    internal static extern int g_markup_parse_context_end_parse(this GMarkupParseContextHandle context, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_get_element")]
    internal static extern string g_markup_parse_context_get_element(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_get_element_stack")]
    internal static extern GSListHandle g_markup_parse_context_get_element_stack(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_get_position")]
    internal static extern void g_markup_parse_context_get_position(this GMarkupParseContextHandle context, out int line_number, out int char_number);
    [DllImport(Libraries.GLib, EntryPoint = "g_markup_parse_context_get_user_data")]
    internal static extern IntPtr g_markup_parse_context_get_user_data(this GMarkupParseContextHandle context);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMarkupParseContextHandle g_markup_parse_context_new(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify);
}
