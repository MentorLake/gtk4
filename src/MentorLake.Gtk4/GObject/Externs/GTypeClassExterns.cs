using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GTypeClassExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_type_class_get_private")]
	internal static extern IntPtr g_type_class_get_private(this GTypeClassHandle klass, GType private_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_class_cast")]
	internal static extern GTypeClassHandle g_type_check_class_cast(this GTypeClassHandle g_class, GType is_a_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_class_is_a")]
	internal static extern int g_type_check_class_is_a(this GTypeClassHandle g_class, GType is_a_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_name_from_class")]
	internal static extern string g_type_name_from_class(this GTypeClassHandle g_class);
}
