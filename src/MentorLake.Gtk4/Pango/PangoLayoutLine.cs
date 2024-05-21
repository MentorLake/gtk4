namespace MentorLake.Gtk4.Pango;

public class PangoLayoutLineHandle : BaseSafeHandle
{
}


public static class PangoLayoutLineHandleExtensions
{
	public static PangoLayoutLineHandle GetExtents(this PangoLayoutLineHandle line, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoLayoutLineExterns.pango_layout_line_get_extents(line, out ink_rect, out logical_rect);
		return line;
	}

	public static PangoLayoutLineHandle GetHeight(this PangoLayoutLineHandle line, out int height)
	{
		PangoLayoutLineExterns.pango_layout_line_get_height(line, out height);
		return line;
	}

	public static int GetLength(this PangoLayoutLineHandle line)
	{
		return PangoLayoutLineExterns.pango_layout_line_get_length(line);
	}

	public static PangoLayoutLineHandle GetPixelExtents(this PangoLayoutLineHandle layout_line, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoLayoutLineExterns.pango_layout_line_get_pixel_extents(layout_line, out ink_rect, out logical_rect);
		return layout_line;
	}

	public static PangoDirection GetResolvedDirection(this PangoLayoutLineHandle line)
	{
		return PangoLayoutLineExterns.pango_layout_line_get_resolved_direction(line);
	}

	public static int GetStartIndex(this PangoLayoutLineHandle line)
	{
		return PangoLayoutLineExterns.pango_layout_line_get_start_index(line);
	}

	public static PangoLayoutLineHandle GetXRanges(this PangoLayoutLineHandle line, int start_index, int end_index, out int[] ranges, out int n_ranges)
	{
		PangoLayoutLineExterns.pango_layout_line_get_x_ranges(line, start_index, end_index, out ranges, out n_ranges);
		return line;
	}

	public static PangoLayoutLineHandle IndexToX(this PangoLayoutLineHandle line, int index_, bool trailing, out int x_pos)
	{
		PangoLayoutLineExterns.pango_layout_line_index_to_x(line, index_, trailing, out x_pos);
		return line;
	}

	public static bool IsParagraphStart(this PangoLayoutLineHandle line)
	{
		return PangoLayoutLineExterns.pango_layout_line_is_paragraph_start(line);
	}

	public static PangoLayoutLineHandle Ref(this PangoLayoutLineHandle line)
	{
		return PangoLayoutLineExterns.pango_layout_line_ref(line);
	}

	public static PangoLayoutLineHandle Unref(this PangoLayoutLineHandle line)
	{
		PangoLayoutLineExterns.pango_layout_line_unref(line);
		return line;
	}

	public static bool XToIndex(this PangoLayoutLineHandle line, int x_pos, out int index_, out int trailing)
	{
		return PangoLayoutLineExterns.pango_layout_line_x_to_index(line, x_pos, out index_, out trailing);
	}

}
internal class PangoLayoutLineExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_line_get_extents(PangoLayoutLineHandle line, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_line_get_height(PangoLayoutLineHandle line, out int height);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_line_get_length(PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_line_get_pixel_extents(PangoLayoutLineHandle layout_line, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern PangoDirection pango_layout_line_get_resolved_direction(PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_line_get_start_index(PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_line_get_x_ranges(PangoLayoutLineHandle line, int start_index, int end_index, out int[] ranges, out int n_ranges);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_line_index_to_x(PangoLayoutLineHandle line, int index_, bool trailing, out int x_pos);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_line_is_paragraph_start(PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutLineHandle pango_layout_line_ref(PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_line_unref(PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_line_x_to_index(PangoLayoutLineHandle line, int x_pos, out int index_, out int trailing);

}

public struct PangoLayoutLine
{
	public PangoLayoutHandle layout;
	public int start_index;
	public int length;
	public GSListHandle runs;
	public uint is_paragraph_start;
	public uint resolved_dir;
}
