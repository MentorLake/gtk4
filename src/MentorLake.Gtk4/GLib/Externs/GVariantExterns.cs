using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_unref")]
    internal static extern void g_variant_unref(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_ref")]
    internal static extern GVariantHandle g_variant_ref(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_ref_sink")]
    internal static extern GVariantHandle g_variant_ref_sink(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_is_floating")]
    internal static extern int g_variant_is_floating(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_take_ref")]
    internal static extern GVariantHandle g_variant_take_ref(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_type")]
    internal static extern GVariantTypeHandle g_variant_get_type(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_type_string")]
    internal static extern string g_variant_get_type_string(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_is_of_type")]
    internal static extern int g_variant_is_of_type(this GVariantHandle value, GVariantTypeHandle type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_is_container")]
    internal static extern int g_variant_is_container(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_classify")]
    internal static extern GVariantClass g_variant_classify(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_variant")]
    internal static extern GVariantHandle g_variant_new_variant(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_boolean")]
    internal static extern int g_variant_get_boolean(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_byte")]
    internal static extern byte g_variant_get_byte(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_int16")]
    internal static extern short g_variant_get_int16(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_uint16")]
    internal static extern ushort g_variant_get_uint16(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_int32")]
    internal static extern int g_variant_get_int32(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_uint32")]
    internal static extern uint g_variant_get_uint32(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_int64")]
    internal static extern nint g_variant_get_int64(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_uint64")]
    internal static extern nuint g_variant_get_uint64(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_handle")]
    internal static extern int g_variant_get_handle(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_double")]
    internal static extern double g_variant_get_double(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_variant")]
    internal static extern GVariantHandle g_variant_get_variant(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_string")]
    internal static extern string g_variant_get_string(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_dup_string")]
    internal static extern string g_variant_dup_string(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_strv")]
    internal static extern string[] g_variant_get_strv(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_dup_strv")]
    internal static extern string[] g_variant_dup_strv(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_objv")]
    internal static extern string[] g_variant_get_objv(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_dup_objv")]
    internal static extern string[] g_variant_dup_objv(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_bytestring")]
    internal static extern string g_variant_get_bytestring(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_dup_bytestring")]
    internal static extern string g_variant_dup_bytestring(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_bytestring_array")]
    internal static extern string[] g_variant_get_bytestring_array(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_dup_bytestring_array")]
    internal static extern string[] g_variant_dup_bytestring_array(this GVariantHandle value, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_new_dict_entry")]
    internal static extern GVariantHandle g_variant_new_dict_entry(this GVariantHandle key, GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_maybe")]
    internal static extern GVariantHandle g_variant_get_maybe(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_n_children")]
    internal static extern nuint g_variant_n_children(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_child")]
    internal static extern void g_variant_get_child(this GVariantHandle value, nuint index_, string format_string, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_child_value")]
    internal static extern GVariantHandle g_variant_get_child_value(this GVariantHandle value, nuint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_lookup")]
    internal static extern int g_variant_lookup(this GVariantHandle dictionary, string key, string format_string, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_lookup_value")]
    internal static extern GVariantHandle g_variant_lookup_value(this GVariantHandle dictionary, string key, GVariantTypeHandle expected_type);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_fixed_array")]
    internal static extern IntPtr[] g_variant_get_fixed_array(this GVariantHandle value, out nuint n_elements, nuint element_size);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_size")]
    internal static extern nuint g_variant_get_size(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_data")]
    internal static extern IntPtr g_variant_get_data(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_data_as_bytes")]
    internal static extern GBytesHandle g_variant_get_data_as_bytes(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_store")]
    internal static extern void g_variant_store(this GVariantHandle value, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_print")]
    internal static extern string g_variant_print(this GVariantHandle value, int type_annotate);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_print_string")]
    internal static extern GStringHandle g_variant_print_string(this GVariantHandle value, GStringHandle @string, int type_annotate);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_normal_form")]
    internal static extern GVariantHandle g_variant_get_normal_form(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_is_normal_form")]
    internal static extern int g_variant_is_normal_form(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_byteswap")]
    internal static extern GVariantHandle g_variant_byteswap(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_iter_new")]
    internal static extern GVariantIterHandle g_variant_iter_new(this GVariantHandle value);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get")]
    internal static extern void g_variant_get(this GVariantHandle value, string format_string, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_get_va")]
    internal static extern void g_variant_get_va(this GVariantHandle value, string format_string, out string endptr, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_check_format_string")]
    internal static extern int g_variant_check_format_string(this GVariantHandle value, string format_string, int copy_only);
    [DllImport(Libraries.GLib, EntryPoint = "g_variant_dict_new")]
    internal static extern GVariantDictHandle g_variant_dict_new(this GVariantHandle from_asv);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_boolean(int value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_byte(byte value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_int16(short value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_uint16(ushort value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_int32(int value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_uint32(uint value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_int64(nint value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_uint64(nuint value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_handle(int value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_double(double value);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_string(string @string);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_take_string(string @string);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_printf(string format_string, IntPtr @__arglist);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_object_path(string object_path);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_signature(string signature);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_strv(string strv, nint length);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_objv(string strv, nint length);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_bytestring(string @string);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_bytestring_array(string strv, nint length);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_tuple(GVariant children, nuint n_children);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new(string format_string, IntPtr @__arglist);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_va(string format_string, out string endptr, IntPtr @__arglist);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_parsed(string format, IntPtr @__arglist);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GVariantHandle g_variant_new_parsed_va(string format, IntPtr @__arglist);
}
