using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_matrixExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init")]
	internal static extern void cairo_matrix_init(this cairo_matrixHandle matrix, double xx, double yx, double xy, double yy, double x0, double y0);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_identity")]
	internal static extern void cairo_matrix_init_identity(this cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_translate")]
	internal static extern void cairo_matrix_init_translate(this cairo_matrixHandle matrix, double tx, double ty);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_scale")]
	internal static extern void cairo_matrix_init_scale(this cairo_matrixHandle matrix, double sx, double sy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_init_rotate")]
	internal static extern void cairo_matrix_init_rotate(this cairo_matrixHandle matrix, double radians);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_translate")]
	internal static extern void cairo_matrix_translate(this cairo_matrixHandle matrix, double tx, double ty);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_scale")]
	internal static extern void cairo_matrix_scale(this cairo_matrixHandle matrix, double sx, double sy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_rotate")]
	internal static extern void cairo_matrix_rotate(this cairo_matrixHandle matrix, double radians);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_invert")]
	internal static extern _cairo_status cairo_matrix_invert(this cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_multiply")]
	internal static extern void cairo_matrix_multiply(this cairo_matrixHandle result, cairo_matrixHandle a, cairo_matrixHandle b);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_transform_distance")]
	internal static extern void cairo_matrix_transform_distance(this cairo_matrixHandle matrix, ref double dx, ref double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_matrix_transform_point")]
	internal static extern void cairo_matrix_transform_point(this cairo_matrixHandle matrix, ref double x, ref double y);
}
