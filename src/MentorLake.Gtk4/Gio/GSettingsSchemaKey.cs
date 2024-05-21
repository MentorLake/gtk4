namespace MentorLake.Gtk4.Gio;

public class GSettingsSchemaKeyHandle : BaseSafeHandle
{
}


public static class GSettingsSchemaKeyHandleExtensions
{
	public static GVariantHandle GetDefaultValue(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_default_value(key);
	}

	public static string GetDescription(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_description(key);
	}

	public static string GetName(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_name(key);
	}

	public static GVariantHandle GetRange(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_range(key);
	}

	public static string GetSummary(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_summary(key);
	}

	public static GVariantTypeHandle GetValueType(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_value_type(key);
	}

	public static bool RangeCheck(this GSettingsSchemaKeyHandle key, GVariantHandle value)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_range_check(key, value);
	}

	public static GSettingsSchemaKeyHandle Ref(this GSettingsSchemaKeyHandle key)
	{
		return GSettingsSchemaKeyExterns.g_settings_schema_key_ref(key);
	}

	public static GSettingsSchemaKeyHandle Unref(this GSettingsSchemaKeyHandle key)
	{
		GSettingsSchemaKeyExterns.g_settings_schema_key_unref(key);
		return key;
	}

}
internal class GSettingsSchemaKeyExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_settings_schema_key_get_default_value(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_schema_key_get_description(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_schema_key_get_name(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_settings_schema_key_get_range(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_schema_key_get_summary(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_settings_schema_key_get_value_type(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_schema_key_range_check(GSettingsSchemaKeyHandle key, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaKeyHandle g_settings_schema_key_ref(GSettingsSchemaKeyHandle key);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_schema_key_unref(GSettingsSchemaKeyHandle key);

}

public struct GSettingsSchemaKey
{
}
