using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCssSectionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_ref")]
    internal static extern GtkCssSectionHandle gtk_css_section_ref(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_unref")]
    internal static extern void gtk_css_section_unref(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_print")]
    internal static extern void gtk_css_section_print(this GtkCssSectionHandle section, GStringHandle @string);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_to_string")]
    internal static extern string gtk_css_section_to_string(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_get_parent")]
    internal static extern GtkCssSectionHandle gtk_css_section_get_parent(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_get_file")]
    internal static extern GFileHandle gtk_css_section_get_file(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_get_start_location")]
    internal static extern GtkCssLocationHandle gtk_css_section_get_start_location(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_section_get_end_location")]
    internal static extern GtkCssLocationHandle gtk_css_section_get_end_location(this GtkCssSectionHandle section);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCssSectionHandle gtk_css_section_new(GFileHandle file, GtkCssLocationHandle start, GtkCssLocationHandle end);
}
