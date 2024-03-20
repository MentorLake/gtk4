using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScrollbarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollbar_set_adjustment")]
    internal static extern void gtk_scrollbar_set_adjustment(this GtkScrollbarHandle self, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrollbar_get_adjustment")]
    internal static extern GtkAdjustmentHandle gtk_scrollbar_get_adjustment(this GtkScrollbarHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkScrollbarHandle gtk_scrollbar_new(GtkOrientation orientation, GtkAdjustmentHandle adjustment);
}
