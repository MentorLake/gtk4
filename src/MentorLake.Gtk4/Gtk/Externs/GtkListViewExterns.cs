using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkListViewExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_get_model")]
	internal static extern GtkSelectionModelHandle gtk_list_view_get_model(this GtkListViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_set_model")]
	internal static extern void gtk_list_view_set_model(this GtkListViewHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_set_factory")]
	internal static extern void gtk_list_view_set_factory(this GtkListViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_get_factory")]
	internal static extern GtkListItemFactoryHandle gtk_list_view_get_factory(this GtkListViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_set_show_separators")]
	internal static extern void gtk_list_view_set_show_separators(this GtkListViewHandle self, int show_separators);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_get_show_separators")]
	internal static extern int gtk_list_view_get_show_separators(this GtkListViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_set_single_click_activate")]
	internal static extern void gtk_list_view_set_single_click_activate(this GtkListViewHandle self, int single_click_activate);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_get_single_click_activate")]
	internal static extern int gtk_list_view_get_single_click_activate(this GtkListViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_set_enable_rubberband")]
	internal static extern void gtk_list_view_set_enable_rubberband(this GtkListViewHandle self, int enable_rubberband);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_get_enable_rubberband")]
	internal static extern int gtk_list_view_get_enable_rubberband(this GtkListViewHandle self);
}
