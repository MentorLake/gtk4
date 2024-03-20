using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPrivateExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_private_get")]
    internal static extern IntPtr g_private_get(this GPrivateHandle key);
    [DllImport(Libraries.GLib, EntryPoint = "g_private_set")]
    internal static extern void g_private_set(this GPrivateHandle key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_private_replace")]
    internal static extern void g_private_replace(this GPrivateHandle key, IntPtr value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GPrivateHandle g_private_new(GDestroyNotify notify);
}
