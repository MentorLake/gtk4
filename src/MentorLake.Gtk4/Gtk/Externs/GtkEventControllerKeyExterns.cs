using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkEventControllerKeyExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_key_set_im_context")]
	internal static extern void gtk_event_controller_key_set_im_context(this GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_key_get_im_context")]
	internal static extern GtkIMContextHandle gtk_event_controller_key_get_im_context(this GtkEventControllerKeyHandle controller);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_key_forward")]
	internal static extern int gtk_event_controller_key_forward(this GtkEventControllerKeyHandle controller, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_key_get_group")]
	internal static extern uint gtk_event_controller_key_get_group(this GtkEventControllerKeyHandle controller);
}
