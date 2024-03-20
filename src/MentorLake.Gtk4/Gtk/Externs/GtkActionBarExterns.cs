using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkActionBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_get_center_widget")]
    internal static extern GtkWidgetHandle gtk_action_bar_get_center_widget(this GtkActionBarHandle action_bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_set_center_widget")]
    internal static extern void gtk_action_bar_set_center_widget(this GtkActionBarHandle action_bar, GtkWidgetHandle center_widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_pack_start")]
    internal static extern void gtk_action_bar_pack_start(this GtkActionBarHandle action_bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_pack_end")]
    internal static extern void gtk_action_bar_pack_end(this GtkActionBarHandle action_bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_remove")]
    internal static extern void gtk_action_bar_remove(this GtkActionBarHandle action_bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_set_revealed")]
    internal static extern void gtk_action_bar_set_revealed(this GtkActionBarHandle action_bar, int revealed);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_action_bar_get_revealed")]
    internal static extern int gtk_action_bar_get_revealed(this GtkActionBarHandle action_bar);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkActionBarHandle gtk_action_bar_new();
}
