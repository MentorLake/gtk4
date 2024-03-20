using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GStaticRWLockExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_init")]
	[Obsolete]
		internal static extern void g_static_rw_lock_init(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_reader_lock")]
	[Obsolete]
		internal static extern void g_static_rw_lock_reader_lock(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_reader_trylock")]
	[Obsolete]
		internal static extern int g_static_rw_lock_reader_trylock(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_reader_unlock")]
	[Obsolete]
		internal static extern void g_static_rw_lock_reader_unlock(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_writer_lock")]
	[Obsolete]
		internal static extern void g_static_rw_lock_writer_lock(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_writer_trylock")]
	[Obsolete]
		internal static extern int g_static_rw_lock_writer_trylock(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_writer_unlock")]
	[Obsolete]
		internal static extern void g_static_rw_lock_writer_unlock(this GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_rw_lock_free")]
	[Obsolete]
		internal static extern void g_static_rw_lock_free(this GStaticRWLockHandle @lock);
}
