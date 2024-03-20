using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBoxExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_set_homogeneous")]
    internal static extern void gtk_box_set_homogeneous(this GtkBoxHandle box, int homogeneous);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_get_homogeneous")]
    internal static extern int gtk_box_get_homogeneous(this GtkBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_set_spacing")]
    internal static extern void gtk_box_set_spacing(this GtkBoxHandle box, int spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_get_spacing")]
    internal static extern int gtk_box_get_spacing(this GtkBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_set_baseline_position")]
    internal static extern void gtk_box_set_baseline_position(this GtkBoxHandle box, GtkBaselinePosition position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_get_baseline_position")]
    internal static extern GtkBaselinePosition gtk_box_get_baseline_position(this GtkBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_append")]
    internal static extern void gtk_box_append(this GtkBoxHandle box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_prepend")]
    internal static extern void gtk_box_prepend(this GtkBoxHandle box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_remove")]
    internal static extern void gtk_box_remove(this GtkBoxHandle box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_insert_child_after")]
    internal static extern void gtk_box_insert_child_after(this GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_box_reorder_child_after")]
    internal static extern void gtk_box_reorder_child_after(this GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBoxHandle gtk_box_new(GtkOrientation orientation, int spacing);
}
