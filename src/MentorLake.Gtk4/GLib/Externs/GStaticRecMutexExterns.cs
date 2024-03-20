using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GStaticRecMutexExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_init")]
	[Obsolete]
		internal static extern void g_static_rec_mutex_init(this GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_lock")]
	[Obsolete]
		internal static extern void g_static_rec_mutex_lock(this GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_trylock")]
	[Obsolete]
		internal static extern int g_static_rec_mutex_trylock(this GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_unlock")]
	[Obsolete]
		internal static extern void g_static_rec_mutex_unlock(this GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_lock_full")]
	[Obsolete]
		internal static extern void g_static_rec_mutex_lock_full(this GStaticRecMutexHandle mutex, uint depth);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_unlock_full")]
	[Obsolete]
		internal static extern uint g_static_rec_mutex_unlock_full(this GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rec_mutex_free")]
	[Obsolete]
		internal static extern void g_static_rec_mutex_free(this GStaticRecMutexHandle mutex);
}
