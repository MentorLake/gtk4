using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRWLockAdaptors
{
    public static GRWLockHandle GRwLockInit(this GRWLockHandle rw_lock)
    {
        GRWLockExterns.g_rw_lock_init(rw_lock);
        return rw_lock;
    }

    public static GRWLockHandle GRwLockClear(this GRWLockHandle rw_lock)
    {
        GRWLockExterns.g_rw_lock_clear(rw_lock);
        return rw_lock;
    }

    public static GRWLockHandle GRwLockWriterLock(this GRWLockHandle rw_lock)
    {
        GRWLockExterns.g_rw_lock_writer_lock(rw_lock);
        return rw_lock;
    }

    public static int GRwLockWriterTrylock(this GRWLockHandle rw_lock)
    {
        return GRWLockExterns.g_rw_lock_writer_trylock(rw_lock);
    }

    public static GRWLockHandle GRwLockWriterUnlock(this GRWLockHandle rw_lock)
    {
        GRWLockExterns.g_rw_lock_writer_unlock(rw_lock);
        return rw_lock;
    }

    public static GRWLockHandle GRwLockReaderLock(this GRWLockHandle rw_lock)
    {
        GRWLockExterns.g_rw_lock_reader_lock(rw_lock);
        return rw_lock;
    }

    public static int GRwLockReaderTrylock(this GRWLockHandle rw_lock)
    {
        return GRWLockExterns.g_rw_lock_reader_trylock(rw_lock);
    }

    public static GRWLockHandle GRwLockReaderUnlock(this GRWLockHandle rw_lock)
    {
        GRWLockExterns.g_rw_lock_reader_unlock(rw_lock);
        return rw_lock;
    }
}
