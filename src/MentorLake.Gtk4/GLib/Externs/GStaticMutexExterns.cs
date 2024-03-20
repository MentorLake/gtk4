using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GStaticMutexExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_static_mutex_init")]
	[Obsolete]
		internal static extern void g_static_mutex_init(this GStaticMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_mutex_free")]
	[Obsolete]
		internal static extern void g_static_mutex_free(this GStaticMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_mutex_get_mutex_impl")]
	internal static extern GMutexHandle g_static_mutex_get_mutex_impl(this GStaticMutexHandle mutex);
}
