using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCustomSorterExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_custom_sorter_set_sort_func")]
    internal static extern void gtk_custom_sorter_set_sort_func(this GtkCustomSorterHandle self, GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCustomSorterHandle gtk_custom_sorter_new(GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy);
}
