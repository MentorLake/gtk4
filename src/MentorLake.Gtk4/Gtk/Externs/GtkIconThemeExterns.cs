using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIconThemeExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_display")]
    internal static extern GdkDisplayHandle gtk_icon_theme_get_display(this GtkIconThemeHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_set_search_path")]
    internal static extern void gtk_icon_theme_set_search_path(this GtkIconThemeHandle self, string path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_search_path")]
    internal static extern string[] gtk_icon_theme_get_search_path(this GtkIconThemeHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_add_search_path")]
    internal static extern void gtk_icon_theme_add_search_path(this GtkIconThemeHandle self, string path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_set_resource_path")]
    internal static extern void gtk_icon_theme_set_resource_path(this GtkIconThemeHandle self, string path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_resource_path")]
    internal static extern string[] gtk_icon_theme_get_resource_path(this GtkIconThemeHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_add_resource_path")]
    internal static extern void gtk_icon_theme_add_resource_path(this GtkIconThemeHandle self, string path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_set_theme_name")]
    internal static extern void gtk_icon_theme_set_theme_name(this GtkIconThemeHandle self, string theme_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_theme_name")]
    internal static extern string gtk_icon_theme_get_theme_name(this GtkIconThemeHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_has_icon")]
    internal static extern int gtk_icon_theme_has_icon(this GtkIconThemeHandle self, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_has_gicon")]
    internal static extern int gtk_icon_theme_has_gicon(this GtkIconThemeHandle self, GIconHandle gicon);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_icon_sizes")]
    internal static extern int[] gtk_icon_theme_get_icon_sizes(this GtkIconThemeHandle self, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_lookup_icon")]
    internal static extern GtkIconPaintableHandle gtk_icon_theme_lookup_icon(this GtkIconThemeHandle self, string icon_name, string[] fallbacks, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_lookup_by_gicon")]
    internal static extern GtkIconPaintableHandle gtk_icon_theme_lookup_by_gicon(this GtkIconThemeHandle self, GIconHandle icon, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_icon_names")]
    internal static extern string[] gtk_icon_theme_get_icon_names(this GtkIconThemeHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkIconThemeHandle gtk_icon_theme_new();
}
