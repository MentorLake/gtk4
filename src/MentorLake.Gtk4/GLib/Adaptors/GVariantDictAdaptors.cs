using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantDictAdaptors
{
    public static GVariantDictHandle Init(this GVariantDictHandle dict, GVariantHandle from_asv)
    {
        GVariantDictExterns.g_variant_dict_init(dict, from_asv);
        return dict;
    }

    public static int Lookup(this GVariantDictHandle dict, string key, string format_string, IntPtr @__argList)
    {
        return GVariantDictExterns.g_variant_dict_lookup(dict, key, format_string, @__argList);
    }

    public static GVariantHandle LookupValue(this GVariantDictHandle dict, string key, GVariantTypeHandle expected_type)
    {
        return GVariantDictExterns.g_variant_dict_lookup_value(dict, key, expected_type);
    }

    public static int Contains(this GVariantDictHandle dict, string key)
    {
        return GVariantDictExterns.g_variant_dict_contains(dict, key);
    }

    public static GVariantDictHandle Insert(this GVariantDictHandle dict, string key, string format_string, IntPtr @__argList)
    {
        GVariantDictExterns.g_variant_dict_insert(dict, key, format_string, @__argList);
        return dict;
    }

    public static GVariantDictHandle InsertValue(this GVariantDictHandle dict, string key, GVariantHandle value)
    {
        GVariantDictExterns.g_variant_dict_insert_value(dict, key, value);
        return dict;
    }

    public static int Remove(this GVariantDictHandle dict, string key)
    {
        return GVariantDictExterns.g_variant_dict_remove(dict, key);
    }

    public static GVariantDictHandle Clear(this GVariantDictHandle dict)
    {
        GVariantDictExterns.g_variant_dict_clear(dict);
        return dict;
    }

    public static GVariantHandle End(this GVariantDictHandle dict)
    {
        return GVariantDictExterns.g_variant_dict_end(dict);
    }

    public static GVariantDictHandle Ref(this GVariantDictHandle dict)
    {
        return GVariantDictExterns.g_variant_dict_ref(dict);
    }

    public static GVariantDictHandle Unref(this GVariantDictHandle dict)
    {
        GVariantDictExterns.g_variant_dict_unref(dict);
        return dict;
    }
}
