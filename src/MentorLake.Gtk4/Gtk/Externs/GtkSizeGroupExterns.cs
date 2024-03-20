using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSizeGroupExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_size_group_set_mode")]
    internal static extern void gtk_size_group_set_mode(this GtkSizeGroupHandle size_group, GtkSizeGroupMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_size_group_get_mode")]
    internal static extern GtkSizeGroupMode gtk_size_group_get_mode(this GtkSizeGroupHandle size_group);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_size_group_add_widget")]
    internal static extern void gtk_size_group_add_widget(this GtkSizeGroupHandle size_group, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_size_group_remove_widget")]
    internal static extern void gtk_size_group_remove_widget(this GtkSizeGroupHandle size_group, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_size_group_get_widgets")]
    internal static extern GSListHandle gtk_size_group_get_widgets(this GtkSizeGroupHandle size_group);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSizeGroupHandle gtk_size_group_new(GtkSizeGroupMode mode);
}
