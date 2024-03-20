using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GAsyncQueueExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_lock")]
    internal static extern void g_async_queue_lock(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_unlock")]
    internal static extern void g_async_queue_unlock(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_ref")]
    internal static extern GAsyncQueueHandle g_async_queue_ref(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_unref")]
    internal static extern void g_async_queue_unref(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_ref_unlocked")]
    [Obsolete]
    internal static extern void g_async_queue_ref_unlocked(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_unref_and_unlock")]
    [Obsolete]
    internal static extern void g_async_queue_unref_and_unlock(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_push")]
    internal static extern void g_async_queue_push(this GAsyncQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_push_unlocked")]
    internal static extern void g_async_queue_push_unlocked(this GAsyncQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_push_sorted")]
    internal static extern void g_async_queue_push_sorted(this GAsyncQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_push_sorted_unlocked")]
    internal static extern void g_async_queue_push_sorted_unlocked(this GAsyncQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_pop")]
    internal static extern IntPtr g_async_queue_pop(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_pop_unlocked")]
    internal static extern IntPtr g_async_queue_pop_unlocked(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_try_pop")]
    internal static extern IntPtr g_async_queue_try_pop(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_try_pop_unlocked")]
    internal static extern IntPtr g_async_queue_try_pop_unlocked(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_timeout_pop")]
    internal static extern IntPtr g_async_queue_timeout_pop(this GAsyncQueueHandle queue, nuint timeout);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_timeout_pop_unlocked")]
    internal static extern IntPtr g_async_queue_timeout_pop_unlocked(this GAsyncQueueHandle queue, nuint timeout);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_length")]
    internal static extern int g_async_queue_length(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_length_unlocked")]
    internal static extern int g_async_queue_length_unlocked(this GAsyncQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_sort")]
    internal static extern void g_async_queue_sort(this GAsyncQueueHandle queue, GCompareDataFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_sort_unlocked")]
    internal static extern void g_async_queue_sort_unlocked(this GAsyncQueueHandle queue, GCompareDataFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_remove")]
    internal static extern int g_async_queue_remove(this GAsyncQueueHandle queue, IntPtr item);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_remove_unlocked")]
    internal static extern int g_async_queue_remove_unlocked(this GAsyncQueueHandle queue, IntPtr item);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_push_front")]
    internal static extern void g_async_queue_push_front(this GAsyncQueueHandle queue, IntPtr item);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_push_front_unlocked")]
    internal static extern void g_async_queue_push_front_unlocked(this GAsyncQueueHandle queue, IntPtr item);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_timed_pop")]
    internal static extern IntPtr g_async_queue_timed_pop(this GAsyncQueueHandle queue, GTimeValHandle end_time);
    [DllImport(Libraries.GLib, EntryPoint = "g_async_queue_timed_pop_unlocked")]
    internal static extern IntPtr g_async_queue_timed_pop_unlocked(this GAsyncQueueHandle queue, GTimeValHandle end_time);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GAsyncQueueHandle g_async_queue_new();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GAsyncQueueHandle g_async_queue_new_full(GDestroyNotify item_free_func);
}
