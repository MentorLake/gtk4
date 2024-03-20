using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLevelBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_set_mode")]
    internal static extern void gtk_level_bar_set_mode(this GtkLevelBarHandle self, GtkLevelBarMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_get_mode")]
    internal static extern GtkLevelBarMode gtk_level_bar_get_mode(this GtkLevelBarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_set_value")]
    internal static extern void gtk_level_bar_set_value(this GtkLevelBarHandle self, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_get_value")]
    internal static extern double gtk_level_bar_get_value(this GtkLevelBarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_set_min_value")]
    internal static extern void gtk_level_bar_set_min_value(this GtkLevelBarHandle self, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_get_min_value")]
    internal static extern double gtk_level_bar_get_min_value(this GtkLevelBarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_set_max_value")]
    internal static extern void gtk_level_bar_set_max_value(this GtkLevelBarHandle self, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_get_max_value")]
    internal static extern double gtk_level_bar_get_max_value(this GtkLevelBarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_set_inverted")]
    internal static extern void gtk_level_bar_set_inverted(this GtkLevelBarHandle self, int inverted);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_get_inverted")]
    internal static extern int gtk_level_bar_get_inverted(this GtkLevelBarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_add_offset_value")]
    internal static extern void gtk_level_bar_add_offset_value(this GtkLevelBarHandle self, string name, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_remove_offset_value")]
    internal static extern void gtk_level_bar_remove_offset_value(this GtkLevelBarHandle self, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_level_bar_get_offset_value")]
    internal static extern int gtk_level_bar_get_offset_value(this GtkLevelBarHandle self, string name, out double value);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLevelBarHandle gtk_level_bar_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLevelBarHandle gtk_level_bar_new_for_interval(double min_value, double max_value);
}
