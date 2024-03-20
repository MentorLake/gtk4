using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPopoverMenuBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_bar_set_menu_model")]
    internal static extern void gtk_popover_menu_bar_set_menu_model(this GtkPopoverMenuBarHandle bar, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_bar_get_menu_model")]
    internal static extern GMenuModelHandle gtk_popover_menu_bar_get_menu_model(this GtkPopoverMenuBarHandle bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_bar_add_child")]
    internal static extern int gtk_popover_menu_bar_add_child(this GtkPopoverMenuBarHandle bar, GtkWidgetHandle child, string id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_bar_remove_child")]
    internal static extern int gtk_popover_menu_bar_remove_child(this GtkPopoverMenuBarHandle bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPopoverMenuBarHandle gtk_popover_menu_bar_new_from_model(GMenuModelHandle model);
}
