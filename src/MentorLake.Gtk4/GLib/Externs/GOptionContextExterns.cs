using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GOptionContextExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_summary")]
    internal static extern void g_option_context_set_summary(this GOptionContextHandle context, string summary);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_summary")]
    internal static extern string g_option_context_get_summary(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_description")]
    internal static extern void g_option_context_set_description(this GOptionContextHandle context, string description);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_description")]
    internal static extern string g_option_context_get_description(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_free")]
    internal static extern void g_option_context_free(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_help_enabled")]
    internal static extern void g_option_context_set_help_enabled(this GOptionContextHandle context, int help_enabled);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_help_enabled")]
    internal static extern int g_option_context_get_help_enabled(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_ignore_unknown_options")]
    internal static extern void g_option_context_set_ignore_unknown_options(this GOptionContextHandle context, int ignore_unknown);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_ignore_unknown_options")]
    internal static extern int g_option_context_get_ignore_unknown_options(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_strict_posix")]
    internal static extern void g_option_context_set_strict_posix(this GOptionContextHandle context, int strict_posix);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_strict_posix")]
    internal static extern int g_option_context_get_strict_posix(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_add_main_entries")]
    internal static extern void g_option_context_add_main_entries(this GOptionContextHandle context, GOptionEntryHandle entries, string translation_domain);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_parse")]
    internal static extern int g_option_context_parse(this GOptionContextHandle context, ref int argc, ref string[] argv, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_parse_strv")]
    internal static extern int g_option_context_parse_strv(this GOptionContextHandle context, ref string[] arguments, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_translate_func")]
    internal static extern void g_option_context_set_translate_func(this GOptionContextHandle context, GTranslateFunc func, IntPtr data, GDestroyNotify destroy_notify);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_translation_domain")]
    internal static extern void g_option_context_set_translation_domain(this GOptionContextHandle context, string domain);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_add_group")]
    internal static extern void g_option_context_add_group(this GOptionContextHandle context, GOptionGroupHandle group);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_set_main_group")]
    internal static extern void g_option_context_set_main_group(this GOptionContextHandle context, GOptionGroupHandle group);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_main_group")]
    internal static extern GOptionGroupHandle g_option_context_get_main_group(this GOptionContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_context_get_help")]
    internal static extern string g_option_context_get_help(this GOptionContextHandle context, int main_help, GOptionGroupHandle group);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GOptionContextHandle g_option_context_new(string parameter_string);
}
