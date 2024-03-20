using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStaticRecMutexAdaptors
{
    public static GStaticRecMutexHandle Init(this GStaticRecMutexHandle mutex)
    {
        GStaticRecMutexExterns.g_static_rec_mutex_init(mutex);
        return mutex;
    }

    public static GStaticRecMutexHandle Lock(this GStaticRecMutexHandle mutex)
    {
        GStaticRecMutexExterns.g_static_rec_mutex_lock(mutex);
        return mutex;
    }

    public static int Trylock(this GStaticRecMutexHandle mutex)
    {
        return GStaticRecMutexExterns.g_static_rec_mutex_trylock(mutex);
    }

    public static GStaticRecMutexHandle Unlock(this GStaticRecMutexHandle mutex)
    {
        GStaticRecMutexExterns.g_static_rec_mutex_unlock(mutex);
        return mutex;
    }

    public static GStaticRecMutexHandle LockFull(this GStaticRecMutexHandle mutex, uint depth)
    {
        GStaticRecMutexExterns.g_static_rec_mutex_lock_full(mutex, depth);
        return mutex;
    }

    public static uint UnlockFull(this GStaticRecMutexHandle mutex)
    {
        return GStaticRecMutexExterns.g_static_rec_mutex_unlock_full(mutex);
    }

    public static GStaticRecMutexHandle Free(this GStaticRecMutexHandle mutex)
    {
        GStaticRecMutexExterns.g_static_rec_mutex_free(mutex);
        return mutex;
    }
}
