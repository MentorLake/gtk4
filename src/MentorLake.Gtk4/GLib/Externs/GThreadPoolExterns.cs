using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GThreadPoolExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_free")]
    internal static extern void g_thread_pool_free(this GThreadPoolHandle pool, int immediate, int wait_);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_push")]
    internal static extern int g_thread_pool_push(this GThreadPoolHandle pool, IntPtr data, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_unprocessed")]
    internal static extern uint g_thread_pool_unprocessed(this GThreadPoolHandle pool);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_set_sort_function")]
    internal static extern void g_thread_pool_set_sort_function(this GThreadPoolHandle pool, GCompareDataFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_move_to_front")]
    internal static extern int g_thread_pool_move_to_front(this GThreadPoolHandle pool, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_set_max_threads")]
    internal static extern int g_thread_pool_set_max_threads(this GThreadPoolHandle pool, int max_threads, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_get_max_threads")]
    internal static extern int g_thread_pool_get_max_threads(this GThreadPoolHandle pool);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_pool_get_num_threads")]
    internal static extern uint g_thread_pool_get_num_threads(this GThreadPoolHandle pool);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GThreadPoolHandle g_thread_pool_new(IntPtr func, IntPtr user_data, int max_threads, int exclusive, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GThreadPoolHandle g_thread_pool_new_full(IntPtr func, IntPtr user_data, GDestroyNotify item_free_func, int max_threads, int exclusive, out GErrorHandle error);
}
