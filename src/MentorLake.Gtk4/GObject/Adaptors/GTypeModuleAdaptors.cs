using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GTypeModuleAdaptors
{
    public static int Use(this GTypeModuleHandle module)
    {
        return GTypeModuleExterns.g_type_module_use(module);
    }

    public static GTypeModuleHandle Unuse(this GTypeModuleHandle module)
    {
        GTypeModuleExterns.g_type_module_unuse(module);
        return module;
    }

    public static GTypeModuleHandle SetName(this GTypeModuleHandle module, string name)
    {
        GTypeModuleExterns.g_type_module_set_name(module, name);
        return module;
    }

    public static GType RegisterType(this GTypeModuleHandle module, GType parent_type, string type_name, GTypeInfoHandle type_info, GTypeFlags flags)
    {
        return GTypeModuleExterns.g_type_module_register_type(module, parent_type, type_name, type_info, flags);
    }

    public static GTypeModuleHandle AddInterface(this GTypeModuleHandle module, GType instance_type, GType interface_type, GInterfaceInfoHandle interface_info)
    {
        GTypeModuleExterns.g_type_module_add_interface(module, instance_type, interface_type, interface_info);
        return module;
    }

    public static GType RegisterEnum(this GTypeModuleHandle module, string name, GEnumValueHandle const_static_values)
    {
        return GTypeModuleExterns.g_type_module_register_enum(module, name, const_static_values);
    }

    public static GType RegisterFlags(this GTypeModuleHandle module, string name, GFlagsValueHandle const_static_values)
    {
        return GTypeModuleExterns.g_type_module_register_flags(module, name, const_static_values);
    }
}
