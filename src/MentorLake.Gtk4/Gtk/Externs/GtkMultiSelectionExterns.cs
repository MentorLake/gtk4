using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMultiSelectionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_multi_selection_get_model")]
    internal static extern GListModelHandle gtk_multi_selection_get_model(this GtkMultiSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_multi_selection_set_model")]
    internal static extern void gtk_multi_selection_set_model(this GtkMultiSelectionHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMultiSelectionHandle gtk_multi_selection_new(GListModelHandle model);
}
