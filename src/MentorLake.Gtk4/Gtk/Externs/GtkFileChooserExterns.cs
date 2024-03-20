using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkFileChooserExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_action")]
	internal static extern void gtk_file_chooser_set_action(this GtkFileChooserHandle chooser, GtkFileChooserAction action);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_action")]
	internal static extern GtkFileChooserAction gtk_file_chooser_get_action(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_select_multiple")]
	internal static extern void gtk_file_chooser_set_select_multiple(this GtkFileChooserHandle chooser, int select_multiple);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_select_multiple")]
	internal static extern int gtk_file_chooser_get_select_multiple(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_create_folders")]
	internal static extern void gtk_file_chooser_set_create_folders(this GtkFileChooserHandle chooser, int create_folders);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_create_folders")]
	internal static extern int gtk_file_chooser_get_create_folders(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_current_name")]
	internal static extern void gtk_file_chooser_set_current_name(this GtkFileChooserHandle chooser, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_current_name")]
	internal static extern string gtk_file_chooser_get_current_name(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_file")]
	internal static extern GFileHandle gtk_file_chooser_get_file(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_file")]
	internal static extern int gtk_file_chooser_set_file(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_files")]
	internal static extern GListModelHandle gtk_file_chooser_get_files(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_current_folder")]
	internal static extern int gtk_file_chooser_set_current_folder(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_current_folder")]
	internal static extern GFileHandle gtk_file_chooser_get_current_folder(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_add_filter")]
	internal static extern void gtk_file_chooser_add_filter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_remove_filter")]
	internal static extern void gtk_file_chooser_remove_filter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_filters")]
	internal static extern GListModelHandle gtk_file_chooser_get_filters(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_filter")]
	internal static extern void gtk_file_chooser_set_filter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_filter")]
	internal static extern GtkFileFilterHandle gtk_file_chooser_get_filter(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_add_shortcut_folder")]
	internal static extern int gtk_file_chooser_add_shortcut_folder(this GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_remove_shortcut_folder")]
	internal static extern int gtk_file_chooser_remove_shortcut_folder(this GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_shortcut_folders")]
	internal static extern GListModelHandle gtk_file_chooser_get_shortcut_folders(this GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_add_choice")]
	internal static extern void gtk_file_chooser_add_choice(this GtkFileChooserHandle chooser, string id, string label, string[] options, string[] option_labels);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_remove_choice")]
	internal static extern void gtk_file_chooser_remove_choice(this GtkFileChooserHandle chooser, string id);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_set_choice")]
	internal static extern void gtk_file_chooser_set_choice(this GtkFileChooserHandle chooser, string id, string option);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_get_choice")]
	internal static extern string gtk_file_chooser_get_choice(this GtkFileChooserHandle chooser, string id);
}
