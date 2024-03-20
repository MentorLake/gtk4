using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNoSelectionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_no_selection_get_model")]
    internal static extern GListModelHandle gtk_no_selection_get_model(this GtkNoSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_no_selection_set_model")]
    internal static extern void gtk_no_selection_set_model(this GtkNoSelectionHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkNoSelectionHandle gtk_no_selection_new(GListModelHandle model);
}
