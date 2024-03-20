using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoLayoutIterAdaptors
{
    public static PangoLayoutIterHandle Copy(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_copy(iter);
    }

    public static PangoLayoutIterHandle Free(this PangoLayoutIterHandle iter)
    {
        PangoLayoutIterExterns.pango_layout_iter_free(iter);
        return iter;
    }

    public static int GetIndex(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_index(iter);
    }

    public static PangoGlyphItemHandle GetRun(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_run(iter);
    }

    public static PangoGlyphItemHandle GetRunReadonly(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_run_readonly(iter);
    }

    public static PangoLayoutLineHandle GetLine(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_line(iter);
    }

    public static PangoLayoutLineHandle GetLineReadonly(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_line_readonly(iter);
    }

    public static int AtLastLine(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_at_last_line(iter);
    }

    public static PangoLayoutHandle GetLayout(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_layout(iter);
    }

    public static int NextChar(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_next_char(iter);
    }

    public static int NextCluster(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_next_cluster(iter);
    }

    public static int NextRun(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_next_run(iter);
    }

    public static int NextLine(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_next_line(iter);
    }

    public static PangoLayoutIterHandle GetCharExtents(this PangoLayoutIterHandle iter, PangoRectangleHandle logical_rect)
    {
        PangoLayoutIterExterns.pango_layout_iter_get_char_extents(iter, logical_rect);
        return iter;
    }

    public static PangoLayoutIterHandle GetClusterExtents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutIterExterns.pango_layout_iter_get_cluster_extents(iter, ink_rect, logical_rect);
        return iter;
    }

    public static PangoLayoutIterHandle GetRunExtents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutIterExterns.pango_layout_iter_get_run_extents(iter, ink_rect, logical_rect);
        return iter;
    }

    public static PangoLayoutIterHandle GetLineExtents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutIterExterns.pango_layout_iter_get_line_extents(iter, ink_rect, logical_rect);
        return iter;
    }

    public static PangoLayoutIterHandle GetLineYrange(this PangoLayoutIterHandle iter, out int y0_, out int y1_)
    {
        PangoLayoutIterExterns.pango_layout_iter_get_line_yrange(iter, out y0_, out y1_);
        return iter;
    }

    public static PangoLayoutIterHandle GetLayoutExtents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutIterExterns.pango_layout_iter_get_layout_extents(iter, ink_rect, logical_rect);
        return iter;
    }

    public static int GetBaseline(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_baseline(iter);
    }

    public static int GetRunBaseline(this PangoLayoutIterHandle iter)
    {
        return PangoLayoutIterExterns.pango_layout_iter_get_run_baseline(iter);
    }
}
