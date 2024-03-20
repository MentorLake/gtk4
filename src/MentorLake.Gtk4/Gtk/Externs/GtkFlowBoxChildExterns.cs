using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFlowBoxChildExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_child_set_child")]
    internal static extern void gtk_flow_box_child_set_child(this GtkFlowBoxChildHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_child_get_child")]
    internal static extern GtkWidgetHandle gtk_flow_box_child_get_child(this GtkFlowBoxChildHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_child_get_index")]
    internal static extern int gtk_flow_box_child_get_index(this GtkFlowBoxChildHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_child_is_selected")]
    internal static extern int gtk_flow_box_child_is_selected(this GtkFlowBoxChildHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_child_changed")]
    internal static extern void gtk_flow_box_child_changed(this GtkFlowBoxChildHandle child);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFlowBoxChildHandle gtk_flow_box_child_new();
}
