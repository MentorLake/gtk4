using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GSourceExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_dispose_function")]
    internal static extern void g_source_set_dispose_function(this GSourceHandle source, GSourceDisposeFunc dispose);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_ref")]
    internal static extern GSourceHandle g_source_ref(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_unref")]
    internal static extern void g_source_unref(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_attach")]
    internal static extern uint g_source_attach(this GSourceHandle source, GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_destroy")]
    internal static extern void g_source_destroy(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_priority")]
    internal static extern void g_source_set_priority(this GSourceHandle source, int priority);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_priority")]
    internal static extern int g_source_get_priority(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_can_recurse")]
    internal static extern void g_source_set_can_recurse(this GSourceHandle source, int can_recurse);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_can_recurse")]
    internal static extern int g_source_get_can_recurse(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_id")]
    internal static extern uint g_source_get_id(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_context")]
    internal static extern GMainContextHandle g_source_get_context(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_callback")]
    internal static extern void g_source_set_callback(this GSourceHandle source, GSourceFunc func, IntPtr data, GDestroyNotify notify);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_funcs")]
    internal static extern void g_source_set_funcs(this GSourceHandle source, GSourceFuncsHandle funcs);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_is_destroyed")]
    internal static extern int g_source_is_destroyed(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_name")]
    internal static extern void g_source_set_name(this GSourceHandle source, string name);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_static_name")]
    internal static extern void g_source_set_static_name(this GSourceHandle source, string name);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_name")]
    internal static extern string g_source_get_name(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_ready_time")]
    internal static extern void g_source_set_ready_time(this GSourceHandle source, nint ready_time);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_ready_time")]
    internal static extern nint g_source_get_ready_time(this GSourceHandle source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_add_unix_fd")]
    internal static extern IntPtr g_source_add_unix_fd(this GSourceHandle source, int fd, GIOCondition events);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_modify_unix_fd")]
    internal static extern void g_source_modify_unix_fd(this GSourceHandle source, IntPtr tag, GIOCondition new_events);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_remove_unix_fd")]
    internal static extern void g_source_remove_unix_fd(this GSourceHandle source, IntPtr tag);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_query_unix_fd")]
    internal static extern GIOCondition g_source_query_unix_fd(this GSourceHandle source, IntPtr tag);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_set_callback_indirect")]
    internal static extern void g_source_set_callback_indirect(this GSourceHandle source, IntPtr callback_data, GSourceCallbackFuncsHandle callback_funcs);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_add_poll")]
    internal static extern void g_source_add_poll(this GSourceHandle source, GPollFDHandle fd);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_remove_poll")]
    internal static extern void g_source_remove_poll(this GSourceHandle source, GPollFDHandle fd);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_add_child_source")]
    internal static extern void g_source_add_child_source(this GSourceHandle source, GSourceHandle child_source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_remove_child_source")]
    internal static extern void g_source_remove_child_source(this GSourceHandle source, GSourceHandle child_source);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_current_time")]
    [Obsolete]
    internal static extern void g_source_get_current_time(this GSourceHandle source, GTimeValHandle timeval);
    [DllImport(Libraries.GLib, EntryPoint = "g_source_get_time")]
    internal static extern nint g_source_get_time(this GSourceHandle source);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSourceHandle g_source_new(GSourceFuncsHandle source_funcs, uint struct_size);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSourceHandle g_idle_source_new();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSourceHandle g_child_watch_source_new(GPid pid);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSourceHandle g_timeout_source_new(uint interval);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSourceHandle g_timeout_source_new_seconds(uint interval);
}
