using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GVariantDictExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_init")]
	internal static extern void g_variant_dict_init(this GVariantDictHandle dict, GVariantHandle from_asv);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_lookup")]
	internal static extern int g_variant_dict_lookup(this GVariantDictHandle dict, string key, string format_string, IntPtr @__argList);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_lookup_value")]
	internal static extern GVariantHandle g_variant_dict_lookup_value(this GVariantDictHandle dict, string key, GVariantTypeHandle expected_type);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_contains")]
	internal static extern int g_variant_dict_contains(this GVariantDictHandle dict, string key);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_insert")]
	internal static extern void g_variant_dict_insert(this GVariantDictHandle dict, string key, string format_string, IntPtr @__argList);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_insert_value")]
	internal static extern void g_variant_dict_insert_value(this GVariantDictHandle dict, string key, GVariantHandle value);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_remove")]
	internal static extern int g_variant_dict_remove(this GVariantDictHandle dict, string key);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_clear")]
	internal static extern void g_variant_dict_clear(this GVariantDictHandle dict);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_end")]
	internal static extern GVariantHandle g_variant_dict_end(this GVariantDictHandle dict);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_ref")]
	internal static extern GVariantDictHandle g_variant_dict_ref(this GVariantDictHandle dict);

	[DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_unref")]
	internal static extern void g_variant_dict_unref(this GVariantDictHandle dict);
}
