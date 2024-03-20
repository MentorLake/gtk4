using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;

public static class GObjectClassExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_object_class_install_property")]
	internal static extern void g_object_class_install_property(this GObjectClassHandle oclass, uint property_id, GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_object_class_find_property")]
	internal static extern GParamSpecHandle g_object_class_find_property(this GObjectClassHandle oclass, string property_name);

	[DllImport(Libraries.GObject, EntryPoint = "g_object_class_list_properties")]
	internal static extern GParamSpecHandle[] g_object_class_list_properties(this GObjectClassHandle oclass, out uint n_properties);

	[DllImport(Libraries.GObject, EntryPoint = "g_object_class_override_property")]
	internal static extern void g_object_class_override_property(this GObjectClassHandle oclass, uint property_id, string name);

	[DllImport(Libraries.GObject, EntryPoint = "g_object_class_install_properties")]
	internal static extern void g_object_class_install_properties(this GObjectClassHandle oclass, uint n_pspecs, out GParamSpecHandle pspecs);
}
