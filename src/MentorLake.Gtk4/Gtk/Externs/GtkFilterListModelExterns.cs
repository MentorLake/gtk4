using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFilterListModelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_set_filter")]
    internal static extern void gtk_filter_list_model_set_filter(this GtkFilterListModelHandle self, GtkFilterHandle filter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_get_filter")]
    internal static extern GtkFilterHandle gtk_filter_list_model_get_filter(this GtkFilterListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_set_model")]
    internal static extern void gtk_filter_list_model_set_model(this GtkFilterListModelHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_get_model")]
    internal static extern GListModelHandle gtk_filter_list_model_get_model(this GtkFilterListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_set_incremental")]
    internal static extern void gtk_filter_list_model_set_incremental(this GtkFilterListModelHandle self, int incremental);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_get_incremental")]
    internal static extern int gtk_filter_list_model_get_incremental(this GtkFilterListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_list_model_get_pending")]
    internal static extern uint gtk_filter_list_model_get_pending(this GtkFilterListModelHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFilterListModelHandle gtk_filter_list_model_new(GListModelHandle model, GtkFilterHandle filter);
}
