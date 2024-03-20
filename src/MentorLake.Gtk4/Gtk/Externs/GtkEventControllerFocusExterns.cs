using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkEventControllerFocusExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_focus_contains_focus")]
	internal static extern int gtk_event_controller_focus_contains_focus(this GtkEventControllerFocusHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_focus_is_focus")]
	internal static extern int gtk_event_controller_focus_is_focus(this GtkEventControllerFocusHandle self);
}
