using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellRendererTextAdaptors
{
    public static GtkCellRendererTextHandle SetFixedHeightFromFont(this GtkCellRendererTextHandle renderer, int number_of_rows)
    {
        GtkCellRendererTextExterns.gtk_cell_renderer_text_set_fixed_height_from_font(renderer, number_of_rows);
        return renderer;
    }
}
