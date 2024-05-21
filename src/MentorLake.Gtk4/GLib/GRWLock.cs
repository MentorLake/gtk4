namespace MentorLake.Gtk4.GLib;

public class GRWLockHandle : BaseSafeHandle
{
}


public static class GRWLockHandleExtensions
{
	public static GRWLockHandle GRwLockClear(this GRWLockHandle rw_lock)
	{
		GRWLockExterns.g_rw_lock_clear(rw_lock);
		return rw_lock;
	}

	public static GRWLockHandle GRwLockInit(this GRWLockHandle rw_lock)
	{
		GRWLockExterns.g_rw_lock_init(rw_lock);
		return rw_lock;
	}

	public static GRWLockHandle GRwLockReaderLock(this GRWLockHandle rw_lock)
	{
		GRWLockExterns.g_rw_lock_reader_lock(rw_lock);
		return rw_lock;
	}

	public static bool GRwLockReaderTrylock(this GRWLockHandle rw_lock)
	{
		return GRWLockExterns.g_rw_lock_reader_trylock(rw_lock);
	}

	public static GRWLockHandle GRwLockReaderUnlock(this GRWLockHandle rw_lock)
	{
		GRWLockExterns.g_rw_lock_reader_unlock(rw_lock);
		return rw_lock;
	}

	public static GRWLockHandle GRwLockWriterLock(this GRWLockHandle rw_lock)
	{
		GRWLockExterns.g_rw_lock_writer_lock(rw_lock);
		return rw_lock;
	}

	public static bool GRwLockWriterTrylock(this GRWLockHandle rw_lock)
	{
		return GRWLockExterns.g_rw_lock_writer_trylock(rw_lock);
	}

	public static GRWLockHandle GRwLockWriterUnlock(this GRWLockHandle rw_lock)
	{
		GRWLockExterns.g_rw_lock_writer_unlock(rw_lock);
		return rw_lock;
	}

}
internal class GRWLockExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_rw_lock_clear(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rw_lock_init(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rw_lock_reader_lock(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_rw_lock_reader_trylock(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rw_lock_reader_unlock(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rw_lock_writer_lock(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_rw_lock_writer_trylock(GRWLockHandle rw_lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rw_lock_writer_unlock(GRWLockHandle rw_lock);

}

public struct GRWLock
{
}
