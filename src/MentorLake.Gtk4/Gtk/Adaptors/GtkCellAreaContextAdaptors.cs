using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellAreaContextAdaptors
{
    public static GtkCellAreaHandle GetArea(this GtkCellAreaContextHandle context)
    {
        return GtkCellAreaContextExterns.gtk_cell_area_context_get_area(context);
    }

    public static GtkCellAreaContextHandle Allocate(this GtkCellAreaContextHandle context, int width, int height)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_allocate(context, width, height);
        return context;
    }

    public static GtkCellAreaContextHandle Reset(this GtkCellAreaContextHandle context)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_reset(context);
        return context;
    }

    public static GtkCellAreaContextHandle GetPreferredWidth(this GtkCellAreaContextHandle context, out int minimum_width, out int natural_width)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_width(context, out minimum_width, out natural_width);
        return context;
    }

    public static GtkCellAreaContextHandle GetPreferredHeight(this GtkCellAreaContextHandle context, out int minimum_height, out int natural_height)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_height(context, out minimum_height, out natural_height);
        return context;
    }

    public static GtkCellAreaContextHandle GetPreferredHeightForWidth(this GtkCellAreaContextHandle context, int width, out int minimum_height, out int natural_height)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_height_for_width(context, width, out minimum_height, out natural_height);
        return context;
    }

    public static GtkCellAreaContextHandle GetPreferredWidthForHeight(this GtkCellAreaContextHandle context, int height, out int minimum_width, out int natural_width)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_width_for_height(context, height, out minimum_width, out natural_width);
        return context;
    }

    public static GtkCellAreaContextHandle GetAllocation(this GtkCellAreaContextHandle context, out int width, out int height)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_get_allocation(context, out width, out height);
        return context;
    }

    public static GtkCellAreaContextHandle PushPreferredWidth(this GtkCellAreaContextHandle context, int minimum_width, int natural_width)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_push_preferred_width(context, minimum_width, natural_width);
        return context;
    }

    public static GtkCellAreaContextHandle PushPreferredHeight(this GtkCellAreaContextHandle context, int minimum_height, int natural_height)
    {
        GtkCellAreaContextExterns.gtk_cell_area_context_push_preferred_height(context, minimum_height, natural_height);
        return context;
    }
}
