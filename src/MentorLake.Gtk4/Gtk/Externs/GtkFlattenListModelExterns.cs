using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFlattenListModelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flatten_list_model_set_model")]
    internal static extern void gtk_flatten_list_model_set_model(this GtkFlattenListModelHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flatten_list_model_get_model")]
    internal static extern GListModelHandle gtk_flatten_list_model_get_model(this GtkFlattenListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flatten_list_model_get_model_for_item")]
    internal static extern GListModelHandle gtk_flatten_list_model_get_model_for_item(this GtkFlattenListModelHandle self, uint position);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFlattenListModelHandle gtk_flatten_list_model_new(GListModelHandle model);
}
