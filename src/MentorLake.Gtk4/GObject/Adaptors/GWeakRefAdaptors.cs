using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;
public static class GWeakRefAdaptors
{
    public static GWeakRefHandle Init(this GWeakRefHandle weak_ref, IntPtr @object)
    {
        GWeakRefExterns.g_weak_ref_init(weak_ref, @object);
        return weak_ref;
    }

    public static GWeakRefHandle Clear(this GWeakRefHandle weak_ref)
    {
        GWeakRefExterns.g_weak_ref_clear(weak_ref);
        return weak_ref;
    }

    public static IntPtr Get(this GWeakRefHandle weak_ref)
    {
        return GWeakRefExterns.g_weak_ref_get(weak_ref);
    }

    public static GWeakRefHandle Set(this GWeakRefHandle weak_ref, IntPtr @object)
    {
        GWeakRefExterns.g_weak_ref_set(weak_ref, @object);
        return weak_ref;
    }
}
