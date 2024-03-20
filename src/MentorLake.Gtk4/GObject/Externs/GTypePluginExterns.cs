using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GTypePluginExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_type_plugin_use")]
	internal static extern void g_type_plugin_use(this GTypePluginHandle plugin);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_plugin_unuse")]
	internal static extern void g_type_plugin_unuse(this GTypePluginHandle plugin);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_plugin_complete_type_info")]
	internal static extern void g_type_plugin_complete_type_info(this GTypePluginHandle plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_plugin_complete_interface_info")]
	internal static extern void g_type_plugin_complete_interface_info(this GTypePluginHandle plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info);
}
