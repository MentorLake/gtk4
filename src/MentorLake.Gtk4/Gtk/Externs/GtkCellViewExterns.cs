using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellViewExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_set_model")]
    internal static extern void gtk_cell_view_set_model(this GtkCellViewHandle cell_view, GtkTreeModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_get_model")]
    internal static extern GtkTreeModelHandle gtk_cell_view_get_model(this GtkCellViewHandle cell_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_set_displayed_row")]
    internal static extern void gtk_cell_view_set_displayed_row(this GtkCellViewHandle cell_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_get_displayed_row")]
    internal static extern GtkTreePathHandle gtk_cell_view_get_displayed_row(this GtkCellViewHandle cell_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_get_draw_sensitive")]
    internal static extern int gtk_cell_view_get_draw_sensitive(this GtkCellViewHandle cell_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_set_draw_sensitive")]
    internal static extern void gtk_cell_view_set_draw_sensitive(this GtkCellViewHandle cell_view, int draw_sensitive);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_get_fit_model")]
    internal static extern int gtk_cell_view_get_fit_model(this GtkCellViewHandle cell_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_set_fit_model")]
    internal static extern void gtk_cell_view_set_fit_model(this GtkCellViewHandle cell_view, int fit_model);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellViewHandle gtk_cell_view_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellViewHandle gtk_cell_view_new_with_text(string text);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellViewHandle gtk_cell_view_new_with_markup(string markup);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellViewHandle gtk_cell_view_new_with_texture(GdkTextureHandle texture);
}
