using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCenterBoxExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_set_start_widget")]
    internal static extern void gtk_center_box_set_start_widget(this GtkCenterBoxHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_set_center_widget")]
    internal static extern void gtk_center_box_set_center_widget(this GtkCenterBoxHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_set_end_widget")]
    internal static extern void gtk_center_box_set_end_widget(this GtkCenterBoxHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_get_start_widget")]
    internal static extern GtkWidgetHandle gtk_center_box_get_start_widget(this GtkCenterBoxHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_get_center_widget")]
    internal static extern GtkWidgetHandle gtk_center_box_get_center_widget(this GtkCenterBoxHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_get_end_widget")]
    internal static extern GtkWidgetHandle gtk_center_box_get_end_widget(this GtkCenterBoxHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_set_baseline_position")]
    internal static extern void gtk_center_box_set_baseline_position(this GtkCenterBoxHandle self, GtkBaselinePosition position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_center_box_get_baseline_position")]
    internal static extern GtkBaselinePosition gtk_center_box_get_baseline_position(this GtkCenterBoxHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCenterBoxHandle gtk_center_box_new();
}
