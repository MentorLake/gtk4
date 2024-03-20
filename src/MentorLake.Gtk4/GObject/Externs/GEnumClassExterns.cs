using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;

public static class GEnumClassExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_enum_get_value")]
	internal static extern GEnumValueHandle g_enum_get_value(this GEnumClassHandle enum_class, int value);

	[DllImport(Libraries.GObject, EntryPoint = "g_enum_get_value_by_name")]
	internal static extern GEnumValueHandle g_enum_get_value_by_name(this GEnumClassHandle enum_class, string name);

	[DllImport(Libraries.GObject, EntryPoint = "g_enum_get_value_by_nick")]
	internal static extern GEnumValueHandle g_enum_get_value_by_nick(this GEnumClassHandle enum_class, string nick);
}
