using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;

public static class GFlagsClassExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_flags_get_first_value")]
	internal static extern GFlagsValueHandle g_flags_get_first_value(this GFlagsClassHandle flags_class, uint value);

	[DllImport(Libraries.GObject, EntryPoint = "g_flags_get_value_by_name")]
	internal static extern GFlagsValueHandle g_flags_get_value_by_name(this GFlagsClassHandle flags_class, string name);

	[DllImport(Libraries.GObject, EntryPoint = "g_flags_get_value_by_nick")]
	internal static extern GFlagsValueHandle g_flags_get_value_by_nick(this GFlagsClassHandle flags_class, string nick);
}
