using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStaticMutexAdaptors
{
    public static GStaticMutexHandle Init(this GStaticMutexHandle mutex)
    {
        GStaticMutexExterns.g_static_mutex_init(mutex);
        return mutex;
    }

    public static GStaticMutexHandle Free(this GStaticMutexHandle mutex)
    {
        GStaticMutexExterns.g_static_mutex_free(mutex);
        return mutex;
    }

    public static GMutexHandle GetMutexImpl(this GStaticMutexHandle mutex)
    {
        return GStaticMutexExterns.g_static_mutex_get_mutex_impl(mutex);
    }
}
