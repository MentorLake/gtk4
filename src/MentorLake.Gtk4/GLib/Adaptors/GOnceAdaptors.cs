using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GOnceAdaptors
{
    public static IntPtr Impl(this GOnceHandle once, GThreadFunc func, IntPtr arg)
    {
        return GOnceExterns.g_once_impl(once, func, arg);
    }
}
