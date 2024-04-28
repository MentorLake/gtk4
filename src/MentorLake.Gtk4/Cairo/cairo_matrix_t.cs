using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_matrix_tHandle : BaseSafeHandle { }

public struct cairo_matrix_t
{
	public double xx;
	public double yx;
	public double xy;
	public double yy;
	public double x0;
	public double y0;
}

public static class cairo_matrixAdaptors
{
	public static cairo_matrix_tHandle CairoMatrixInit(this cairo_matrix_tHandle matrixT, double xx, double yx, double xy, double yy, double x0, double y0)
	{
		cairo_matrixExterns.cairo_matrix_init(matrixT, xx, yx, xy, yy, x0, y0);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixInitIdentity(this cairo_matrix_tHandle matrixT)
	{
		cairo_matrixExterns.cairo_matrix_init_identity(matrixT);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixInitTranslate(this cairo_matrix_tHandle matrixT, double tx, double ty)
	{
		cairo_matrixExterns.cairo_matrix_init_translate(matrixT, tx, ty);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixInitScale(this cairo_matrix_tHandle matrixT, double sx, double sy)
	{
		cairo_matrixExterns.cairo_matrix_init_scale(matrixT, sx, sy);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixInitRotate(this cairo_matrix_tHandle matrixT, double radians)
	{
		cairo_matrixExterns.cairo_matrix_init_rotate(matrixT, radians);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixTranslate(this cairo_matrix_tHandle matrixT, double tx, double ty)
	{
		cairo_matrixExterns.cairo_matrix_translate(matrixT, tx, ty);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixScale(this cairo_matrix_tHandle matrixT, double sx, double sy)
	{
		cairo_matrixExterns.cairo_matrix_scale(matrixT, sx, sy);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixRotate(this cairo_matrix_tHandle matrixT, double radians)
	{
		cairo_matrixExterns.cairo_matrix_rotate(matrixT, radians);
		return matrixT;
	}

	public static cairo_status_t CairoMatrixInvert(this cairo_matrix_tHandle matrixT)
	{
		return cairo_matrixExterns.cairo_matrix_invert(matrixT);
	}

	public static cairo_matrix_tHandle CairoMatrixMultiply(this cairo_matrix_tHandle result, cairo_matrix_tHandle a, cairo_matrix_tHandle b)
	{
		cairo_matrixExterns.cairo_matrix_multiply(result, a, b);
		return result;
	}

	public static cairo_matrix_tHandle CairoMatrixTransformDistance(this cairo_matrix_tHandle matrixT, ref double dx, ref double dy)
	{
		cairo_matrixExterns.cairo_matrix_transform_distance(matrixT, ref dx, ref dy);
		return matrixT;
	}

	public static cairo_matrix_tHandle CairoMatrixTransformPoint(this cairo_matrix_tHandle matrixT, ref double x, ref double y)
	{
		cairo_matrixExterns.cairo_matrix_transform_point(matrixT, ref x, ref y);
		return matrixT;
	}
}

public static class cairo_matrixExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init")]
	internal static extern void cairo_matrix_init(this cairo_matrix_tHandle matrixT, double xx, double yx, double xy, double yy, double x0, double y0);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_identity")]
	internal static extern void cairo_matrix_init_identity(this cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_translate")]
	internal static extern void cairo_matrix_init_translate(this cairo_matrix_tHandle matrixT, double tx, double ty);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_scale")]
	internal static extern void cairo_matrix_init_scale(this cairo_matrix_tHandle matrixT, double sx, double sy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_rotate")]
	internal static extern void cairo_matrix_init_rotate(this cairo_matrix_tHandle matrixT, double radians);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_translate")]
	internal static extern void cairo_matrix_translate(this cairo_matrix_tHandle matrixT, double tx, double ty);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_scale")]
	internal static extern void cairo_matrix_scale(this cairo_matrix_tHandle matrixT, double sx, double sy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_rotate")]
	internal static extern void cairo_matrix_rotate(this cairo_matrix_tHandle matrixT, double radians);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_invert")]
	internal static extern cairo_status_t cairo_matrix_invert(this cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_multiply")]
	internal static extern void cairo_matrix_multiply(this cairo_matrix_tHandle result, cairo_matrix_tHandle a, cairo_matrix_tHandle b);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_transform_distance")]
	internal static extern void cairo_matrix_transform_distance(this cairo_matrix_tHandle matrixT, ref double dx, ref double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_transform_point")]
	internal static extern void cairo_matrix_transform_point(this cairo_matrix_tHandle matrixT, ref double x, ref double y);
}
