using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCustomFilterExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_custom_filter_set_filter_func")]
    internal static extern void gtk_custom_filter_set_filter_func(this GtkCustomFilterHandle self, GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCustomFilterHandle gtk_custom_filter_new(GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy);
}
