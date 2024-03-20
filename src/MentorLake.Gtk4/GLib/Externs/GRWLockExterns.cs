using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GRWLockExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_init")]
	internal static extern void g_rw_lock_init(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_clear")]
	internal static extern void g_rw_lock_clear(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_writer_lock")]
	internal static extern void g_rw_lock_writer_lock(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_writer_trylock")]
	internal static extern int g_rw_lock_writer_trylock(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_writer_unlock")]
	internal static extern void g_rw_lock_writer_unlock(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_reader_lock")]
	internal static extern void g_rw_lock_reader_lock(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_reader_trylock")]
	internal static extern int g_rw_lock_reader_trylock(this GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib, EntryPoint = "g_rw_lock_reader_unlock")]
	internal static extern void g_rw_lock_reader_unlock(this GRWLockHandle rw_lock);
}
