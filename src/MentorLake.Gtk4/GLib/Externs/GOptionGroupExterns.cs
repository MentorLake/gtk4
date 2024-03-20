using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GOptionGroupExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_set_parse_hooks")]
    internal static extern void g_option_group_set_parse_hooks(this GOptionGroupHandle group, GOptionParseFunc pre_parse_func, GOptionParseFunc post_parse_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_set_error_hook")]
    internal static extern void g_option_group_set_error_hook(this GOptionGroupHandle group, GOptionErrorFunc error_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_free")]
    [Obsolete]
    internal static extern void g_option_group_free(this GOptionGroupHandle group);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_ref")]
    internal static extern GOptionGroupHandle g_option_group_ref(this GOptionGroupHandle group);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_unref")]
    internal static extern void g_option_group_unref(this GOptionGroupHandle group);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_add_entries")]
    internal static extern void g_option_group_add_entries(this GOptionGroupHandle group, GOptionEntryHandle entries);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_set_translate_func")]
    internal static extern void g_option_group_set_translate_func(this GOptionGroupHandle group, GTranslateFunc func, IntPtr data, GDestroyNotify destroy_notify);
    [DllImport(Libraries.GLib, EntryPoint = "g_option_group_set_translation_domain")]
    internal static extern void g_option_group_set_translation_domain(this GOptionGroupHandle group, string domain);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GOptionGroupHandle g_option_group_new(string name, string description, string help_description, IntPtr user_data, GDestroyNotify destroy);
}
