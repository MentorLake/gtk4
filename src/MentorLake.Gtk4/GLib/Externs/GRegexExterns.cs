using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRegexExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_ref")]
    internal static extern GRegexHandle g_regex_ref(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_unref")]
    internal static extern void g_regex_unref(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_pattern")]
    internal static extern string g_regex_get_pattern(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_max_backref")]
    internal static extern int g_regex_get_max_backref(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_capture_count")]
    internal static extern int g_regex_get_capture_count(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_has_cr_or_lf")]
    internal static extern int g_regex_get_has_cr_or_lf(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_max_lookbehind")]
    internal static extern int g_regex_get_max_lookbehind(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_string_number")]
    internal static extern int g_regex_get_string_number(this GRegexHandle regex, string name);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_compile_flags")]
    internal static extern GRegexCompileFlags g_regex_get_compile_flags(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_get_match_flags")]
    internal static extern GRegexMatchFlags g_regex_get_match_flags(this GRegexHandle regex);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_match")]
    internal static extern int g_regex_match(this GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_match_full")]
    internal static extern int g_regex_match_full(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_match_all")]
    internal static extern int g_regex_match_all(this GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_match_all_full")]
    internal static extern int g_regex_match_all_full(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_split")]
    internal static extern string[] g_regex_split(this GRegexHandle regex, string @string, GRegexMatchFlags match_options);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_split_full")]
    internal static extern string[] g_regex_split_full(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, int max_tokens, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_replace")]
    internal static extern string g_regex_replace(this GRegexHandle regex, string @string, nint string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_replace_literal")]
    internal static extern string g_regex_replace_literal(this GRegexHandle regex, string @string, nint string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_regex_replace_eval")]
    internal static extern string g_regex_replace_eval(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, GRegexEvalCallback eval, IntPtr user_data, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GRegexHandle g_regex_new(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error);
}
