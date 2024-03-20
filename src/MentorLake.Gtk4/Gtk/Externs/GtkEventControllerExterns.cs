using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEventControllerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_widget")]
    internal static extern GtkWidgetHandle gtk_event_controller_get_widget(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_reset")]
    internal static extern void gtk_event_controller_reset(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_propagation_phase")]
    internal static extern GtkPropagationPhase gtk_event_controller_get_propagation_phase(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_set_propagation_phase")]
    internal static extern void gtk_event_controller_set_propagation_phase(this GtkEventControllerHandle controller, GtkPropagationPhase phase);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_propagation_limit")]
    internal static extern GtkPropagationLimit gtk_event_controller_get_propagation_limit(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_set_propagation_limit")]
    internal static extern void gtk_event_controller_set_propagation_limit(this GtkEventControllerHandle controller, GtkPropagationLimit limit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_name")]
    internal static extern string gtk_event_controller_get_name(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_set_name")]
    internal static extern void gtk_event_controller_set_name(this GtkEventControllerHandle controller, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_current_event")]
    internal static extern GdkEventHandle gtk_event_controller_get_current_event(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_current_event_time")]
    internal static extern uint gtk_event_controller_get_current_event_time(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_current_event_device")]
    internal static extern GdkDeviceHandle gtk_event_controller_get_current_event_device(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_event_controller_get_current_event_state")]
    internal static extern GdkModifierType gtk_event_controller_get_current_event_state(this GtkEventControllerHandle controller);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_drop_controller_motion_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_event_controller_focus_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_event_controller_key_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_event_controller_legacy_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_event_controller_motion_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_event_controller_scroll_new(GtkEventControllerScrollFlags flags);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_shortcut_controller_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEventControllerHandle gtk_shortcut_controller_new_for_model(GListModelHandle model);
}
