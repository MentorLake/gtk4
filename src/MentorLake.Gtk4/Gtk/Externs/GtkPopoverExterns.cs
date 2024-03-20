using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPopoverExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_child")]
    internal static extern void gtk_popover_set_child(this GtkPopoverHandle popover, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_child")]
    internal static extern GtkWidgetHandle gtk_popover_get_child(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_pointing_to")]
    internal static extern void gtk_popover_set_pointing_to(this GtkPopoverHandle popover, GdkRectangleHandle rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_pointing_to")]
    internal static extern int gtk_popover_get_pointing_to(this GtkPopoverHandle popover, GdkRectangleHandle rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_position")]
    internal static extern void gtk_popover_set_position(this GtkPopoverHandle popover, GtkPositionType position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_position")]
    internal static extern GtkPositionType gtk_popover_get_position(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_autohide")]
    internal static extern void gtk_popover_set_autohide(this GtkPopoverHandle popover, int autohide);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_autohide")]
    internal static extern int gtk_popover_get_autohide(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_has_arrow")]
    internal static extern void gtk_popover_set_has_arrow(this GtkPopoverHandle popover, int has_arrow);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_has_arrow")]
    internal static extern int gtk_popover_get_has_arrow(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_mnemonics_visible")]
    internal static extern void gtk_popover_set_mnemonics_visible(this GtkPopoverHandle popover, int mnemonics_visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_mnemonics_visible")]
    internal static extern int gtk_popover_get_mnemonics_visible(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_popup")]
    internal static extern void gtk_popover_popup(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_popdown")]
    internal static extern void gtk_popover_popdown(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_offset")]
    internal static extern void gtk_popover_set_offset(this GtkPopoverHandle popover, int x_offset, int y_offset);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_offset")]
    internal static extern void gtk_popover_get_offset(this GtkPopoverHandle popover, out int x_offset, out int y_offset);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_cascade_popdown")]
    internal static extern void gtk_popover_set_cascade_popdown(this GtkPopoverHandle popover, int cascade_popdown);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_get_cascade_popdown")]
    internal static extern int gtk_popover_get_cascade_popdown(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_set_default_widget")]
    internal static extern void gtk_popover_set_default_widget(this GtkPopoverHandle popover, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_popover_present")]
    internal static extern void gtk_popover_present(this GtkPopoverHandle popover);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPopoverHandle gtk_popover_new();
}
