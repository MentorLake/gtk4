using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStaticRWLockAdaptors
{
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

    public static int GStaticRwLockReaderTrylock(this GStaticRWLockHandle @lock)
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

    public static int GStaticRwLockWriterTrylock(this GStaticRWLockHandle @lock)
    {
        return GStaticRWLockExterns.g_static_rw_lock_writer_trylock(@lock);
    }

    public static GStaticRWLockHandle GStaticRwLockWriterUnlock(this GStaticRWLockHandle @lock)
    {
        GStaticRWLockExterns.g_static_rw_lock_writer_unlock(@lock);
        return @lock;
    }

    public static GStaticRWLockHandle GStaticRwLockFree(this GStaticRWLockHandle @lock)
    {
        GStaticRWLockExterns.g_static_rw_lock_free(@lock);
        return @lock;
    }
}
