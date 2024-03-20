using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropDownExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_model")]
    internal static extern void gtk_drop_down_set_model(this GtkDropDownHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_model")]
    internal static extern GListModelHandle gtk_drop_down_get_model(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_selected")]
    internal static extern void gtk_drop_down_set_selected(this GtkDropDownHandle self, uint position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_selected")]
    internal static extern uint gtk_drop_down_get_selected(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_selected_item")]
    internal static extern IntPtr gtk_drop_down_get_selected_item(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_factory")]
    internal static extern void gtk_drop_down_set_factory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_factory")]
    internal static extern GtkListItemFactoryHandle gtk_drop_down_get_factory(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_list_factory")]
    internal static extern void gtk_drop_down_set_list_factory(this GtkDropDownHandle self, GtkListItemFactoryHandle factory);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_list_factory")]
    internal static extern GtkListItemFactoryHandle gtk_drop_down_get_list_factory(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_expression")]
    internal static extern void gtk_drop_down_set_expression(this GtkDropDownHandle self, GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_expression")]
    internal static extern GtkExpressionHandle gtk_drop_down_get_expression(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_enable_search")]
    internal static extern void gtk_drop_down_set_enable_search(this GtkDropDownHandle self, int enable_search);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_enable_search")]
    internal static extern int gtk_drop_down_get_enable_search(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_set_show_arrow")]
    internal static extern void gtk_drop_down_set_show_arrow(this GtkDropDownHandle self, int show_arrow);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_down_get_show_arrow")]
    internal static extern int gtk_drop_down_get_show_arrow(this GtkDropDownHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDropDownHandle gtk_drop_down_new(GListModelHandle model, GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDropDownHandle gtk_drop_down_new_from_strings(string strings);
}
