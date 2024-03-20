using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMultiSorterExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_multi_sorter_append")]
    internal static extern void gtk_multi_sorter_append(this GtkMultiSorterHandle self, GtkSorterHandle sorter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_multi_sorter_remove")]
    internal static extern void gtk_multi_sorter_remove(this GtkMultiSorterHandle self, uint position);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMultiSorterHandle gtk_multi_sorter_new();
}
