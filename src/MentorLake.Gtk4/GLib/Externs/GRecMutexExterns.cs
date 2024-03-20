using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GRecMutexExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_rec_mutex_init")]
	internal static extern void g_rec_mutex_init(this GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_rec_mutex_clear")]
	internal static extern void g_rec_mutex_clear(this GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_rec_mutex_lock")]
	internal static extern void g_rec_mutex_lock(this GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_rec_mutex_trylock")]
	internal static extern int g_rec_mutex_trylock(this GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_rec_mutex_unlock")]
	internal static extern void g_rec_mutex_unlock(this GRecMutexHandle rec_mutex);
}
