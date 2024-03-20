using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkEventControllerScrollExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_scroll_set_flags")]
	internal static extern void gtk_event_controller_scroll_set_flags(this GtkEventControllerScrollHandle scroll, GtkEventControllerScrollFlags flags);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_scroll_get_flags")]
	internal static extern GtkEventControllerScrollFlags gtk_event_controller_scroll_get_flags(this GtkEventControllerScrollHandle scroll);
}
