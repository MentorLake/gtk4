using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellLayoutAdaptors
{
    public static GtkCellLayoutHandle PackStart(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int expand)
    {
        GtkCellLayoutExterns.gtk_cell_layout_pack_start(cell_layout, cell, expand);
        return cell_layout;
    }

    public static GtkCellLayoutHandle PackEnd(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int expand)
    {
        GtkCellLayoutExterns.gtk_cell_layout_pack_end(cell_layout, cell, expand);
        return cell_layout;
    }

    public static GListHandle GetCells(this GtkCellLayoutHandle cell_layout)
    {
        return GtkCellLayoutExterns.gtk_cell_layout_get_cells(cell_layout);
    }

    public static GtkCellLayoutHandle Clear(this GtkCellLayoutHandle cell_layout)
    {
        GtkCellLayoutExterns.gtk_cell_layout_clear(cell_layout);
        return cell_layout;
    }

    public static GtkCellLayoutHandle SetAttributes(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, IntPtr @__argList)
    {
        GtkCellLayoutExterns.gtk_cell_layout_set_attributes(cell_layout, cell, @__argList);
        return cell_layout;
    }

    public static GtkCellLayoutHandle AddAttribute(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, string attribute, int column)
    {
        GtkCellLayoutExterns.gtk_cell_layout_add_attribute(cell_layout, cell, attribute, column);
        return cell_layout;
    }

    public static GtkCellLayoutHandle SetCellDataFunc(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, GtkCellLayoutDataFunc func, IntPtr func_data, GDestroyNotify destroy)
    {
        GtkCellLayoutExterns.gtk_cell_layout_set_cell_data_func(cell_layout, cell, func, func_data, destroy);
        return cell_layout;
    }

    public static GtkCellLayoutHandle ClearAttributes(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell)
    {
        GtkCellLayoutExterns.gtk_cell_layout_clear_attributes(cell_layout, cell);
        return cell_layout;
    }

    public static GtkCellLayoutHandle Reorder(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int position)
    {
        GtkCellLayoutExterns.gtk_cell_layout_reorder(cell_layout, cell, position);
        return cell_layout;
    }

    public static GtkCellAreaHandle GetArea(this GtkCellLayoutHandle cell_layout)
    {
        return GtkCellLayoutExterns.gtk_cell_layout_get_area(cell_layout);
    }
}
