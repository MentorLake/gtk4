using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRecMutexAdaptors
{
    public static GRecMutexHandle Init(this GRecMutexHandle rec_mutex)
    {
        GRecMutexExterns.g_rec_mutex_init(rec_mutex);
        return rec_mutex;
    }

    public static GRecMutexHandle Clear(this GRecMutexHandle rec_mutex)
    {
        GRecMutexExterns.g_rec_mutex_clear(rec_mutex);
        return rec_mutex;
    }

    public static GRecMutexHandle Lock(this GRecMutexHandle rec_mutex)
    {
        GRecMutexExterns.g_rec_mutex_lock(rec_mutex);
        return rec_mutex;
    }

    public static int Trylock(this GRecMutexHandle rec_mutex)
    {
        return GRecMutexExterns.g_rec_mutex_trylock(rec_mutex);
    }

    public static GRecMutexHandle Unlock(this GRecMutexHandle rec_mutex)
    {
        GRecMutexExterns.g_rec_mutex_unlock(rec_mutex);
        return rec_mutex;
    }
}
