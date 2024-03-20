using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GQueueExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_free")]
    internal static extern void g_queue_free(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_free_full")]
    internal static extern void g_queue_free_full(this GQueueHandle queue, GDestroyNotify free_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_init")]
    internal static extern void g_queue_init(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_clear")]
    internal static extern void g_queue_clear(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_is_empty")]
    internal static extern int g_queue_is_empty(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_clear_full")]
    internal static extern void g_queue_clear_full(this GQueueHandle queue, GDestroyNotify free_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_get_length")]
    internal static extern uint g_queue_get_length(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_reverse")]
    internal static extern void g_queue_reverse(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_copy")]
    internal static extern GQueueHandle g_queue_copy(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_foreach")]
    internal static extern void g_queue_foreach(this GQueueHandle queue, IntPtr func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_find")]
    internal static extern GListHandle g_queue_find(this GQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_find_custom")]
    internal static extern GListHandle g_queue_find_custom(this GQueueHandle queue, IntPtr data, GCompareFunc func);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_sort")]
    internal static extern void g_queue_sort(this GQueueHandle queue, GCompareDataFunc compare_func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_push_head")]
    internal static extern void g_queue_push_head(this GQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_push_tail")]
    internal static extern void g_queue_push_tail(this GQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_push_nth")]
    internal static extern void g_queue_push_nth(this GQueueHandle queue, IntPtr data, int n);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_pop_head")]
    internal static extern IntPtr g_queue_pop_head(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_pop_tail")]
    internal static extern IntPtr g_queue_pop_tail(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_pop_nth")]
    internal static extern IntPtr g_queue_pop_nth(this GQueueHandle queue, uint n);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_peek_head")]
    internal static extern IntPtr g_queue_peek_head(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_peek_tail")]
    internal static extern IntPtr g_queue_peek_tail(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_peek_nth")]
    internal static extern IntPtr g_queue_peek_nth(this GQueueHandle queue, uint n);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_index")]
    internal static extern int g_queue_index(this GQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_remove")]
    internal static extern int g_queue_remove(this GQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_remove_all")]
    internal static extern uint g_queue_remove_all(this GQueueHandle queue, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_insert_before")]
    internal static extern void g_queue_insert_before(this GQueueHandle queue, GListHandle sibling, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_insert_before_link")]
    internal static extern void g_queue_insert_before_link(this GQueueHandle queue, GListHandle sibling, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_insert_after")]
    internal static extern void g_queue_insert_after(this GQueueHandle queue, GListHandle sibling, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_insert_after_link")]
    internal static extern void g_queue_insert_after_link(this GQueueHandle queue, GListHandle sibling, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_insert_sorted")]
    internal static extern void g_queue_insert_sorted(this GQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_push_head_link")]
    internal static extern void g_queue_push_head_link(this GQueueHandle queue, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_push_tail_link")]
    internal static extern void g_queue_push_tail_link(this GQueueHandle queue, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_push_nth_link")]
    internal static extern void g_queue_push_nth_link(this GQueueHandle queue, int n, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_pop_head_link")]
    internal static extern GListHandle g_queue_pop_head_link(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_pop_tail_link")]
    internal static extern GListHandle g_queue_pop_tail_link(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_pop_nth_link")]
    internal static extern GListHandle g_queue_pop_nth_link(this GQueueHandle queue, uint n);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_peek_head_link")]
    internal static extern GListHandle g_queue_peek_head_link(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_peek_tail_link")]
    internal static extern GListHandle g_queue_peek_tail_link(this GQueueHandle queue);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_peek_nth_link")]
    internal static extern GListHandle g_queue_peek_nth_link(this GQueueHandle queue, uint n);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_link_index")]
    internal static extern int g_queue_link_index(this GQueueHandle queue, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_unlink")]
    internal static extern void g_queue_unlink(this GQueueHandle queue, GListHandle link_);
    [DllImport(Libraries.GLib, EntryPoint = "g_queue_delete_link")]
    internal static extern void g_queue_delete_link(this GQueueHandle queue, GListHandle link_);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GQueueHandle g_queue_new();
}
