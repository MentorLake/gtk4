namespace MentorLake.Gtk4.Pango;

public class PangoMatrixHandle : BaseSafeHandle
{
}


public static class PangoMatrixHandleExtensions
{
	public static PangoMatrixHandle Concat(this PangoMatrixHandle matrix, PangoMatrixHandle new_matrix)
	{
		PangoMatrixExterns.pango_matrix_concat(matrix, new_matrix);
		return matrix;
	}

	public static PangoMatrixHandle Copy(this PangoMatrixHandle matrix)
	{
		return PangoMatrixExterns.pango_matrix_copy(matrix);
	}

	public static PangoMatrixHandle Free(this PangoMatrixHandle matrix)
	{
		PangoMatrixExterns.pango_matrix_free(matrix);
		return matrix;
	}

	public static double GetFontScaleFactor(this PangoMatrixHandle matrix)
	{
		return PangoMatrixExterns.pango_matrix_get_font_scale_factor(matrix);
	}

	public static PangoMatrixHandle GetFontScaleFactors(this PangoMatrixHandle matrix, out double xscale, out double yscale)
	{
		PangoMatrixExterns.pango_matrix_get_font_scale_factors(matrix, out xscale, out yscale);
		return matrix;
	}

	public static double GetSlantRatio(this PangoMatrixHandle matrix)
	{
		return PangoMatrixExterns.pango_matrix_get_slant_ratio(matrix);
	}

	public static PangoMatrixHandle Rotate(this PangoMatrixHandle matrix, double degrees)
	{
		PangoMatrixExterns.pango_matrix_rotate(matrix, degrees);
		return matrix;
	}

	public static PangoMatrixHandle Scale(this PangoMatrixHandle matrix, double scale_x, double scale_y)
	{
		PangoMatrixExterns.pango_matrix_scale(matrix, scale_x, scale_y);
		return matrix;
	}

	public static PangoMatrixHandle TransformDistance(this PangoMatrixHandle matrix, ref double dx, ref double dy)
	{
		PangoMatrixExterns.pango_matrix_transform_distance(matrix, ref dx, ref dy);
		return matrix;
	}

	public static PangoMatrixHandle TransformPixelRectangle(this PangoMatrixHandle matrix, PangoRectangleHandle rect)
	{
		PangoMatrixExterns.pango_matrix_transform_pixel_rectangle(matrix, rect);
		return matrix;
	}

	public static PangoMatrixHandle TransformPoint(this PangoMatrixHandle matrix, ref double x, ref double y)
	{
		PangoMatrixExterns.pango_matrix_transform_point(matrix, ref x, ref y);
		return matrix;
	}

	public static PangoMatrixHandle TransformRectangle(this PangoMatrixHandle matrix, PangoRectangleHandle rect)
	{
		PangoMatrixExterns.pango_matrix_transform_rectangle(matrix, rect);
		return matrix;
	}

	public static PangoMatrixHandle Translate(this PangoMatrixHandle matrix, double tx, double ty)
	{
		PangoMatrixExterns.pango_matrix_translate(matrix, tx, ty);
		return matrix;
	}

}
internal class PangoMatrixExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_concat(PangoMatrixHandle matrix, PangoMatrixHandle new_matrix);

	[DllImport(Libraries.Pango)]
	internal static extern PangoMatrixHandle pango_matrix_copy(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_free(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern double pango_matrix_get_font_scale_factor(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_get_font_scale_factors(PangoMatrixHandle matrix, out double xscale, out double yscale);

	[DllImport(Libraries.Pango)]
	internal static extern double pango_matrix_get_slant_ratio(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_rotate(PangoMatrixHandle matrix, double degrees);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_scale(PangoMatrixHandle matrix, double scale_x, double scale_y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_distance(PangoMatrixHandle matrix, ref double dx, ref double dy);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_pixel_rectangle(PangoMatrixHandle matrix, PangoRectangleHandle rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_point(PangoMatrixHandle matrix, ref double x, ref double y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_rectangle(PangoMatrixHandle matrix, PangoRectangleHandle rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_translate(PangoMatrixHandle matrix, double tx, double ty);

}

public struct PangoMatrix
{
	public double xx;
	public double xy;
	public double yx;
	public double yy;
	public double x0;
	public double y0;
}
