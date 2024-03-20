using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gsk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFixedExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_put")]
    internal static extern void gtk_fixed_put(this GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_remove")]
    internal static extern void gtk_fixed_remove(this GtkFixedHandle @fixed, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_move")]
    internal static extern void gtk_fixed_move(this GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_get_child_position")]
    internal static extern void gtk_fixed_get_child_position(this GtkFixedHandle @fixed, GtkWidgetHandle widget, out double x, out double y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_set_child_transform")]
    internal static extern void gtk_fixed_set_child_transform(this GtkFixedHandle @fixed, GtkWidgetHandle widget, GskTransformHandle transform);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_get_child_transform")]
    internal static extern GskTransformHandle gtk_fixed_get_child_transform(this GtkFixedHandle @fixed, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFixedHandle gtk_fixed_new();
}
