using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GCompletionExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_add_items")]
    [Obsolete]
    internal static extern void g_completion_add_items(this GCompletionHandle cmp, GListHandle items);
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_remove_items")]
    [Obsolete]
    internal static extern void g_completion_remove_items(this GCompletionHandle cmp, GListHandle items);
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_clear_items")]
    [Obsolete]
    internal static extern void g_completion_clear_items(this GCompletionHandle cmp);
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_complete")]
    internal static extern GListHandle g_completion_complete(this GCompletionHandle cmp, string prefix, string[] new_prefix);
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_complete_utf8")]
    internal static extern GListHandle g_completion_complete_utf8(this GCompletionHandle cmp, string prefix, string[] new_prefix);
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_set_compare")]
    [Obsolete]
    internal static extern void g_completion_set_compare(this GCompletionHandle cmp, GCompletionStrncmpFunc strncmp_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_completion_free")]
    [Obsolete]
    internal static extern void g_completion_free(this GCompletionHandle cmp);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GCompletionHandle g_completion_new(GCompletionFunc func);
}
