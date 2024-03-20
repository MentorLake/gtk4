using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GTypeInstanceAdaptors
{
    public static IntPtr GetPrivate(this GTypeInstanceHandle instance, GType private_type)
    {
        return GTypeInstanceExterns.g_type_instance_get_private(instance, private_type);
    }

    public static GTypeInstanceHandle GTypeFreeInstance(this GTypeInstanceHandle instance)
    {
        GTypeInstanceExterns.g_type_free_instance(instance);
        return instance;
    }

    public static int GTypeCheckInstance(this GTypeInstanceHandle instance)
    {
        return GTypeInstanceExterns.g_type_check_instance(instance);
    }

    public static GTypeInstanceHandle GTypeCheckInstanceCast(this GTypeInstanceHandle instance, GType iface_type)
    {
        return GTypeInstanceExterns.g_type_check_instance_cast(instance, iface_type);
    }

    public static int GTypeCheckInstanceIsA(this GTypeInstanceHandle instance, GType iface_type)
    {
        return GTypeInstanceExterns.g_type_check_instance_is_a(instance, iface_type);
    }

    public static int GTypeCheckInstanceIsFundamentallyA(this GTypeInstanceHandle instance, GType fundamental_type)
    {
        return GTypeInstanceExterns.g_type_check_instance_is_fundamentally_a(instance, fundamental_type);
    }

    public static string GTypeNameFromInstance(this GTypeInstanceHandle instance)
    {
        return GTypeInstanceExterns.g_type_name_from_instance(instance);
    }
}
