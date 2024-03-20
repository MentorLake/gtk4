using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoLayoutLineAdaptors
{
    public static PangoLayoutLineHandle Ref(this PangoLayoutLineHandle line)
    {
        return PangoLayoutLineExterns.pango_layout_line_ref(line);
    }

    public static PangoLayoutLineHandle Unref(this PangoLayoutLineHandle line)
    {
        PangoLayoutLineExterns.pango_layout_line_unref(line);
        return line;
    }

    public static int GetStartIndex(this PangoLayoutLineHandle line)
    {
        return PangoLayoutLineExterns.pango_layout_line_get_start_index(line);
    }

    public static int GetLength(this PangoLayoutLineHandle line)
    {
        return PangoLayoutLineExterns.pango_layout_line_get_length(line);
    }

    public static int IsParagraphStart(this PangoLayoutLineHandle line)
    {
        return PangoLayoutLineExterns.pango_layout_line_is_paragraph_start(line);
    }

    public static PangoDirection GetResolvedDirection(this PangoLayoutLineHandle line)
    {
        return PangoLayoutLineExterns.pango_layout_line_get_resolved_direction(line);
    }

    public static int XToIndex(this PangoLayoutLineHandle line, int x_pos, out int index_, out int trailing)
    {
        return PangoLayoutLineExterns.pango_layout_line_x_to_index(line, x_pos, out index_, out trailing);
    }

    public static PangoLayoutLineHandle IndexToX(this PangoLayoutLineHandle line, int index_, int trailing, out int x_pos)
    {
        PangoLayoutLineExterns.pango_layout_line_index_to_x(line, index_, trailing, out x_pos);
        return line;
    }

    public static PangoLayoutLineHandle GetXRanges(this PangoLayoutLineHandle line, int start_index, int end_index, out int[] ranges, out int n_ranges)
    {
        PangoLayoutLineExterns.pango_layout_line_get_x_ranges(line, start_index, end_index, out ranges, out n_ranges);
        return line;
    }

    public static PangoLayoutLineHandle GetExtents(this PangoLayoutLineHandle line, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutLineExterns.pango_layout_line_get_extents(line, ink_rect, logical_rect);
        return line;
    }

    public static PangoLayoutLineHandle GetHeight(this PangoLayoutLineHandle line, out int height)
    {
        PangoLayoutLineExterns.pango_layout_line_get_height(line, out height);
        return line;
    }

    public static PangoLayoutLineHandle GetPixelExtents(this PangoLayoutLineHandle layout_line, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutLineExterns.pango_layout_line_get_pixel_extents(layout_line, ink_rect, logical_rect);
        return layout_line;
    }
}
