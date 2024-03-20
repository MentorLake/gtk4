using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkViewportExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_viewport_get_scroll_to_focus")]
	internal static extern int gtk_viewport_get_scroll_to_focus(this GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_viewport_set_scroll_to_focus")]
	internal static extern void gtk_viewport_set_scroll_to_focus(this GtkViewportHandle viewport, int scroll_to_focus);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_viewport_set_child")]
	internal static extern void gtk_viewport_set_child(this GtkViewportHandle viewport, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_viewport_get_child")]
	internal static extern GtkWidgetHandle gtk_viewport_get_child(this GtkViewportHandle viewport);
}
