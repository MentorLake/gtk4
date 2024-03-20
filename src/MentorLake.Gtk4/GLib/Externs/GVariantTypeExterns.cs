using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantTypeExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_free")]
    internal static extern void g_variant_type_free(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_copy")]
    internal static extern GVariantTypeHandle g_variant_type_copy(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_get_string_length")]
    internal static extern nuint g_variant_type_get_string_length(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_peek_string")]
    internal static extern string g_variant_type_peek_string(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_dup_string")]
    internal static extern string g_variant_type_dup_string(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_definite")]
    internal static extern int g_variant_type_is_definite(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_container")]
    internal static extern int g_variant_type_is_container(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_basic")]
    internal static extern int g_variant_type_is_basic(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_maybe")]
    internal static extern int g_variant_type_is_maybe(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_array")]
    internal static extern int g_variant_type_is_array(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_tuple")]
    internal static extern int g_variant_type_is_tuple(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_dict_entry")]
    internal static extern int g_variant_type_is_dict_entry(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_variant")]
    internal static extern int g_variant_type_is_variant(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_is_subtype_of")]
    internal static extern int g_variant_type_is_subtype_of(this GVariantTypeHandle type, GVariantTypeHandle supertype);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_element")]
    internal static extern GVariantTypeHandle g_variant_type_element(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_first")]
    internal static extern GVariantTypeHandle g_variant_type_first(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_next")]
    internal static extern GVariantTypeHandle g_variant_type_next(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_n_items")]
    internal static extern nuint g_variant_type_n_items(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_key")]
    internal static extern GVariantTypeHandle g_variant_type_key(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_value")]
    internal static extern GVariantTypeHandle g_variant_type_value(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_new_array")]
    internal static extern GVariantTypeHandle g_variant_type_new_array(this GVariantTypeHandle element);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_new_maybe")]
    internal static extern GVariantTypeHandle g_variant_type_new_maybe(this GVariantTypeHandle element);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_new_tuple")]
    internal static extern GVariantTypeHandle g_variant_type_new_tuple(GVariantTypeHandle[] items, int length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_type_new_dict_entry")]
    internal static extern GVariantTypeHandle g_variant_type_new_dict_entry(this GVariantTypeHandle key, GVariantTypeHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_fixed_array")]
    internal static extern GVariantHandle g_variant_new_fixed_array(this GVariantTypeHandle element_type, IntPtr elements, nuint n_elements, nuint element_size);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_maybe")]
    internal static extern GVariantHandle g_variant_new_maybe(this GVariantTypeHandle child_type, GVariantHandle child);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_array")]
    internal static extern GVariantHandle g_variant_new_array(this GVariantTypeHandle child_type, GVariant children, nuint n_children);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_from_bytes")]
    internal static extern GVariantHandle g_variant_new_from_bytes(this GVariantTypeHandle type, GBytesHandle bytes, int trusted);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_from_data")]
    internal static extern GVariantHandle g_variant_new_from_data(this GVariantTypeHandle type, IntPtr data, nuint size, int trusted, GDestroyNotify notify, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_builder_new")]
    internal static extern GVariantBuilderHandle g_variant_builder_new(this GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_parse")]
    internal static extern GVariantHandle g_variant_parse(this GVariantTypeHandle type, string text, string limit, out string endptr, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantTypeHandle g_variant_type_new(string type_string);
}
