namespace MentorLake.Gtk4.Pango;

public class PangoLayoutIterHandle : BaseSafeHandle
{
}


public static class PangoLayoutIterHandleExtensions
{
	public static bool AtLastLine(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_at_last_line(iter);
	}

	public static PangoLayoutIterHandle Copy(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_copy(iter);
	}

	public static PangoLayoutIterHandle Free(this PangoLayoutIterHandle iter)
	{
		PangoLayoutIterExterns.pango_layout_iter_free(iter);
		return iter;
	}

	public static int GetBaseline(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_baseline(iter);
	}

	public static PangoLayoutIterHandle GetCharExtents(this PangoLayoutIterHandle iter, out PangoRectangle logical_rect)
	{
		PangoLayoutIterExterns.pango_layout_iter_get_char_extents(iter, out logical_rect);
		return iter;
	}

	public static PangoLayoutIterHandle GetClusterExtents(this PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoLayoutIterExterns.pango_layout_iter_get_cluster_extents(iter, out ink_rect, out logical_rect);
		return iter;
	}

	public static int GetIndex(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_index(iter);
	}

	public static PangoLayoutHandle GetLayout(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_layout(iter);
	}

	public static PangoLayoutIterHandle GetLayoutExtents(this PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoLayoutIterExterns.pango_layout_iter_get_layout_extents(iter, out ink_rect, out logical_rect);
		return iter;
	}

	public static PangoLayoutLineHandle GetLine(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_line(iter);
	}

	public static PangoLayoutIterHandle GetLineExtents(this PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoLayoutIterExterns.pango_layout_iter_get_line_extents(iter, out ink_rect, out logical_rect);
		return iter;
	}

	public static PangoLayoutLineHandle GetLineReadonly(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_line_readonly(iter);
	}

	public static PangoLayoutIterHandle GetLineYrange(this PangoLayoutIterHandle iter, out int y0_, out int y1_)
	{
		PangoLayoutIterExterns.pango_layout_iter_get_line_yrange(iter, out y0_, out y1_);
		return iter;
	}

	public static PangoLayoutRunHandle GetRun(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_run(iter);
	}

	public static int GetRunBaseline(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_run_baseline(iter);
	}

	public static PangoLayoutIterHandle GetRunExtents(this PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoLayoutIterExterns.pango_layout_iter_get_run_extents(iter, out ink_rect, out logical_rect);
		return iter;
	}

	public static PangoLayoutRunHandle GetRunReadonly(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_get_run_readonly(iter);
	}

	public static bool NextChar(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_next_char(iter);
	}

	public static bool NextCluster(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_next_cluster(iter);
	}

	public static bool NextLine(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_next_line(iter);
	}

	public static bool NextRun(this PangoLayoutIterHandle iter)
	{
		return PangoLayoutIterExterns.pango_layout_iter_next_run(iter);
	}

}
internal class PangoLayoutIterExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_iter_at_last_line(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutIterHandle pango_layout_iter_copy(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_free(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_iter_get_baseline(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_get_char_extents(PangoLayoutIterHandle iter, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_get_cluster_extents(PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_iter_get_index(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutHandle pango_layout_iter_get_layout(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_get_layout_extents(PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutLineHandle pango_layout_iter_get_line(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_get_line_extents(PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutLineHandle pango_layout_iter_get_line_readonly(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_get_line_yrange(PangoLayoutIterHandle iter, out int y0_, out int y1_);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutRunHandle pango_layout_iter_get_run(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_iter_get_run_baseline(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_iter_get_run_extents(PangoLayoutIterHandle iter, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutRunHandle pango_layout_iter_get_run_readonly(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_iter_next_char(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_iter_next_cluster(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_iter_next_line(PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_iter_next_run(PangoLayoutIterHandle iter);

}

public struct PangoLayoutIter
{
}
