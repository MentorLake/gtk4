using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPopoverMenuExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_set_menu_model")]
    internal static extern void gtk_popover_menu_set_menu_model(this GtkPopoverMenuHandle popover, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_get_menu_model")]
    internal static extern GMenuModelHandle gtk_popover_menu_get_menu_model(this GtkPopoverMenuHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_add_child")]
    internal static extern int gtk_popover_menu_add_child(this GtkPopoverMenuHandle popover, GtkWidgetHandle child, string id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_menu_remove_child")]
    internal static extern int gtk_popover_menu_remove_child(this GtkPopoverMenuHandle popover, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPopoverMenuHandle gtk_popover_menu_new_from_model(GMenuModelHandle model);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPopoverMenuHandle gtk_popover_menu_new_from_model_full(GMenuModelHandle model, GtkPopoverMenuFlags flags);
}
