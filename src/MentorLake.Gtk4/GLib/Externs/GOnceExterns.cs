using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GOnceExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_once_impl")]
	internal static extern IntPtr g_once_impl(this GOnceHandle once, GThreadFunc func, IntPtr arg);
}
