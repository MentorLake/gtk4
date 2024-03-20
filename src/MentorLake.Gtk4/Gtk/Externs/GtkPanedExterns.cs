using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPanedExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_start_child")]
    internal static extern void gtk_paned_set_start_child(this GtkPanedHandle paned, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_start_child")]
    internal static extern GtkWidgetHandle gtk_paned_get_start_child(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_resize_start_child")]
    internal static extern void gtk_paned_set_resize_start_child(this GtkPanedHandle paned, int resize);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_resize_start_child")]
    internal static extern int gtk_paned_get_resize_start_child(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_end_child")]
    internal static extern void gtk_paned_set_end_child(this GtkPanedHandle paned, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_end_child")]
    internal static extern GtkWidgetHandle gtk_paned_get_end_child(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_shrink_start_child")]
    internal static extern void gtk_paned_set_shrink_start_child(this GtkPanedHandle paned, int resize);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_shrink_start_child")]
    internal static extern int gtk_paned_get_shrink_start_child(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_resize_end_child")]
    internal static extern void gtk_paned_set_resize_end_child(this GtkPanedHandle paned, int resize);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_resize_end_child")]
    internal static extern int gtk_paned_get_resize_end_child(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_shrink_end_child")]
    internal static extern void gtk_paned_set_shrink_end_child(this GtkPanedHandle paned, int resize);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_shrink_end_child")]
    internal static extern int gtk_paned_get_shrink_end_child(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_position")]
    internal static extern int gtk_paned_get_position(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_position")]
    internal static extern void gtk_paned_set_position(this GtkPanedHandle paned, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_set_wide_handle")]
    internal static extern void gtk_paned_set_wide_handle(this GtkPanedHandle paned, int wide);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paned_get_wide_handle")]
    internal static extern int gtk_paned_get_wide_handle(this GtkPanedHandle paned);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPanedHandle gtk_paned_new(GtkOrientation orientation);
}
