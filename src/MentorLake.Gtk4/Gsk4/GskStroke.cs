namespace MentorLake.Gtk4.Gsk4;

public class GskStrokeHandle : BaseSafeHandle
{
	public static GskStrokeHandle New(float line_width)
	{
		return GskStrokeExterns.gsk_stroke_new(line_width);
	}

}


public static class GskStrokeHandleExtensions
{
	public static GskStrokeHandle Copy(this GskStrokeHandle other)
	{
		return GskStrokeExterns.gsk_stroke_copy(other);
	}

	public static GskStrokeHandle Free(this GskStrokeHandle self)
	{
		GskStrokeExterns.gsk_stroke_free(self);
		return self;
	}

	public static IntPtr GetDash(this GskStrokeHandle self, out UIntPtr n_dash)
	{
		return GskStrokeExterns.gsk_stroke_get_dash(self, out n_dash);
	}

	public static float GetDashOffset(this GskStrokeHandle self)
	{
		return GskStrokeExterns.gsk_stroke_get_dash_offset(self);
	}

	public static GskLineCap GetLineCap(this GskStrokeHandle self)
	{
		return GskStrokeExterns.gsk_stroke_get_line_cap(self);
	}

	public static GskLineJoin GetLineJoin(this GskStrokeHandle self)
	{
		return GskStrokeExterns.gsk_stroke_get_line_join(self);
	}

	public static float GetLineWidth(this GskStrokeHandle self)
	{
		return GskStrokeExterns.gsk_stroke_get_line_width(self);
	}

	public static float GetMiterLimit(this GskStrokeHandle self)
	{
		return GskStrokeExterns.gsk_stroke_get_miter_limit(self);
	}

	public static GskStrokeHandle SetDash(this GskStrokeHandle self, float[] dash, UIntPtr n_dash)
	{
		GskStrokeExterns.gsk_stroke_set_dash(self, dash, n_dash);
		return self;
	}

	public static GskStrokeHandle SetDashOffset(this GskStrokeHandle self, float offset)
	{
		GskStrokeExterns.gsk_stroke_set_dash_offset(self, offset);
		return self;
	}

	public static GskStrokeHandle SetLineCap(this GskStrokeHandle self, GskLineCap line_cap)
	{
		GskStrokeExterns.gsk_stroke_set_line_cap(self, line_cap);
		return self;
	}

	public static GskStrokeHandle SetLineJoin(this GskStrokeHandle self, GskLineJoin line_join)
	{
		GskStrokeExterns.gsk_stroke_set_line_join(self, line_join);
		return self;
	}

	public static GskStrokeHandle SetLineWidth(this GskStrokeHandle self, float line_width)
	{
		GskStrokeExterns.gsk_stroke_set_line_width(self, line_width);
		return self;
	}

	public static GskStrokeHandle SetMiterLimit(this GskStrokeHandle self, float limit)
	{
		GskStrokeExterns.gsk_stroke_set_miter_limit(self, limit);
		return self;
	}

	public static GskStrokeHandle ToCairo(this GskStrokeHandle self, cairo_tHandle cr)
	{
		GskStrokeExterns.gsk_stroke_to_cairo(self, cr);
		return self;
	}

}
internal class GskStrokeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskStrokeHandle gsk_stroke_new(float line_width);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskStrokeHandle gsk_stroke_copy(GskStrokeHandle other);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_free(GskStrokeHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_stroke_get_dash(GskStrokeHandle self, out UIntPtr n_dash);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_stroke_get_dash_offset(GskStrokeHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskLineCap gsk_stroke_get_line_cap(GskStrokeHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskLineJoin gsk_stroke_get_line_join(GskStrokeHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_stroke_get_line_width(GskStrokeHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_stroke_get_miter_limit(GskStrokeHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_set_dash(GskStrokeHandle self, float[] dash, UIntPtr n_dash);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_set_dash_offset(GskStrokeHandle self, float offset);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_set_line_cap(GskStrokeHandle self, GskLineCap line_cap);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_set_line_join(GskStrokeHandle self, GskLineJoin line_join);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_set_line_width(GskStrokeHandle self, float line_width);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_set_miter_limit(GskStrokeHandle self, float limit);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_stroke_to_cairo(GskStrokeHandle self, cairo_tHandle cr);

}

public struct GskStroke
{
}
