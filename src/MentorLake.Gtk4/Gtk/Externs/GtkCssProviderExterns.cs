using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCssProviderExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_provider_to_string")]
    internal static extern string gtk_css_provider_to_string(this GtkCssProviderHandle provider);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_provider_load_from_data")]
    internal static extern void gtk_css_provider_load_from_data(this GtkCssProviderHandle css_provider, string data, nint length);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_provider_load_from_file")]
    internal static extern void gtk_css_provider_load_from_file(this GtkCssProviderHandle css_provider, GFileHandle file);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_provider_load_from_path")]
    internal static extern void gtk_css_provider_load_from_path(this GtkCssProviderHandle css_provider, string path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_provider_load_from_resource")]
    internal static extern void gtk_css_provider_load_from_resource(this GtkCssProviderHandle css_provider, string resource_path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_css_provider_load_named")]
    internal static extern void gtk_css_provider_load_named(this GtkCssProviderHandle provider, string name, string variant);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCssProviderHandle gtk_css_provider_new();
}
