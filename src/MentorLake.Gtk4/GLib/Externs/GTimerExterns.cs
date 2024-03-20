using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTimerExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_destroy")]
    internal static extern void g_timer_destroy(this GTimerHandle timer);
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_start")]
    internal static extern void g_timer_start(this GTimerHandle timer);
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_stop")]
    internal static extern void g_timer_stop(this GTimerHandle timer);
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_reset")]
    internal static extern void g_timer_reset(this GTimerHandle timer);
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_continue")]
    internal static extern void g_timer_continue(this GTimerHandle timer);
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_elapsed")]
    internal static extern double g_timer_elapsed(this GTimerHandle timer, out nuint microseconds);
    [DllImport(Libraries.GLib, EntryPoint = "g_timer_is_active")]
    internal static extern int g_timer_is_active(this GTimerHandle timer);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTimerHandle g_timer_new();
}
