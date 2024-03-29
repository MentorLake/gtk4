using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GSettingsHandle : GObjectHandle
{
	public static GSettingsHandle New(string schema_id)
	{
		return GSettingsExterns.g_settings_new(schema_id);
	}

	public static GSettingsHandle NewFull(GSettingsSchemaHandle schema, GSettingsBackendHandle backend, string path)
	{
		return GSettingsExterns.g_settings_new_full(schema, backend, path);
	}

	public static GSettingsHandle NewWithBackend(string schema_id, GSettingsBackendHandle backend)
	{
		return GSettingsExterns.g_settings_new_with_backend(schema_id, backend);
	}

	public static GSettingsHandle NewWithBackendAndPath(string schema_id, GSettingsBackendHandle backend, string path)
	{
		return GSettingsExterns.g_settings_new_with_backend_and_path(schema_id, backend, path);
	}

	public static GSettingsHandle NewWithPath(string schema_id, string path)
	{
		return GSettingsExterns.g_settings_new_with_path(schema_id, path);
	}

	public static string ListRelocatableSchemas()
	{
		return GSettingsExterns.g_settings_list_relocatable_schemas();
	}

	public static string ListSchemas()
	{
		return GSettingsExterns.g_settings_list_schemas();
	}

	public static void Sync()
	{
		GSettingsExterns.g_settings_sync();
	}

	public static void Unbind(GObjectHandle @object, string property)
	{
		GSettingsExterns.g_settings_unbind(@object, property);
	}

}

public class GSettingsSignal
{
	public string Value { get; set; }
	public GSettingsSignal(string value) => Value = value;
}

public static class GSettingsSignals
{
	public static GSettingsSignal ChangeEvent = new("change-event");
	public static GSettingsSignal Changed = new("changed");
	public static GSettingsSignal WritableChangeEvent = new("writable-change-event");
	public static GSettingsSignal WritableChanged = new("writable-changed");
}

public static class GSettingsHandleExtensions
{
	public static GSettingsHandle Apply(this GSettingsHandle settings)
	{
		GSettingsExterns.g_settings_apply(settings);
		return settings;
	}

	public static GSettingsHandle Bind(this GSettingsHandle settings, string key, GObjectHandle @object, string property, GSettingsBindFlags flags)
	{
		GSettingsExterns.g_settings_bind(settings, key, @object, property, flags);
		return settings;
	}

	public static GSettingsHandle BindWithMapping(this GSettingsHandle settings, string key, GObjectHandle @object, string property, GSettingsBindFlags flags, GSettingsBindGetMapping get_mapping, GSettingsBindSetMapping set_mapping, IntPtr user_data, GDestroyNotify destroy)
	{
		GSettingsExterns.g_settings_bind_with_mapping(settings, key, @object, property, flags, get_mapping, set_mapping, user_data, destroy);
		return settings;
	}

	public static GSettingsHandle BindWritable(this GSettingsHandle settings, string key, GObjectHandle @object, string property, bool inverted)
	{
		GSettingsExterns.g_settings_bind_writable(settings, key, @object, property, inverted);
		return settings;
	}

	public static GActionHandle CreateAction(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_create_action(settings, key);
	}

	public static GSettingsHandle Delay(this GSettingsHandle settings)
	{
		GSettingsExterns.g_settings_delay(settings);
		return settings;
	}

	public static GSettingsHandle Get(this GSettingsHandle settings, string key, string format, IntPtr @__arglist)
	{
		GSettingsExterns.g_settings_get(settings, key, format, @__arglist);
		return settings;
	}

	public static bool GetBoolean(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_boolean(settings, key);
	}

	public static GSettingsHandle GetChild(this GSettingsHandle settings, string name)
	{
		return GSettingsExterns.g_settings_get_child(settings, name);
	}

	public static GVariantHandle GetDefaultValue(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_default_value(settings, key);
	}

	public static double GetDouble(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_double(settings, key);
	}

	public static int GetEnum(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_enum(settings, key);
	}

	public static uint GetFlags(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_flags(settings, key);
	}

	public static bool GetHasUnapplied(this GSettingsHandle settings)
	{
		return GSettingsExterns.g_settings_get_has_unapplied(settings);
	}

	public static int GetInt(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_int(settings, key);
	}

	public static long GetInt64(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_int64(settings, key);
	}

	public static IntPtr GetMapped(this GSettingsHandle settings, string key, GSettingsGetMapping mapping, IntPtr user_data)
	{
		return GSettingsExterns.g_settings_get_mapped(settings, key, mapping, user_data);
	}

	public static GVariantHandle GetRange(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_range(settings, key);
	}

	public static string GetString(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_string(settings, key);
	}

	public static string[] GetStrv(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_strv(settings, key);
	}

	public static uint GetUint(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_uint(settings, key);
	}

	public static ulong GetUint64(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_uint64(settings, key);
	}

	public static GVariantHandle GetUserValue(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_user_value(settings, key);
	}

	public static GVariantHandle GetValue(this GSettingsHandle settings, string key)
	{
		return GSettingsExterns.g_settings_get_value(settings, key);
	}

	public static bool IsWritable(this GSettingsHandle settings, string name)
	{
		return GSettingsExterns.g_settings_is_writable(settings, name);
	}

	public static string[] ListChildren(this GSettingsHandle settings)
	{
		return GSettingsExterns.g_settings_list_children(settings);
	}

	public static string[] ListKeys(this GSettingsHandle settings)
	{
		return GSettingsExterns.g_settings_list_keys(settings);
	}

	public static bool RangeCheck(this GSettingsHandle settings, string key, GVariantHandle value)
	{
		return GSettingsExterns.g_settings_range_check(settings, key, value);
	}

	public static GSettingsHandle Reset(this GSettingsHandle settings, string key)
	{
		GSettingsExterns.g_settings_reset(settings, key);
		return settings;
	}

	public static GSettingsHandle Revert(this GSettingsHandle settings)
	{
		GSettingsExterns.g_settings_revert(settings);
		return settings;
	}

	public static bool Set(this GSettingsHandle settings, string key, string format, IntPtr @__arglist)
	{
		return GSettingsExterns.g_settings_set(settings, key, format, @__arglist);
	}

	public static bool SetBoolean(this GSettingsHandle settings, string key, bool value)
	{
		return GSettingsExterns.g_settings_set_boolean(settings, key, value);
	}

	public static bool SetDouble(this GSettingsHandle settings, string key, double value)
	{
		return GSettingsExterns.g_settings_set_double(settings, key, value);
	}

	public static bool SetEnum(this GSettingsHandle settings, string key, int value)
	{
		return GSettingsExterns.g_settings_set_enum(settings, key, value);
	}

	public static bool SetFlags(this GSettingsHandle settings, string key, uint value)
	{
		return GSettingsExterns.g_settings_set_flags(settings, key, value);
	}

	public static bool SetInt(this GSettingsHandle settings, string key, int value)
	{
		return GSettingsExterns.g_settings_set_int(settings, key, value);
	}

	public static bool SetInt64(this GSettingsHandle settings, string key, long value)
	{
		return GSettingsExterns.g_settings_set_int64(settings, key, value);
	}

	public static bool SetString(this GSettingsHandle settings, string key, string value)
	{
		return GSettingsExterns.g_settings_set_string(settings, key, value);
	}

	public static bool SetStrv(this GSettingsHandle settings, string key, string value)
	{
		return GSettingsExterns.g_settings_set_strv(settings, key, value);
	}

	public static bool SetUint(this GSettingsHandle settings, string key, uint value)
	{
		return GSettingsExterns.g_settings_set_uint(settings, key, value);
	}

	public static bool SetUint64(this GSettingsHandle settings, string key, ulong value)
	{
		return GSettingsExterns.g_settings_set_uint64(settings, key, value);
	}

	public static bool SetValue(this GSettingsHandle settings, string key, GVariantHandle value)
	{
		return GSettingsExterns.g_settings_set_value(settings, key, value);
	}

	public static GSettingsHandle Connect(this GSettingsHandle instance, GSettingsSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GSettingsExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsHandle g_settings_new(string schema_id);
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsHandle g_settings_new_full(GSettingsSchemaHandle schema, GSettingsBackendHandle backend, string path);
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsHandle g_settings_new_with_backend(string schema_id, GSettingsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsHandle g_settings_new_with_backend_and_path(string schema_id, GSettingsBackendHandle backend, string path);
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsHandle g_settings_new_with_path(string schema_id, string path);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_apply(GSettingsHandle settings);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_bind(GSettingsHandle settings, string key, GObjectHandle @object, string property, GSettingsBindFlags flags);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_bind_with_mapping(GSettingsHandle settings, string key, GObjectHandle @object, string property, GSettingsBindFlags flags, GSettingsBindGetMapping get_mapping, GSettingsBindSetMapping set_mapping, IntPtr user_data, GDestroyNotify destroy);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_bind_writable(GSettingsHandle settings, string key, GObjectHandle @object, string property, bool inverted);
	[DllImport(Libraries.Gio)]
	internal static extern GActionHandle g_settings_create_action(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_delay(GSettingsHandle settings);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_get(GSettingsHandle settings, string key, string format, IntPtr @__arglist);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_get_boolean(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsHandle g_settings_get_child(GSettingsHandle settings, string name);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_settings_get_default_value(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern double g_settings_get_double(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern int g_settings_get_enum(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_settings_get_flags(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_get_has_unapplied(GSettingsHandle settings);
	[DllImport(Libraries.Gio)]
	internal static extern int g_settings_get_int(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern long g_settings_get_int64(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_settings_get_mapped(GSettingsHandle settings, string key, GSettingsGetMapping mapping, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_settings_get_range(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_get_string(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_settings_get_strv(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_settings_get_uint(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern ulong g_settings_get_uint64(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_settings_get_user_value(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_settings_get_value(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_is_writable(GSettingsHandle settings, string name);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_settings_list_children(GSettingsHandle settings);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_settings_list_keys(GSettingsHandle settings);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_range_check(GSettingsHandle settings, string key, GVariantHandle value);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_reset(GSettingsHandle settings, string key);
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_revert(GSettingsHandle settings);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set(GSettingsHandle settings, string key, string format, IntPtr @__arglist);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_boolean(GSettingsHandle settings, string key, bool value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_double(GSettingsHandle settings, string key, double value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_enum(GSettingsHandle settings, string key, int value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_flags(GSettingsHandle settings, string key, uint value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_int(GSettingsHandle settings, string key, int value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_int64(GSettingsHandle settings, string key, long value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_string(GSettingsHandle settings, string key, string value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_strv(GSettingsHandle settings, string key, string value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_uint(GSettingsHandle settings, string key, uint value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_uint64(GSettingsHandle settings, string key, ulong value);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_set_value(GSettingsHandle settings, string key, GVariantHandle value);
	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_list_relocatable_schemas();
	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_list_schemas();
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_sync();
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_unbind(GObjectHandle @object, string property);
}
