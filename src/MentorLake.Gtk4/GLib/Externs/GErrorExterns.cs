using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GErrorExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_error_free")]
    internal static extern void g_error_free(this GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_error_copy")]
    internal static extern GErrorHandle g_error_copy(this GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_error_matches")]
    internal static extern int g_error_matches(this GErrorHandle error, GQuark domain, int code);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_parse_error_print_context")]
    internal static extern string g_variant_parse_error_print_context(this GErrorHandle error, string source_str);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GErrorHandle g_error_new(GQuark domain, int code, string format, IntPtr @__arglist);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GErrorHandle g_error_new_literal(GQuark domain, int code, string message);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GErrorHandle g_error_new_valist(GQuark domain, int code, string format, IntPtr @__arglist);
}
