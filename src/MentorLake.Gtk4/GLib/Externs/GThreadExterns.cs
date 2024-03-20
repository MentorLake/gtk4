using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GThreadExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_ref")]
    internal static extern GThreadHandle g_thread_ref(this GThreadHandle thread);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_unref")]
    internal static extern void g_thread_unref(this GThreadHandle thread);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_join")]
    internal static extern IntPtr g_thread_join(this GThreadHandle thread);
    [DllImport(Libraries.GLib, EntryPoint = "g_thread_set_priority")]
    [Obsolete]
    internal static extern void g_thread_set_priority(this GThreadHandle thread, GThreadPriority priority);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GThreadHandle g_thread_new(string name, GThreadFunc func, IntPtr data);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GThreadHandle g_thread_try_new(string name, GThreadFunc func, IntPtr data, out GErrorHandle error);
}
