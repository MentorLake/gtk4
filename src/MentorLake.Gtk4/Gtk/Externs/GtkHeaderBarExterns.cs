using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkHeaderBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_set_title_widget")]
    internal static extern void gtk_header_bar_set_title_widget(this GtkHeaderBarHandle bar, GtkWidgetHandle title_widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_get_title_widget")]
    internal static extern GtkWidgetHandle gtk_header_bar_get_title_widget(this GtkHeaderBarHandle bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_pack_start")]
    internal static extern void gtk_header_bar_pack_start(this GtkHeaderBarHandle bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_pack_end")]
    internal static extern void gtk_header_bar_pack_end(this GtkHeaderBarHandle bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_remove")]
    internal static extern void gtk_header_bar_remove(this GtkHeaderBarHandle bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_get_show_title_buttons")]
    internal static extern int gtk_header_bar_get_show_title_buttons(this GtkHeaderBarHandle bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_set_show_title_buttons")]
    internal static extern void gtk_header_bar_set_show_title_buttons(this GtkHeaderBarHandle bar, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_set_decoration_layout")]
    internal static extern void gtk_header_bar_set_decoration_layout(this GtkHeaderBarHandle bar, string layout);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_header_bar_get_decoration_layout")]
    internal static extern string gtk_header_bar_get_decoration_layout(this GtkHeaderBarHandle bar);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkHeaderBarHandle gtk_header_bar_new();
}
