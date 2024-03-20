using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFileFilterExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_set_name")]
    internal static extern void gtk_file_filter_set_name(this GtkFileFilterHandle filter, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_get_name")]
    internal static extern string gtk_file_filter_get_name(this GtkFileFilterHandle filter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_add_mime_type")]
    internal static extern void gtk_file_filter_add_mime_type(this GtkFileFilterHandle filter, string mime_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_add_pattern")]
    internal static extern void gtk_file_filter_add_pattern(this GtkFileFilterHandle filter, string pattern);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_add_suffix")]
    internal static extern void gtk_file_filter_add_suffix(this GtkFileFilterHandle filter, string suffix);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_add_pixbuf_formats")]
    internal static extern void gtk_file_filter_add_pixbuf_formats(this GtkFileFilterHandle filter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_get_attributes")]
    internal static extern string[] gtk_file_filter_get_attributes(this GtkFileFilterHandle filter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_filter_to_gvariant")]
    internal static extern GVariantHandle gtk_file_filter_to_gvariant(this GtkFileFilterHandle filter);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFileFilterHandle gtk_file_filter_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFileFilterHandle gtk_file_filter_new_from_gvariant(GVariantHandle variant);
}
