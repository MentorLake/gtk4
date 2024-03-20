using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GAllocatorExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_allocator_free")]
    [Obsolete]
    internal static extern void g_allocator_free(this GAllocatorHandle allocator);
    [DllImport(Libraries.GLib, EntryPoint = "g_list_push_allocator")]
    [Obsolete]
    internal static extern void g_list_push_allocator(this GAllocatorHandle allocator);
    [DllImport(Libraries.GLib, EntryPoint = "g_slist_push_allocator")]
    [Obsolete]
    internal static extern void g_slist_push_allocator(this GAllocatorHandle allocator);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_push_allocator")]
    [Obsolete]
    internal static extern void g_node_push_allocator(this GAllocatorHandle allocator);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GAllocatorHandle g_allocator_new(string name, uint n_preallocs);
}
