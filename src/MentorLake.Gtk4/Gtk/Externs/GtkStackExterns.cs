using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_add_child")]
    internal static extern GtkStackPageHandle gtk_stack_add_child(this GtkStackHandle stack, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_add_named")]
    internal static extern GtkStackPageHandle gtk_stack_add_named(this GtkStackHandle stack, GtkWidgetHandle child, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_add_titled")]
    internal static extern GtkStackPageHandle gtk_stack_add_titled(this GtkStackHandle stack, GtkWidgetHandle child, string name, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_remove")]
    internal static extern void gtk_stack_remove(this GtkStackHandle stack, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_page")]
    internal static extern GtkStackPageHandle gtk_stack_get_page(this GtkStackHandle stack, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_child_by_name")]
    internal static extern GtkWidgetHandle gtk_stack_get_child_by_name(this GtkStackHandle stack, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_visible_child")]
    internal static extern void gtk_stack_set_visible_child(this GtkStackHandle stack, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_visible_child")]
    internal static extern GtkWidgetHandle gtk_stack_get_visible_child(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_visible_child_name")]
    internal static extern void gtk_stack_set_visible_child_name(this GtkStackHandle stack, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_visible_child_name")]
    internal static extern string gtk_stack_get_visible_child_name(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_visible_child_full")]
    internal static extern void gtk_stack_set_visible_child_full(this GtkStackHandle stack, string name, GtkStackTransitionType transition);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_hhomogeneous")]
    internal static extern void gtk_stack_set_hhomogeneous(this GtkStackHandle stack, int hhomogeneous);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_hhomogeneous")]
    internal static extern int gtk_stack_get_hhomogeneous(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_vhomogeneous")]
    internal static extern void gtk_stack_set_vhomogeneous(this GtkStackHandle stack, int vhomogeneous);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_vhomogeneous")]
    internal static extern int gtk_stack_get_vhomogeneous(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_transition_duration")]
    internal static extern void gtk_stack_set_transition_duration(this GtkStackHandle stack, uint duration);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_transition_duration")]
    internal static extern uint gtk_stack_get_transition_duration(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_transition_type")]
    internal static extern void gtk_stack_set_transition_type(this GtkStackHandle stack, GtkStackTransitionType transition);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_transition_type")]
    internal static extern GtkStackTransitionType gtk_stack_get_transition_type(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_transition_running")]
    internal static extern int gtk_stack_get_transition_running(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_set_interpolate_size")]
    internal static extern void gtk_stack_set_interpolate_size(this GtkStackHandle stack, int interpolate_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_interpolate_size")]
    internal static extern int gtk_stack_get_interpolate_size(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_get_pages")]
    internal static extern GtkSelectionModelHandle gtk_stack_get_pages(this GtkStackHandle stack);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkStackHandle gtk_stack_new();
}
