namespace MentorLake.Gtk4.Gtk4;

public class GtkSettingsHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static GtkSettingsHandle GetDefault()
	{
		return GtkSettingsExterns.gtk_settings_get_default();
	}

	public static GtkSettingsHandle GetForDisplay(GdkDisplayHandle display)
	{
		return GtkSettingsExterns.gtk_settings_get_for_display(display);
	}

}

public static class GtkSettingsHandleExtensions
{
	public static GtkSettingsHandle ResetProperty(this GtkSettingsHandle settings, string name)
	{
		GtkSettingsExterns.gtk_settings_reset_property(settings, name);
		return settings;
	}

}

internal class GtkSettingsExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_settings_reset_property(GtkSettingsHandle settings, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSettingsHandle gtk_settings_get_default();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSettingsHandle gtk_settings_get_for_display(GdkDisplayHandle display);

}
