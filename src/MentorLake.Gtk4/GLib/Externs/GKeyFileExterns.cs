using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GKeyFileExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_ref")]
    internal static extern GKeyFileHandle g_key_file_ref(this GKeyFileHandle key_file);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_unref")]
    internal static extern void g_key_file_unref(this GKeyFileHandle key_file);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_free")]
    internal static extern void g_key_file_free(this GKeyFileHandle key_file);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_list_separator")]
    internal static extern void g_key_file_set_list_separator(this GKeyFileHandle key_file, char separator);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_load_from_file")]
    internal static extern int g_key_file_load_from_file(this GKeyFileHandle key_file, string file, GKeyFileFlags flags, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_load_from_data")]
    internal static extern int g_key_file_load_from_data(this GKeyFileHandle key_file, string data, nuint length, GKeyFileFlags flags, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_load_from_bytes")]
    internal static extern int g_key_file_load_from_bytes(this GKeyFileHandle key_file, GBytesHandle bytes, GKeyFileFlags flags, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_load_from_dirs")]
    internal static extern int g_key_file_load_from_dirs(this GKeyFileHandle key_file, string file, string[] search_dirs, out string full_path, GKeyFileFlags flags, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_load_from_data_dirs")]
    internal static extern int g_key_file_load_from_data_dirs(this GKeyFileHandle key_file, string file, string[] full_path, GKeyFileFlags flags, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_to_data")]
    internal static extern string g_key_file_to_data(this GKeyFileHandle key_file, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_save_to_file")]
    internal static extern int g_key_file_save_to_file(this GKeyFileHandle key_file, string filename, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_start_group")]
    internal static extern string g_key_file_get_start_group(this GKeyFileHandle key_file);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_groups")]
    internal static extern string[] g_key_file_get_groups(this GKeyFileHandle key_file, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_keys")]
    internal static extern string[] g_key_file_get_keys(this GKeyFileHandle key_file, string group_name, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_has_group")]
    internal static extern int g_key_file_has_group(this GKeyFileHandle key_file, string group_name);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_has_key")]
    internal static extern int g_key_file_has_key(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_value")]
    internal static extern string g_key_file_get_value(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_value")]
    internal static extern void g_key_file_set_value(this GKeyFileHandle key_file, string group_name, string key, string value);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_string")]
    internal static extern string g_key_file_get_string(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_string")]
    internal static extern void g_key_file_set_string(this GKeyFileHandle key_file, string group_name, string key, string @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_locale_string")]
    internal static extern string g_key_file_get_locale_string(this GKeyFileHandle key_file, string group_name, string key, string locale, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_locale_for_key")]
    internal static extern string g_key_file_get_locale_for_key(this GKeyFileHandle key_file, string group_name, string key, string locale);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_locale_string")]
    internal static extern void g_key_file_set_locale_string(this GKeyFileHandle key_file, string group_name, string key, string locale, string @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_boolean")]
    internal static extern int g_key_file_get_boolean(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_boolean")]
    internal static extern void g_key_file_set_boolean(this GKeyFileHandle key_file, string group_name, string key, int value);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_integer")]
    internal static extern int g_key_file_get_integer(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_integer")]
    internal static extern void g_key_file_set_integer(this GKeyFileHandle key_file, string group_name, string key, int value);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_int64")]
    internal static extern nint g_key_file_get_int64(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_int64")]
    internal static extern void g_key_file_set_int64(this GKeyFileHandle key_file, string group_name, string key, nint value);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_uint64")]
    internal static extern nuint g_key_file_get_uint64(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_uint64")]
    internal static extern void g_key_file_set_uint64(this GKeyFileHandle key_file, string group_name, string key, nuint value);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_double")]
    internal static extern double g_key_file_get_double(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_double")]
    internal static extern void g_key_file_set_double(this GKeyFileHandle key_file, string group_name, string key, double value);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_string_list")]
    internal static extern string[] g_key_file_get_string_list(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_string_list")]
    internal static extern void g_key_file_set_string_list(this GKeyFileHandle key_file, string group_name, string key, string[] list, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_locale_string_list")]
    internal static extern string[] g_key_file_get_locale_string_list(this GKeyFileHandle key_file, string group_name, string key, string locale, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_locale_string_list")]
    internal static extern void g_key_file_set_locale_string_list(this GKeyFileHandle key_file, string group_name, string key, string locale, string[] list, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_boolean_list")]
    internal static extern int[] g_key_file_get_boolean_list(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_boolean_list")]
    internal static extern void g_key_file_set_boolean_list(this GKeyFileHandle key_file, string group_name, string key, int[] list, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_integer_list")]
    internal static extern int[] g_key_file_get_integer_list(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_double_list")]
    internal static extern void g_key_file_set_double_list(this GKeyFileHandle key_file, string group_name, string key, double[] list, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_double_list")]
    internal static extern double[] g_key_file_get_double_list(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_integer_list")]
    internal static extern void g_key_file_set_integer_list(this GKeyFileHandle key_file, string group_name, string key, int[] list, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_set_comment")]
    internal static extern int g_key_file_set_comment(this GKeyFileHandle key_file, string group_name, string key, string comment, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_get_comment")]
    internal static extern string g_key_file_get_comment(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_remove_comment")]
    internal static extern int g_key_file_remove_comment(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_remove_key")]
    internal static extern int g_key_file_remove_key(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_key_file_remove_group")]
    internal static extern int g_key_file_remove_group(this GKeyFileHandle key_file, string group_name, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GKeyFileHandle g_key_file_new();
}
