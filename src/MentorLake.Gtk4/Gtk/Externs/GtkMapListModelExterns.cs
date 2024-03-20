using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMapListModelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_map_list_model_set_map_func")]
    internal static extern void gtk_map_list_model_set_map_func(this GtkMapListModelHandle self, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_map_list_model_set_model")]
    internal static extern void gtk_map_list_model_set_model(this GtkMapListModelHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_map_list_model_get_model")]
    internal static extern GListModelHandle gtk_map_list_model_get_model(this GtkMapListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_map_list_model_has_map")]
    internal static extern int gtk_map_list_model_has_map(this GtkMapListModelHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMapListModelHandle gtk_map_list_model_new(GListModelHandle model, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy);
}
