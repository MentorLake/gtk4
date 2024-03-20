using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GCondExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_init")]
    internal static extern void g_cond_init(this GCondHandle cond);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_clear")]
    internal static extern void g_cond_clear(this GCondHandle cond);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_wait")]
    internal static extern void g_cond_wait(this GCondHandle cond, GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_signal")]
    internal static extern void g_cond_signal(this GCondHandle cond);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_broadcast")]
    internal static extern void g_cond_broadcast(this GCondHandle cond);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_wait_until")]
    internal static extern int g_cond_wait_until(this GCondHandle cond, GMutexHandle mutex, nint end_time);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_free")]
    [Obsolete]
    internal static extern void g_cond_free(this GCondHandle cond);
    [DllImport(Libraries.GLib, EntryPoint = "g_cond_timed_wait")]
    [Obsolete]
    internal static extern int g_cond_timed_wait(this GCondHandle cond, GMutexHandle mutex, GTimeValHandle timeval);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GCondHandle g_cond_new();
}
