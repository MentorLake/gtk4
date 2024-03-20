using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;
public static class GObjectClassAdaptors
{
    public static GObjectClassHandle InstallProperty(this GObjectClassHandle oclass, uint property_id, GParamSpecHandle pspec)
    {
        GObjectClassExterns.g_object_class_install_property(oclass, property_id, pspec);
        return oclass;
    }

    public static GParamSpecHandle FindProperty(this GObjectClassHandle oclass, string property_name)
    {
        return GObjectClassExterns.g_object_class_find_property(oclass, property_name);
    }

    public static GParamSpecHandle[] ListProperties(this GObjectClassHandle oclass, out uint n_properties)
    {
        return GObjectClassExterns.g_object_class_list_properties(oclass, out n_properties);
    }

    public static GObjectClassHandle OverrideProperty(this GObjectClassHandle oclass, uint property_id, string name)
    {
        GObjectClassExterns.g_object_class_override_property(oclass, property_id, name);
        return oclass;
    }

    public static GObjectClassHandle InstallProperties(this GObjectClassHandle oclass, uint n_pspecs, out GParamSpecHandle pspecs)
    {
        GObjectClassExterns.g_object_class_install_properties(oclass, n_pspecs, out pspecs);
        return oclass;
    }
}
