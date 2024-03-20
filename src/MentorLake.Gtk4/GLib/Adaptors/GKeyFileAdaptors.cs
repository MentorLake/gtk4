using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GKeyFileAdaptors
{
	public static GKeyFileHandle Ref(this GKeyFileHandle key_file)
	{
		return GKeyFileExterns.g_key_file_ref(key_file);
	}

	public static GKeyFileHandle Unref(this GKeyFileHandle key_file)
	{
		GKeyFileExterns.g_key_file_unref(key_file);
		return key_file;
	}

	public static GKeyFileHandle Free(this GKeyFileHandle key_file)
	{
		GKeyFileExterns.g_key_file_free(key_file);
		return key_file;
	}

	public static GKeyFileHandle SetListSeparator(this GKeyFileHandle key_file, char separator)
	{
		GKeyFileExterns.g_key_file_set_list_separator(key_file, separator);
		return key_file;
	}

	public static int LoadFromFile(this GKeyFileHandle key_file, string file, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_file(key_file, file, flags, out error);
	}

	public static int LoadFromData(this GKeyFileHandle key_file, string data, nuint length, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_data(key_file, data, length, flags, out error);
	}

	public static int LoadFromBytes(this GKeyFileHandle key_file, GBytesHandle bytes, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_bytes(key_file, bytes, flags, out error);
	}

	public static int LoadFromDirs(this GKeyFileHandle key_file, string file, string[] search_dirs, out string full_path, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_dirs(key_file, file, search_dirs, out full_path, flags, out error);
	}

	public static int LoadFromDataDirs(this GKeyFileHandle key_file, string file, string[] full_path, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_data_dirs(key_file, file, full_path, flags, out error);
	}

	public static string ToData(this GKeyFileHandle key_file, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_to_data(key_file, out length, out error);
	}

	public static int SaveToFile(this GKeyFileHandle key_file, string filename, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_save_to_file(key_file, filename, out error);
	}

	public static string GetStartGroup(this GKeyFileHandle key_file)
	{
		return GKeyFileExterns.g_key_file_get_start_group(key_file);
	}

	public static string[] GetGroups(this GKeyFileHandle key_file, out nuint length)
	{
		return GKeyFileExterns.g_key_file_get_groups(key_file, out length);
	}

	public static string[] GetKeys(this GKeyFileHandle key_file, string group_name, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_keys(key_file, group_name, out length, out error);
	}

	public static int HasGroup(this GKeyFileHandle key_file, string group_name)
	{
		return GKeyFileExterns.g_key_file_has_group(key_file, group_name);
	}

	public static int HasKey(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_has_key(key_file, group_name, key, out error);
	}

	public static string GetValue(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_value(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetValue(this GKeyFileHandle key_file, string group_name, string key, string value)
	{
		GKeyFileExterns.g_key_file_set_value(key_file, group_name, key, value);
		return key_file;
	}

	public static string GetString(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_string(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetString(this GKeyFileHandle key_file, string group_name, string key, string @string)
	{
		GKeyFileExterns.g_key_file_set_string(key_file, group_name, key, @string);
		return key_file;
	}

	public static string GetLocaleString(this GKeyFileHandle key_file, string group_name, string key, string locale, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_locale_string(key_file, group_name, key, locale, out error);
	}

	public static string GetLocaleForKey(this GKeyFileHandle key_file, string group_name, string key, string locale)
	{
		return GKeyFileExterns.g_key_file_get_locale_for_key(key_file, group_name, key, locale);
	}

	public static GKeyFileHandle SetLocaleString(this GKeyFileHandle key_file, string group_name, string key, string locale, string @string)
	{
		GKeyFileExterns.g_key_file_set_locale_string(key_file, group_name, key, locale, @string);
		return key_file;
	}

	public static int GetBoolean(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_boolean(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetBoolean(this GKeyFileHandle key_file, string group_name, string key, int value)
	{
		GKeyFileExterns.g_key_file_set_boolean(key_file, group_name, key, value);
		return key_file;
	}

	public static int GetInteger(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_integer(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetInteger(this GKeyFileHandle key_file, string group_name, string key, int value)
	{
		GKeyFileExterns.g_key_file_set_integer(key_file, group_name, key, value);
		return key_file;
	}

	public static nint GetInt64(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_int64(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetInt64(this GKeyFileHandle key_file, string group_name, string key, nint value)
	{
		GKeyFileExterns.g_key_file_set_int64(key_file, group_name, key, value);
		return key_file;
	}

	public static nuint GetUint64(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_uint64(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetUint64(this GKeyFileHandle key_file, string group_name, string key, nuint value)
	{
		GKeyFileExterns.g_key_file_set_uint64(key_file, group_name, key, value);
		return key_file;
	}

	public static double GetDouble(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_double(key_file, group_name, key, out error);
	}

	public static GKeyFileHandle SetDouble(this GKeyFileHandle key_file, string group_name, string key, double value)
	{
		GKeyFileExterns.g_key_file_set_double(key_file, group_name, key, value);
		return key_file;
	}

	public static string[] GetStringList(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_string_list(key_file, group_name, key, out length, out error);
	}

	public static GKeyFileHandle SetStringList(this GKeyFileHandle key_file, string group_name, string key, string[] list, nuint length)
	{
		GKeyFileExterns.g_key_file_set_string_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static string[] GetLocaleStringList(this GKeyFileHandle key_file, string group_name, string key, string locale, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_locale_string_list(key_file, group_name, key, locale, out length, out error);
	}

	public static GKeyFileHandle SetLocaleStringList(this GKeyFileHandle key_file, string group_name, string key, string locale, string[] list, nuint length)
	{
		GKeyFileExterns.g_key_file_set_locale_string_list(key_file, group_name, key, locale, list, length);
		return key_file;
	}

	public static int[] GetBooleanList(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_boolean_list(key_file, group_name, key, out length, out error);
	}

	public static GKeyFileHandle SetBooleanList(this GKeyFileHandle key_file, string group_name, string key, int[] list, nuint length)
	{
		GKeyFileExterns.g_key_file_set_boolean_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static int[] GetIntegerList(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_integer_list(key_file, group_name, key, out length, out error);
	}

	public static GKeyFileHandle SetDoubleList(this GKeyFileHandle key_file, string group_name, string key, double[] list, nuint length)
	{
		GKeyFileExterns.g_key_file_set_double_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static double[] GetDoubleList(this GKeyFileHandle key_file, string group_name, string key, out nuint length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_double_list(key_file, group_name, key, out length, out error);
	}

	public static GKeyFileHandle SetIntegerList(this GKeyFileHandle key_file, string group_name, string key, int[] list, nuint length)
	{
		GKeyFileExterns.g_key_file_set_integer_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static int SetComment(this GKeyFileHandle key_file, string group_name, string key, string comment, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_set_comment(key_file, group_name, key, comment, out error);
	}

	public static string GetComment(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_comment(key_file, group_name, key, out error);
	}

	public static int RemoveComment(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_remove_comment(key_file, group_name, key, out error);
	}

	public static int RemoveKey(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_remove_key(key_file, group_name, key, out error);
	}

	public static int RemoveGroup(this GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_remove_group(key_file, group_name, out error);
	}
}
