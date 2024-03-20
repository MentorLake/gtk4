using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSliceListModelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_slice_list_model_set_model")]
    internal static extern void gtk_slice_list_model_set_model(this GtkSliceListModelHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_slice_list_model_get_model")]
    internal static extern GListModelHandle gtk_slice_list_model_get_model(this GtkSliceListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_slice_list_model_set_offset")]
    internal static extern void gtk_slice_list_model_set_offset(this GtkSliceListModelHandle self, uint offset);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_slice_list_model_get_offset")]
    internal static extern uint gtk_slice_list_model_get_offset(this GtkSliceListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_slice_list_model_set_size")]
    internal static extern void gtk_slice_list_model_set_size(this GtkSliceListModelHandle self, uint size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_slice_list_model_get_size")]
    internal static extern uint gtk_slice_list_model_get_size(this GtkSliceListModelHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSliceListModelHandle gtk_slice_list_model_new(GListModelHandle model, uint offset, uint size);
}
