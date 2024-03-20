using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMutexExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_mutex_init")]
    internal static extern void g_mutex_init(this GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_mutex_clear")]
    internal static extern void g_mutex_clear(this GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_mutex_lock")]
    internal static extern void g_mutex_lock(this GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_mutex_trylock")]
    internal static extern int g_mutex_trylock(this GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_mutex_unlock")]
    internal static extern void g_mutex_unlock(this GMutexHandle mutex);
    [DllImport(Libraries.GLib, EntryPoint = "g_mutex_free")]
    [Obsolete]
    internal static extern void g_mutex_free(this GMutexHandle mutex);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMutexHandle g_mutex_new();
}
