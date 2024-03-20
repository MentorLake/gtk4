using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GTypeModuleExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_use")]
	internal static extern int g_type_module_use(this GTypeModuleHandle module);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_unuse")]
	internal static extern void g_type_module_unuse(this GTypeModuleHandle module);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_set_name")]
	internal static extern void g_type_module_set_name(this GTypeModuleHandle module, string name);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_register_type")]
	internal static extern GType g_type_module_register_type(this GTypeModuleHandle module, GType parent_type, string type_name, GTypeInfoHandle type_info, GTypeFlags flags);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_add_interface")]
	internal static extern void g_type_module_add_interface(this GTypeModuleHandle module, GType instance_type, GType interface_type, GInterfaceInfoHandle interface_info);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_register_enum")]
	internal static extern GType g_type_module_register_enum(this GTypeModuleHandle module, string name, GEnumValueHandle const_static_values);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_module_register_flags")]
	internal static extern GType g_type_module_register_flags(this GTypeModuleHandle module, string name, GFlagsValueHandle const_static_values);
}
