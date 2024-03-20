using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSortListModelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_set_sorter")]
    internal static extern void gtk_sort_list_model_set_sorter(this GtkSortListModelHandle self, GtkSorterHandle sorter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_get_sorter")]
    internal static extern GtkSorterHandle gtk_sort_list_model_get_sorter(this GtkSortListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_set_model")]
    internal static extern void gtk_sort_list_model_set_model(this GtkSortListModelHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_get_model")]
    internal static extern GListModelHandle gtk_sort_list_model_get_model(this GtkSortListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_set_incremental")]
    internal static extern void gtk_sort_list_model_set_incremental(this GtkSortListModelHandle self, int incremental);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_get_incremental")]
    internal static extern int gtk_sort_list_model_get_incremental(this GtkSortListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_sort_list_model_get_pending")]
    internal static extern uint gtk_sort_list_model_get_pending(this GtkSortListModelHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSortListModelHandle gtk_sort_list_model_new(GListModelHandle model, GtkSorterHandle sorter);
}
