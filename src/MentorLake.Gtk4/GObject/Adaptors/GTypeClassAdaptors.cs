using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GTypeClassAdaptors
{
    public static IntPtr GetPrivate(this GTypeClassHandle klass, GType private_type)
    {
        return GTypeClassExterns.g_type_class_get_private(klass, private_type);
    }

    public static GTypeClassHandle GTypeCheckClassCast(this GTypeClassHandle g_class, GType is_a_type)
    {
        return GTypeClassExterns.g_type_check_class_cast(g_class, is_a_type);
    }

    public static int GTypeCheckClassIsA(this GTypeClassHandle g_class, GType is_a_type)
    {
        return GTypeClassExterns.g_type_check_class_is_a(g_class, is_a_type);
    }

    public static string GTypeNameFromClass(this GTypeClassHandle g_class)
    {
        return GTypeClassExterns.g_type_name_from_class(g_class);
    }
}
