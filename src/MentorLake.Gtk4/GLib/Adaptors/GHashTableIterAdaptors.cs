using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHashTableIterAdaptors
{
    public static GHashTableIterHandle Init(this GHashTableIterHandle iter, GHashTableHandle hash_table)
    {
        GHashTableIterExterns.g_hash_table_iter_init(iter, hash_table);
        return iter;
    }

    public static int Next(this GHashTableIterHandle iter, out IntPtr key, out IntPtr value)
    {
        return GHashTableIterExterns.g_hash_table_iter_next(iter, out key, out value);
    }

    public static GHashTableHandle GetHashTable(this GHashTableIterHandle iter)
    {
        return GHashTableIterExterns.g_hash_table_iter_get_hash_table(iter);
    }

    public static GHashTableIterHandle Remove(this GHashTableIterHandle iter)
    {
        GHashTableIterExterns.g_hash_table_iter_remove(iter);
        return iter;
    }

    public static GHashTableIterHandle Replace(this GHashTableIterHandle iter, IntPtr value)
    {
        GHashTableIterExterns.g_hash_table_iter_replace(iter, value);
        return iter;
    }

    public static GHashTableIterHandle Steal(this GHashTableIterHandle iter)
    {
        GHashTableIterExterns.g_hash_table_iter_steal(iter);
        return iter;
    }
}
