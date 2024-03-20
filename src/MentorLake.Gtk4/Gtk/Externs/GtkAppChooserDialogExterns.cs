using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkAppChooserDialogExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_dialog_get_widget")]
	internal static extern GtkWidgetHandle gtk_app_chooser_dialog_get_widget(this GtkAppChooserDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_dialog_set_heading")]
	internal static extern void gtk_app_chooser_dialog_set_heading(this GtkAppChooserDialogHandle self, string heading);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_dialog_get_heading")]
	internal static extern string gtk_app_chooser_dialog_get_heading(this GtkAppChooserDialogHandle self);
}
