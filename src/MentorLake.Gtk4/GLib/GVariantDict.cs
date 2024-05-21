namespace MentorLake.Gtk4.GLib;

public class GVariantDictHandle : BaseSafeHandle
{
	public static GVariantDictHandle New(GVariantHandle from_asv)
	{
		return GVariantDictExterns.g_variant_dict_new(from_asv);
	}

}


public static class GVariantDictHandleExtensions
{
	public static GVariantDictHandle Clear(this GVariantDictHandle dict)
	{
		GVariantDictExterns.g_variant_dict_clear(dict);
		return dict;
	}

	public static bool Contains(this GVariantDictHandle dict, string key)
	{
		return GVariantDictExterns.g_variant_dict_contains(dict, key);
	}

	public static GVariantHandle End(this GVariantDictHandle dict)
	{
		return GVariantDictExterns.g_variant_dict_end(dict);
	}

	public static GVariantDictHandle Init(this GVariantDictHandle dict, GVariantHandle from_asv)
	{
		GVariantDictExterns.g_variant_dict_init(dict, from_asv);
		return dict;
	}

	public static GVariantDictHandle Insert(this GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		GVariantDictExterns.g_variant_dict_insert(dict, key, format_string, @__arglist);
		return dict;
	}

	public static GVariantDictHandle InsertValue(this GVariantDictHandle dict, string key, GVariantHandle value)
	{
		GVariantDictExterns.g_variant_dict_insert_value(dict, key, value);
		return dict;
	}

	public static bool Lookup(this GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		return GVariantDictExterns.g_variant_dict_lookup(dict, key, format_string, @__arglist);
	}

	public static GVariantHandle LookupValue(this GVariantDictHandle dict, string key, GVariantTypeHandle expected_type)
	{
		return GVariantDictExterns.g_variant_dict_lookup_value(dict, key, expected_type);
	}

	public static GVariantDictHandle Ref(this GVariantDictHandle dict)
	{
		return GVariantDictExterns.g_variant_dict_ref(dict);
	}

	public static bool Remove(this GVariantDictHandle dict, string key)
	{
		return GVariantDictExterns.g_variant_dict_remove(dict, key);
	}

	public static GVariantDictHandle Unref(this GVariantDictHandle dict)
	{
		GVariantDictExterns.g_variant_dict_unref(dict);
		return dict;
	}

}
internal class GVariantDictExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantDictHandle g_variant_dict_new(GVariantHandle from_asv);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_clear(GVariantDictHandle dict);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_dict_contains(GVariantDictHandle dict, string key);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_dict_end(GVariantDictHandle dict);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_init(GVariantDictHandle dict, GVariantHandle from_asv);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_insert(GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_insert_value(GVariantDictHandle dict, string key, GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_dict_lookup(GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_dict_lookup_value(GVariantDictHandle dict, string key, GVariantTypeHandle expected_type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantDictHandle g_variant_dict_ref(GVariantDictHandle dict);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_dict_remove(GVariantDictHandle dict, string key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_unref(GVariantDictHandle dict);

}

public struct GVariantDict
{
}
