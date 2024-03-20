using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GScannerExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_destroy")]
    internal static extern void g_scanner_destroy(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_input_file")]
    internal static extern void g_scanner_input_file(this GScannerHandle scanner, int input_fd);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_sync_file_offset")]
    internal static extern void g_scanner_sync_file_offset(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_input_text")]
    internal static extern void g_scanner_input_text(this GScannerHandle scanner, string text, uint text_len);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_get_next_token")]
    internal static extern GTokenType g_scanner_get_next_token(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_peek_next_token")]
    internal static extern GTokenType g_scanner_peek_next_token(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_cur_token")]
    internal static extern GTokenType g_scanner_cur_token(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_cur_value")]
    internal static extern GTokenValue g_scanner_cur_value(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_cur_line")]
    internal static extern uint g_scanner_cur_line(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_cur_position")]
    internal static extern uint g_scanner_cur_position(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_eof")]
    internal static extern int g_scanner_eof(this GScannerHandle scanner);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_set_scope")]
    internal static extern uint g_scanner_set_scope(this GScannerHandle scanner, uint scope_id);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_scope_add_symbol")]
    internal static extern void g_scanner_scope_add_symbol(this GScannerHandle scanner, uint scope_id, string symbol, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_scope_remove_symbol")]
    internal static extern void g_scanner_scope_remove_symbol(this GScannerHandle scanner, uint scope_id, string symbol);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_scope_lookup_symbol")]
    internal static extern IntPtr g_scanner_scope_lookup_symbol(this GScannerHandle scanner, uint scope_id, string symbol);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_scope_foreach_symbol")]
    internal static extern void g_scanner_scope_foreach_symbol(this GScannerHandle scanner, uint scope_id, GHFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_lookup_symbol")]
    internal static extern IntPtr g_scanner_lookup_symbol(this GScannerHandle scanner, string symbol);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_unexp_token")]
    internal static extern void g_scanner_unexp_token(this GScannerHandle scanner, GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_error")]
    internal static extern void g_scanner_error(this GScannerHandle scanner, string format, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_scanner_warn")]
    internal static extern void g_scanner_warn(this GScannerHandle scanner, string format, IntPtr @__argList);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GScannerHandle g_scanner_new(GScannerConfigHandle config_templ);
}
