using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GTypePluginAdaptors
{
    public static GTypePluginHandle Use(this GTypePluginHandle plugin)
    {
        GTypePluginExterns.g_type_plugin_use(plugin);
        return plugin;
    }

    public static GTypePluginHandle Unuse(this GTypePluginHandle plugin)
    {
        GTypePluginExterns.g_type_plugin_unuse(plugin);
        return plugin;
    }

    public static GTypePluginHandle CompleteTypeInfo(this GTypePluginHandle plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table)
    {
        GTypePluginExterns.g_type_plugin_complete_type_info(plugin, g_type, info, value_table);
        return plugin;
    }

    public static GTypePluginHandle CompleteInterfaceInfo(this GTypePluginHandle plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info)
    {
        GTypePluginExterns.g_type_plugin_complete_interface_info(plugin, instance_type, interface_type, info);
        return plugin;
    }
}
