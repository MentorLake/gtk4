using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GTypeInstanceExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_type_instance_get_private")]
	internal static extern IntPtr g_type_instance_get_private(this GTypeInstanceHandle instance, GType private_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_free_instance")]
	internal static extern void g_type_free_instance(this GTypeInstanceHandle instance);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_instance")]
	internal static extern int g_type_check_instance(this GTypeInstanceHandle instance);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_instance_cast")]
	internal static extern GTypeInstanceHandle g_type_check_instance_cast(this GTypeInstanceHandle instance, GType iface_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_instance_is_a")]
	internal static extern int g_type_check_instance_is_a(this GTypeInstanceHandle instance, GType iface_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_instance_is_fundamentally_a")]
	internal static extern int g_type_check_instance_is_fundamentally_a(this GTypeInstanceHandle instance, GType fundamental_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_name_from_instance")]
	internal static extern string g_type_name_from_instance(this GTypeInstanceHandle instance);
}
