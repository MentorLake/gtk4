using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkApplicationExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_add_window")]
    internal static extern void gtk_application_add_window(this GtkApplicationHandle application, GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_remove_window")]
    internal static extern void gtk_application_remove_window(this GtkApplicationHandle application, GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_windows")]
    internal static extern GListHandle gtk_application_get_windows(this GtkApplicationHandle application);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_menubar")]
    internal static extern GMenuModelHandle gtk_application_get_menubar(this GtkApplicationHandle application);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_set_menubar")]
    internal static extern void gtk_application_set_menubar(this GtkApplicationHandle application, GMenuModelHandle menubar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_inhibit")]
    internal static extern uint gtk_application_inhibit(this GtkApplicationHandle application, GtkWindowHandle window, GtkApplicationInhibitFlags flags, string reason);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_uninhibit")]
    internal static extern void gtk_application_uninhibit(this GtkApplicationHandle application, uint cookie);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_window_by_id")]
    internal static extern GtkWindowHandle gtk_application_get_window_by_id(this GtkApplicationHandle application, uint id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_active_window")]
    internal static extern GtkWindowHandle gtk_application_get_active_window(this GtkApplicationHandle application);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_list_action_descriptions")]
    internal static extern string[] gtk_application_list_action_descriptions(this GtkApplicationHandle application);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_accels_for_action")]
    internal static extern string[] gtk_application_get_accels_for_action(this GtkApplicationHandle application, string detailed_action_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_actions_for_accel")]
    internal static extern string[] gtk_application_get_actions_for_accel(this GtkApplicationHandle application, string accel);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_set_accels_for_action")]
    internal static extern void gtk_application_set_accels_for_action(this GtkApplicationHandle application, string detailed_action_name, string accels);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_get_menu_by_id")]
    internal static extern GMenuHandle gtk_application_get_menu_by_id(this GtkApplicationHandle application, string id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_application_window_new")]
    internal static extern GtkWindowHandle gtk_application_window_new(this GtkApplicationHandle application);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkApplicationHandle gtk_application_new(string application_id, GApplicationFlags flags);
}
