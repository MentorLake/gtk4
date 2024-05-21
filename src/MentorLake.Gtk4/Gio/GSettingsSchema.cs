namespace MentorLake.Gtk4.Gio;

public class GSettingsSchemaHandle : BaseSafeHandle
{
}


public static class GSettingsSchemaHandleExtensions
{
	public static string GetId(this GSettingsSchemaHandle schema)
	{
		return GSettingsSchemaExterns.g_settings_schema_get_id(schema);
	}

	public static GSettingsSchemaKeyHandle GetKey(this GSettingsSchemaHandle schema, string name)
	{
		return GSettingsSchemaExterns.g_settings_schema_get_key(schema, name);
	}

	public static string GetPath(this GSettingsSchemaHandle schema)
	{
		return GSettingsSchemaExterns.g_settings_schema_get_path(schema);
	}

	public static bool HasKey(this GSettingsSchemaHandle schema, string name)
	{
		return GSettingsSchemaExterns.g_settings_schema_has_key(schema, name);
	}

	public static IntPtr ListChildren(this GSettingsSchemaHandle schema)
	{
		return GSettingsSchemaExterns.g_settings_schema_list_children(schema);
	}

	public static IntPtr ListKeys(this GSettingsSchemaHandle schema)
	{
		return GSettingsSchemaExterns.g_settings_schema_list_keys(schema);
	}

	public static GSettingsSchemaHandle Ref(this GSettingsSchemaHandle schema)
	{
		return GSettingsSchemaExterns.g_settings_schema_ref(schema);
	}

	public static GSettingsSchemaHandle Unref(this GSettingsSchemaHandle schema)
	{
		GSettingsSchemaExterns.g_settings_schema_unref(schema);
		return schema;
	}

}
internal class GSettingsSchemaExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_schema_get_id(GSettingsSchemaHandle schema);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaKeyHandle g_settings_schema_get_key(GSettingsSchemaHandle schema, string name);

	[DllImport(Libraries.Gio)]
	internal static extern string g_settings_schema_get_path(GSettingsSchemaHandle schema);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_settings_schema_has_key(GSettingsSchemaHandle schema, string name);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_settings_schema_list_children(GSettingsSchemaHandle schema);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_settings_schema_list_keys(GSettingsSchemaHandle schema);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaHandle g_settings_schema_ref(GSettingsSchemaHandle schema);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_schema_unref(GSettingsSchemaHandle schema);

}

public struct GSettingsSchema
{
}
