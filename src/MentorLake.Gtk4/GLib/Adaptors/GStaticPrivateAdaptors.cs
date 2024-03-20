using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStaticPrivateAdaptors
{
    public static GStaticPrivateHandle Init(this GStaticPrivateHandle private_key)
    {
        GStaticPrivateExterns.g_static_private_init(private_key);
        return private_key;
    }

    public static IntPtr Get(this GStaticPrivateHandle private_key)
    {
        return GStaticPrivateExterns.g_static_private_get(private_key);
    }

    public static GStaticPrivateHandle Set(this GStaticPrivateHandle private_key, IntPtr data, GDestroyNotify notify)
    {
        GStaticPrivateExterns.g_static_private_set(private_key, data, notify);
        return private_key;
    }

    public static GStaticPrivateHandle Free(this GStaticPrivateHandle private_key)
    {
        GStaticPrivateExterns.g_static_private_free(private_key);
        return private_key;
    }
}
