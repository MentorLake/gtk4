using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellAreaBoxAdaptors
{
    public static GtkCellAreaBoxHandle PackStart(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, int expand, int align, int @fixed)
    {
        GtkCellAreaBoxExterns.gtk_cell_area_box_pack_start(box, renderer, expand, align, @fixed);
        return box;
    }

    public static GtkCellAreaBoxHandle PackEnd(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, int expand, int align, int @fixed)
    {
        GtkCellAreaBoxExterns.gtk_cell_area_box_pack_end(box, renderer, expand, align, @fixed);
        return box;
    }

    public static int GetSpacing(this GtkCellAreaBoxHandle box)
    {
        return GtkCellAreaBoxExterns.gtk_cell_area_box_get_spacing(box);
    }

    public static GtkCellAreaBoxHandle SetSpacing(this GtkCellAreaBoxHandle box, int spacing)
    {
        GtkCellAreaBoxExterns.gtk_cell_area_box_set_spacing(box, spacing);
        return box;
    }
}
