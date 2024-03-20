using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkNativeDialogExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_show")]
	internal static extern void gtk_native_dialog_show(this GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_hide")]
	internal static extern void gtk_native_dialog_hide(this GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_destroy")]
	internal static extern void gtk_native_dialog_destroy(this GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_get_visible")]
	internal static extern int gtk_native_dialog_get_visible(this GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_set_modal")]
	internal static extern void gtk_native_dialog_set_modal(this GtkNativeDialogHandle self, int modal);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_get_modal")]
	internal static extern int gtk_native_dialog_get_modal(this GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_set_title")]
	internal static extern void gtk_native_dialog_set_title(this GtkNativeDialogHandle self, string title);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_get_title")]
	internal static extern string gtk_native_dialog_get_title(this GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_set_transient_for")]
	internal static extern void gtk_native_dialog_set_transient_for(this GtkNativeDialogHandle self, GtkWindowHandle parent);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_dialog_get_transient_for")]
	internal static extern GtkWindowHandle gtk_native_dialog_get_transient_for(this GtkNativeDialogHandle self);
}
