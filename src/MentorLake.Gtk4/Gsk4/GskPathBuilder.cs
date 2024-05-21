namespace MentorLake.Gtk4.Gsk4;

public class GskPathBuilderHandle : BaseSafeHandle
{
	public static GskPathBuilderHandle New()
	{
		return GskPathBuilderExterns.gsk_path_builder_new();
	}

}


public static class GskPathBuilderHandleExtensions
{
	public static GskPathBuilderHandle AddCairoPath(this GskPathBuilderHandle self, cairo_path_tHandle path)
	{
		GskPathBuilderExterns.gsk_path_builder_add_cairo_path(self, path);
		return self;
	}

	public static GskPathBuilderHandle AddCircle(this GskPathBuilderHandle self, graphene_point_tHandle center, float radius)
	{
		GskPathBuilderExterns.gsk_path_builder_add_circle(self, center, radius);
		return self;
	}

	public static GskPathBuilderHandle AddLayout(this GskPathBuilderHandle self, PangoLayoutHandle layout)
	{
		GskPathBuilderExterns.gsk_path_builder_add_layout(self, layout);
		return self;
	}

	public static GskPathBuilderHandle AddPath(this GskPathBuilderHandle self, GskPathHandle path)
	{
		GskPathBuilderExterns.gsk_path_builder_add_path(self, path);
		return self;
	}

	public static GskPathBuilderHandle AddRect(this GskPathBuilderHandle self, graphene_rect_tHandle rect)
	{
		GskPathBuilderExterns.gsk_path_builder_add_rect(self, rect);
		return self;
	}

	public static GskPathBuilderHandle AddReversePath(this GskPathBuilderHandle self, GskPathHandle path)
	{
		GskPathBuilderExterns.gsk_path_builder_add_reverse_path(self, path);
		return self;
	}

	public static GskPathBuilderHandle AddRoundedRect(this GskPathBuilderHandle self, GskRoundedRectHandle rect)
	{
		GskPathBuilderExterns.gsk_path_builder_add_rounded_rect(self, rect);
		return self;
	}

	public static GskPathBuilderHandle AddSegment(this GskPathBuilderHandle self, GskPathHandle path, GskPathPointHandle start, GskPathPointHandle end)
	{
		GskPathBuilderExterns.gsk_path_builder_add_segment(self, path, start, end);
		return self;
	}

	public static GskPathBuilderHandle ArcTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2)
	{
		GskPathBuilderExterns.gsk_path_builder_arc_to(self, x1, y1, x2, y2);
		return self;
	}

	public static GskPathBuilderHandle Close(this GskPathBuilderHandle self)
	{
		GskPathBuilderExterns.gsk_path_builder_close(self);
		return self;
	}

	public static GskPathBuilderHandle ConicTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float weight)
	{
		GskPathBuilderExterns.gsk_path_builder_conic_to(self, x1, y1, x2, y2, weight);
		return self;
	}

	public static GskPathBuilderHandle CubicTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float x3, float y3)
	{
		GskPathBuilderExterns.gsk_path_builder_cubic_to(self, x1, y1, x2, y2, x3, y3);
		return self;
	}

	public static GskPathHandle FreeToPath(this GskPathBuilderHandle self)
	{
		return GskPathBuilderExterns.gsk_path_builder_free_to_path(self);
	}

	public static graphene_point_tHandle GetCurrentPoint(this GskPathBuilderHandle self)
	{
		return GskPathBuilderExterns.gsk_path_builder_get_current_point(self);
	}

	public static GskPathBuilderHandle HtmlArcTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float radius)
	{
		GskPathBuilderExterns.gsk_path_builder_html_arc_to(self, x1, y1, x2, y2, radius);
		return self;
	}

	public static GskPathBuilderHandle LineTo(this GskPathBuilderHandle self, float x, float y)
	{
		GskPathBuilderExterns.gsk_path_builder_line_to(self, x, y);
		return self;
	}

	public static GskPathBuilderHandle MoveTo(this GskPathBuilderHandle self, float x, float y)
	{
		GskPathBuilderExterns.gsk_path_builder_move_to(self, x, y);
		return self;
	}

	public static GskPathBuilderHandle QuadTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2)
	{
		GskPathBuilderExterns.gsk_path_builder_quad_to(self, x1, y1, x2, y2);
		return self;
	}

	public static GskPathBuilderHandle Ref(this GskPathBuilderHandle self)
	{
		return GskPathBuilderExterns.gsk_path_builder_ref(self);
	}

	public static GskPathBuilderHandle RelArcTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_arc_to(self, x1, y1, x2, y2);
		return self;
	}

	public static GskPathBuilderHandle RelConicTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float weight)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_conic_to(self, x1, y1, x2, y2, weight);
		return self;
	}

	public static GskPathBuilderHandle RelCubicTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float x3, float y3)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_cubic_to(self, x1, y1, x2, y2, x3, y3);
		return self;
	}

	public static GskPathBuilderHandle RelHtmlArcTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float radius)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_html_arc_to(self, x1, y1, x2, y2, radius);
		return self;
	}

	public static GskPathBuilderHandle RelLineTo(this GskPathBuilderHandle self, float x, float y)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_line_to(self, x, y);
		return self;
	}

	public static GskPathBuilderHandle RelMoveTo(this GskPathBuilderHandle self, float x, float y)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_move_to(self, x, y);
		return self;
	}

	public static GskPathBuilderHandle RelQuadTo(this GskPathBuilderHandle self, float x1, float y1, float x2, float y2)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_quad_to(self, x1, y1, x2, y2);
		return self;
	}

	public static GskPathBuilderHandle RelSvgArcTo(this GskPathBuilderHandle self, float rx, float ry, float x_axis_rotation, bool large_arc, bool positive_sweep, float x, float y)
	{
		GskPathBuilderExterns.gsk_path_builder_rel_svg_arc_to(self, rx, ry, x_axis_rotation, large_arc, positive_sweep, x, y);
		return self;
	}

	public static GskPathBuilderHandle SvgArcTo(this GskPathBuilderHandle self, float rx, float ry, float x_axis_rotation, bool large_arc, bool positive_sweep, float x, float y)
	{
		GskPathBuilderExterns.gsk_path_builder_svg_arc_to(self, rx, ry, x_axis_rotation, large_arc, positive_sweep, x, y);
		return self;
	}

	public static GskPathHandle ToPath(this GskPathBuilderHandle self)
	{
		return GskPathBuilderExterns.gsk_path_builder_to_path(self);
	}

	public static GskPathBuilderHandle Unref(this GskPathBuilderHandle self)
	{
		GskPathBuilderExterns.gsk_path_builder_unref(self);
		return self;
	}

}
internal class GskPathBuilderExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathBuilderHandle gsk_path_builder_new();

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_cairo_path(GskPathBuilderHandle self, cairo_path_tHandle path);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_circle(GskPathBuilderHandle self, graphene_point_tHandle center, float radius);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_layout(GskPathBuilderHandle self, PangoLayoutHandle layout);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_path(GskPathBuilderHandle self, GskPathHandle path);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_rect(GskPathBuilderHandle self, graphene_rect_tHandle rect);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_reverse_path(GskPathBuilderHandle self, GskPathHandle path);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_rounded_rect(GskPathBuilderHandle self, GskRoundedRectHandle rect);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_add_segment(GskPathBuilderHandle self, GskPathHandle path, GskPathPointHandle start, GskPathPointHandle end);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_arc_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_close(GskPathBuilderHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_conic_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float weight);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_cubic_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float x3, float y3);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathHandle gsk_path_builder_free_to_path(GskPathBuilderHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_path_builder_get_current_point(GskPathBuilderHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_html_arc_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float radius);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_line_to(GskPathBuilderHandle self, float x, float y);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_move_to(GskPathBuilderHandle self, float x, float y);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_quad_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathBuilderHandle gsk_path_builder_ref(GskPathBuilderHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_arc_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_conic_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float weight);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_cubic_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float x3, float y3);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_html_arc_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2, float radius);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_line_to(GskPathBuilderHandle self, float x, float y);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_move_to(GskPathBuilderHandle self, float x, float y);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_quad_to(GskPathBuilderHandle self, float x1, float y1, float x2, float y2);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_rel_svg_arc_to(GskPathBuilderHandle self, float rx, float ry, float x_axis_rotation, bool large_arc, bool positive_sweep, float x, float y);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_svg_arc_to(GskPathBuilderHandle self, float rx, float ry, float x_axis_rotation, bool large_arc, bool positive_sweep, float x, float y);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathHandle gsk_path_builder_to_path(GskPathBuilderHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_builder_unref(GskPathBuilderHandle self);

}

public struct GskPathBuilder
{
}
