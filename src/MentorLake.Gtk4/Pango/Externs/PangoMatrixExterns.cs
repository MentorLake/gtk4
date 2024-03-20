using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoMatrixExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_copy")]
	internal static extern PangoMatrixHandle pango_matrix_copy(this PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_free")]
	internal static extern void pango_matrix_free(this PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_translate")]
	internal static extern void pango_matrix_translate(this PangoMatrixHandle matrix, double tx, double ty);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_scale")]
	internal static extern void pango_matrix_scale(this PangoMatrixHandle matrix, double scale_x, double scale_y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_rotate")]
	internal static extern void pango_matrix_rotate(this PangoMatrixHandle matrix, double degrees);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_concat")]
	internal static extern void pango_matrix_concat(this PangoMatrixHandle matrix, PangoMatrixHandle new_matrix);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_transform_point")]
	internal static extern void pango_matrix_transform_point(this PangoMatrixHandle matrix, ref double x, ref double y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_transform_distance")]
	internal static extern void pango_matrix_transform_distance(this PangoMatrixHandle matrix, ref double dx, ref double dy);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_transform_rectangle")]
	internal static extern void pango_matrix_transform_rectangle(this PangoMatrixHandle matrix, PangoRectangleHandle rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_transform_pixel_rectangle")]
	internal static extern void pango_matrix_transform_pixel_rectangle(this PangoMatrixHandle matrix, PangoRectangleHandle rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_get_font_scale_factor")]
	internal static extern double pango_matrix_get_font_scale_factor(this PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_get_font_scale_factors")]
	internal static extern void pango_matrix_get_font_scale_factors(this PangoMatrixHandle matrix, ref double xscale, ref double yscale);

	[DllImport(Libraries.Pango, EntryPoint = "pango_matrix_get_slant_ratio")]
	internal static extern double pango_matrix_get_slant_ratio(this PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango, EntryPoint = "pango_gravity_get_for_matrix")]
	internal static extern PangoGravity pango_gravity_get_for_matrix(this PangoMatrixHandle matrix);
}
