using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMenuButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_popover")]
    internal static extern void gtk_menu_button_set_popover(this GtkMenuButtonHandle menu_button, GtkWidgetHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_popover")]
    internal static extern GtkPopoverHandle gtk_menu_button_get_popover(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_direction")]
    internal static extern void gtk_menu_button_set_direction(this GtkMenuButtonHandle menu_button, GtkArrowType direction);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_direction")]
    internal static extern GtkArrowType gtk_menu_button_get_direction(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_menu_model")]
    internal static extern void gtk_menu_button_set_menu_model(this GtkMenuButtonHandle menu_button, GMenuModelHandle menu_model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_menu_model")]
    internal static extern GMenuModelHandle gtk_menu_button_get_menu_model(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_icon_name")]
    internal static extern void gtk_menu_button_set_icon_name(this GtkMenuButtonHandle menu_button, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_icon_name")]
    internal static extern string gtk_menu_button_get_icon_name(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_always_show_arrow")]
    internal static extern void gtk_menu_button_set_always_show_arrow(this GtkMenuButtonHandle menu_button, int always_show_arrow);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_always_show_arrow")]
    internal static extern int gtk_menu_button_get_always_show_arrow(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_label")]
    internal static extern void gtk_menu_button_set_label(this GtkMenuButtonHandle menu_button, string label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_label")]
    internal static extern string gtk_menu_button_get_label(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_use_underline")]
    internal static extern void gtk_menu_button_set_use_underline(this GtkMenuButtonHandle menu_button, int use_underline);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_use_underline")]
    internal static extern int gtk_menu_button_get_use_underline(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_has_frame")]
    internal static extern void gtk_menu_button_set_has_frame(this GtkMenuButtonHandle menu_button, int has_frame);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_has_frame")]
    internal static extern int gtk_menu_button_get_has_frame(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_popup")]
    internal static extern void gtk_menu_button_popup(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_popdown")]
    internal static extern void gtk_menu_button_popdown(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_create_popup_func")]
    internal static extern void gtk_menu_button_set_create_popup_func(this GtkMenuButtonHandle menu_button, GtkMenuButtonCreatePopupFunc func, IntPtr user_data, GDestroyNotify destroy_notify);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_primary")]
    internal static extern void gtk_menu_button_set_primary(this GtkMenuButtonHandle menu_button, int primary);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_primary")]
    internal static extern int gtk_menu_button_get_primary(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_set_child")]
    internal static extern void gtk_menu_button_set_child(this GtkMenuButtonHandle menu_button, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_menu_button_get_child")]
    internal static extern GtkWidgetHandle gtk_menu_button_get_child(this GtkMenuButtonHandle menu_button);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMenuButtonHandle gtk_menu_button_new();
}
