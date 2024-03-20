using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkApplicationWindowExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_application_window_set_show_menubar")]
	internal static extern void gtk_application_window_set_show_menubar(this GtkApplicationWindowHandle window, int show_menubar);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_application_window_get_show_menubar")]
	internal static extern int gtk_application_window_get_show_menubar(this GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_application_window_get_id")]
	internal static extern uint gtk_application_window_get_id(this GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_application_window_set_help_overlay")]
	internal static extern void gtk_application_window_set_help_overlay(this GtkApplicationWindowHandle window, GtkShortcutsWindowHandle help_overlay);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_application_window_get_help_overlay")]
	internal static extern GtkShortcutsWindowHandle gtk_application_window_get_help_overlay(this GtkApplicationWindowHandle window);
}
