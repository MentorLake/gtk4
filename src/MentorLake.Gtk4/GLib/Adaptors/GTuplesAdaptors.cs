using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTuplesAdaptors
{
    public static GTuplesHandle Destroy(this GTuplesHandle tuples)
    {
        GTuplesExterns.g_tuples_destroy(tuples);
        return tuples;
    }

    public static IntPtr Index(this GTuplesHandle tuples, int index_, int field)
    {
        return GTuplesExterns.g_tuples_index(tuples, index_, field);
    }
}
