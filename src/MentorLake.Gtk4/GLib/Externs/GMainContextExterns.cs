using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMainContextExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_ref")]
    internal static extern GMainContextHandle g_main_context_ref(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_unref")]
    internal static extern void g_main_context_unref(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_iteration")]
    internal static extern int g_main_context_iteration(this GMainContextHandle context, int may_block);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_pending")]
    internal static extern int g_main_context_pending(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_find_source_by_id")]
    internal static extern GSourceHandle g_main_context_find_source_by_id(this GMainContextHandle context, uint source_id);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_find_source_by_user_data")]
    internal static extern GSourceHandle g_main_context_find_source_by_user_data(this GMainContextHandle context, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_find_source_by_funcs_user_data")]
    internal static extern GSourceHandle g_main_context_find_source_by_funcs_user_data(this GMainContextHandle context, GSourceFuncsHandle funcs, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_wakeup")]
    internal static extern void g_main_context_wakeup(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_acquire")]
    internal static extern int g_main_context_acquire(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_release")]
    internal static extern void g_main_context_release(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_is_owner")]
    internal static extern int g_main_context_is_owner(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_wait")]
    [Obsolete]
    internal static extern int g_main_context_wait(this GMainContextHandle context, GCondHandle cond, GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_prepare")]
    internal static extern int g_main_context_prepare(this GMainContextHandle context, out int priority);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_query")]
    internal static extern int g_main_context_query(this GMainContextHandle context, int max_priority, out int timeout_, GPollFD[] fds, int n_fds);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_check")]
    internal static extern int g_main_context_check(this GMainContextHandle context, int max_priority, GPollFDHandle fds, int n_fds);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_dispatch")]
    internal static extern void g_main_context_dispatch(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_set_poll_func")]
    internal static extern void g_main_context_set_poll_func(this GMainContextHandle context, GPollFunc func);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_get_poll_func")]
    internal static extern GPollFunc g_main_context_get_poll_func(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_add_poll")]
    internal static extern void g_main_context_add_poll(this GMainContextHandle context, GPollFDHandle fd, int priority);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_remove_poll")]
    internal static extern void g_main_context_remove_poll(this GMainContextHandle context, GPollFDHandle fd);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_push_thread_default")]
    internal static extern void g_main_context_push_thread_default(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_pop_thread_default")]
    internal static extern void g_main_context_pop_thread_default(this GMainContextHandle context);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_loop_new")]
    internal static extern GMainLoopHandle g_main_loop_new(this GMainContextHandle context, int is_running);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_invoke_full")]
    internal static extern void g_main_context_invoke_full(this GMainContextHandle context, int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify);
    [DllImport(Libraries.GLib, EntryPoint = "g_main_context_invoke")]
    internal static extern void g_main_context_invoke(this GMainContextHandle context, GSourceFunc function, IntPtr data);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMainContextHandle g_main_context_new();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMainContextHandle g_main_context_new_with_flags(GMainContextFlags flags);
}
