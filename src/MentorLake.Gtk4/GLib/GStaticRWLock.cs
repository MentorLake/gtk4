namespace MentorLake.Gtk4.GLib;

public class GStaticRWLockHandle : BaseSafeHandle
{
}


public static class GStaticRWLockHandleExtensions
{
	public static GStaticRWLockHandle GStaticRwLockFree(this GStaticRWLockHandle @lock)
	{
		GStaticRWLockExterns.g_static_rw_lock_free(@lock);
		return @lock;
	}

	public static GStaticRWLockHandle GStaticRwLockInit(this GStaticRWLockHandle @lock)
	{
		GStaticRWLockExterns.g_static_rw_lock_init(@lock);
		return @lock;
	}

	public static GStaticRWLockHandle GStaticRwLockReaderLock(this GStaticRWLockHandle @lock)
	{
		GStaticRWLockExterns.g_static_rw_lock_reader_lock(@lock);
		return @lock;
	}

	public static bool GStaticRwLockReaderTrylock(this GStaticRWLockHandle @lock)
	{
		return GStaticRWLockExterns.g_static_rw_lock_reader_trylock(@lock);
	}

	public static GStaticRWLockHandle GStaticRwLockReaderUnlock(this GStaticRWLockHandle @lock)
	{
		GStaticRWLockExterns.g_static_rw_lock_reader_unlock(@lock);
		return @lock;
	}

	public static GStaticRWLockHandle GStaticRwLockWriterLock(this GStaticRWLockHandle @lock)
	{
		GStaticRWLockExterns.g_static_rw_lock_writer_lock(@lock);
		return @lock;
	}

	public static bool GStaticRwLockWriterTrylock(this GStaticRWLockHandle @lock)
	{
		return GStaticRWLockExterns.g_static_rw_lock_writer_trylock(@lock);
	}

	public static GStaticRWLockHandle GStaticRwLockWriterUnlock(this GStaticRWLockHandle @lock)
	{
		GStaticRWLockExterns.g_static_rw_lock_writer_unlock(@lock);
		return @lock;
	}

}
internal class GStaticRWLockExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_free(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_init(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_reader_lock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_static_rw_lock_reader_trylock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_reader_unlock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_writer_lock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_static_rw_lock_writer_trylock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_writer_unlock(GStaticRWLockHandle @lock);

}

public struct GStaticRWLock
{
}
