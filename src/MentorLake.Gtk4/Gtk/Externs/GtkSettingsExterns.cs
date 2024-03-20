using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkSettingsExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_settings_reset_property")]
	internal static extern void gtk_settings_reset_property(this GtkSettingsHandle settings, string name);
}
