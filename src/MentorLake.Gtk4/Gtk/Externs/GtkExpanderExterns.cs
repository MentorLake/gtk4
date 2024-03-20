using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkExpanderExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_expanded")]
    internal static extern void gtk_expander_set_expanded(this GtkExpanderHandle expander, int expanded);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_expanded")]
    internal static extern int gtk_expander_get_expanded(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_label")]
    internal static extern void gtk_expander_set_label(this GtkExpanderHandle expander, string label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_label")]
    internal static extern string gtk_expander_get_label(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_use_underline")]
    internal static extern void gtk_expander_set_use_underline(this GtkExpanderHandle expander, int use_underline);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_use_underline")]
    internal static extern int gtk_expander_get_use_underline(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_use_markup")]
    internal static extern void gtk_expander_set_use_markup(this GtkExpanderHandle expander, int use_markup);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_use_markup")]
    internal static extern int gtk_expander_get_use_markup(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_label_widget")]
    internal static extern void gtk_expander_set_label_widget(this GtkExpanderHandle expander, GtkWidgetHandle label_widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_label_widget")]
    internal static extern GtkWidgetHandle gtk_expander_get_label_widget(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_resize_toplevel")]
    internal static extern void gtk_expander_set_resize_toplevel(this GtkExpanderHandle expander, int resize_toplevel);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_resize_toplevel")]
    internal static extern int gtk_expander_get_resize_toplevel(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_set_child")]
    internal static extern void gtk_expander_set_child(this GtkExpanderHandle expander, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expander_get_child")]
    internal static extern GtkWidgetHandle gtk_expander_get_child(this GtkExpanderHandle expander);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpanderHandle gtk_expander_new(string label);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpanderHandle gtk_expander_new_with_mnemonic(string label);
}
