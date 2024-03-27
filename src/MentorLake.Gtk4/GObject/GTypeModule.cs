using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GObject;

public class GTypeModuleHandle : GObjectHandle
{
}

public static class GTypeModuleSignals
{
}

public static class GTypeModuleHandleExtensions
{
	public static GTypeModuleHandle AddInterface(this GTypeModuleHandle module, GType instance_type, GType interface_type, GInterfaceInfoHandle interface_info)
	{
		GTypeModuleExterns.g_type_module_add_interface(module, instance_type, interface_type, interface_info);
		return module;
	}

	public static GType RegisterEnum(this GTypeModuleHandle module, string name, GEnumValue[] const_static_values)
	{
		return GTypeModuleExterns.g_type_module_register_enum(module, name, const_static_values);
	}

	public static GType RegisterFlags(this GTypeModuleHandle module, string name, GFlagsValue[] const_static_values)
	{
		return GTypeModuleExterns.g_type_module_register_flags(module, name, const_static_values);
	}

	public static GType RegisterType(this GTypeModuleHandle module, GType parent_type, string type_name, GTypeInfoHandle type_info, GTypeFlags flags)
	{
		return GTypeModuleExterns.g_type_module_register_type(module, parent_type, type_name, type_info, flags);
	}

	public static GTypeModuleHandle SetName(this GTypeModuleHandle module, string name)
	{
		GTypeModuleExterns.g_type_module_set_name(module, name);
		return module;
	}

	public static GTypeModuleHandle Unuse(this GTypeModuleHandle module)
	{
		GTypeModuleExterns.g_type_module_unuse(module);
		return module;
	}

	public static bool Use(this GTypeModuleHandle module)
	{
		return GTypeModuleExterns.g_type_module_use(module);
	}

}

internal class GTypeModuleExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_module_add_interface(GTypeModuleHandle module, GType instance_type, GType interface_type, GInterfaceInfoHandle interface_info);
	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_module_register_enum(GTypeModuleHandle module, string name, GEnumValue[] const_static_values);
	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_module_register_flags(GTypeModuleHandle module, string name, GFlagsValue[] const_static_values);
	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_module_register_type(GTypeModuleHandle module, GType parent_type, string type_name, GTypeInfoHandle type_info, GTypeFlags flags);
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_module_set_name(GTypeModuleHandle module, string name);
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_module_unuse(GTypeModuleHandle module);
	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_module_use(GTypeModuleHandle module);
}
