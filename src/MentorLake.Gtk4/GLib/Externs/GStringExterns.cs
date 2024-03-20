using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStringExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_string_free")]
    internal static extern string g_string_free(this GStringHandle @string, int free_segment);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_free_to_bytes")]
    internal static extern GBytesHandle g_string_free_to_bytes(this GStringHandle @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_equal")]
    internal static extern int g_string_equal(this GStringHandle v, GStringHandle v2);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_hash")]
    internal static extern uint g_string_hash(this GStringHandle str);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_assign")]
    internal static extern GStringHandle g_string_assign(this GStringHandle @string, string rval);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_truncate")]
    internal static extern GStringHandle g_string_truncate(this GStringHandle @string, nuint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_set_size")]
    internal static extern GStringHandle g_string_set_size(this GStringHandle @string, nuint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_insert_len")]
    internal static extern GStringHandle g_string_insert_len(this GStringHandle @string, nint pos, string val, nint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append")]
    internal static extern GStringHandle g_string_append(this GStringHandle @string, string val);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append_len")]
    internal static extern GStringHandle g_string_append_len(this GStringHandle @string, string val, nint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append_c")]
    internal static extern GStringHandle g_string_append_c(this GStringHandle @string, char c);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append_unichar")]
    internal static extern GStringHandle g_string_append_unichar(this GStringHandle @string, uint wc);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_prepend")]
    internal static extern GStringHandle g_string_prepend(this GStringHandle @string, string val);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_prepend_c")]
    internal static extern GStringHandle g_string_prepend_c(this GStringHandle @string, char c);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_prepend_unichar")]
    internal static extern GStringHandle g_string_prepend_unichar(this GStringHandle @string, uint wc);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_prepend_len")]
    internal static extern GStringHandle g_string_prepend_len(this GStringHandle @string, string val, nint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_insert")]
    internal static extern GStringHandle g_string_insert(this GStringHandle @string, nint pos, string val);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_insert_c")]
    internal static extern GStringHandle g_string_insert_c(this GStringHandle @string, nint pos, char c);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_insert_unichar")]
    internal static extern GStringHandle g_string_insert_unichar(this GStringHandle @string, nint pos, uint wc);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_overwrite")]
    internal static extern GStringHandle g_string_overwrite(this GStringHandle @string, nuint pos, string val);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_overwrite_len")]
    internal static extern GStringHandle g_string_overwrite_len(this GStringHandle @string, nuint pos, string val, nint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_erase")]
    internal static extern GStringHandle g_string_erase(this GStringHandle @string, nint pos, nint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_replace")]
    internal static extern uint g_string_replace(this GStringHandle @string, string find, string replace, uint limit);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_ascii_down")]
    internal static extern GStringHandle g_string_ascii_down(this GStringHandle @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_ascii_up")]
    internal static extern GStringHandle g_string_ascii_up(this GStringHandle @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_vprintf")]
    internal static extern void g_string_vprintf(this GStringHandle @string, string format, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_printf")]
    internal static extern void g_string_printf(this GStringHandle @string, string format, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append_vprintf")]
    internal static extern void g_string_append_vprintf(this GStringHandle @string, string format, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append_printf")]
    internal static extern void g_string_append_printf(this GStringHandle @string, string format, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_append_uri_escaped")]
    internal static extern GStringHandle g_string_append_uri_escaped(this GStringHandle @string, string unescaped, string reserved_chars_allowed, int allow_utf8);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_down")]
    internal static extern GStringHandle g_string_down(this GStringHandle @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_up")]
    internal static extern GStringHandle g_string_up(this GStringHandle @string);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GStringHandle g_string_new(string init);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GStringHandle g_string_new_len(string init, nint len);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GStringHandle g_string_sized_new(nuint dfl_size);
}
