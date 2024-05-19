namespace MentorLake.Gtk4.Gio;

public class GSettingsSchemaSourceHandle : BaseSafeHandle
{
	public static GSettingsSchemaSourceHandle NewFromDirectory(string directory, GSettingsSchemaSourceHandle parent, bool trusted, out GErrorHandle error)
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_new_from_directory(directory, parent, trusted, out error);
	}

}

internal class GSettingsSchemaSourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaSourceHandle g_settings_schema_source_new_from_directory(string directory, GSettingsSchemaSourceHandle parent, bool trusted, out GErrorHandle error);

}

public struct GSettingsSchemaSource
{
}
