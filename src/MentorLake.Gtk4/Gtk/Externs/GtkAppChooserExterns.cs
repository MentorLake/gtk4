using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;

public static class GtkAppChooserExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_get_app_info")]
	internal static extern GAppInfoHandle gtk_app_chooser_get_app_info(this GtkAppChooserHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_get_content_type")]
	internal static extern string gtk_app_chooser_get_content_type(this GtkAppChooserHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_refresh")]
	internal static extern void gtk_app_chooser_refresh(this GtkAppChooserHandle self);
}
