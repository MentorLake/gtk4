using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;

public static class GBindingExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_binding_get_flags")]
	internal static extern GBindingFlags g_binding_get_flags(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_get_source")]
	internal static extern GObjectHandle g_binding_get_source(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_dup_source")]
	internal static extern GObjectHandle g_binding_dup_source(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_get_target")]
	internal static extern GObjectHandle g_binding_get_target(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_dup_target")]
	internal static extern GObjectHandle g_binding_dup_target(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_get_source_property")]
	internal static extern string g_binding_get_source_property(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_get_target_property")]
	internal static extern string g_binding_get_target_property(this GBindingHandle binding);

	[DllImport(Libraries.GObject, EntryPoint = "g_binding_unbind")]
	internal static extern void g_binding_unbind(this GBindingHandle binding);
}
