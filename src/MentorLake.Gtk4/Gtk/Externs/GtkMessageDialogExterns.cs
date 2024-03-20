using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkMessageDialogExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_message_dialog_set_markup")]
	internal static extern void gtk_message_dialog_set_markup(this GtkMessageDialogHandle message_dialog, string str);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_message_dialog_format_secondary_text")]
	internal static extern void gtk_message_dialog_format_secondary_text(this GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_message_dialog_format_secondary_markup")]
	internal static extern void gtk_message_dialog_format_secondary_markup(this GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_message_dialog_get_message_area")]
	internal static extern GtkWidgetHandle gtk_message_dialog_get_message_area(this GtkMessageDialogHandle message_dialog);
}
