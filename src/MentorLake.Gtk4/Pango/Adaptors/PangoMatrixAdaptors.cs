using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoMatrixAdaptors
{
    public static PangoMatrixHandle Copy(this PangoMatrixHandle matrix)
    {
        return PangoMatrixExterns.pango_matrix_copy(matrix);
    }

    public static PangoMatrixHandle Free(this PangoMatrixHandle matrix)
    {
        PangoMatrixExterns.pango_matrix_free(matrix);
        return matrix;
    }

    public static PangoMatrixHandle Translate(this PangoMatrixHandle matrix, double tx, double ty)
    {
        PangoMatrixExterns.pango_matrix_translate(matrix, tx, ty);
        return matrix;
    }

    public static PangoMatrixHandle Scale(this PangoMatrixHandle matrix, double scale_x, double scale_y)
    {
        PangoMatrixExterns.pango_matrix_scale(matrix, scale_x, scale_y);
        return matrix;
    }

    public static PangoMatrixHandle Rotate(this PangoMatrixHandle matrix, double degrees)
    {
        PangoMatrixExterns.pango_matrix_rotate(matrix, degrees);
        return matrix;
    }

    public static PangoMatrixHandle Concat(this PangoMatrixHandle matrix, PangoMatrixHandle new_matrix)
    {
        PangoMatrixExterns.pango_matrix_concat(matrix, new_matrix);
        return matrix;
    }

    public static PangoMatrixHandle TransformPoint(this PangoMatrixHandle matrix, ref double x, ref double y)
    {
        PangoMatrixExterns.pango_matrix_transform_point(matrix, ref x, ref y);
        return matrix;
    }

    public static PangoMatrixHandle TransformDistance(this PangoMatrixHandle matrix, ref double dx, ref double dy)
    {
        PangoMatrixExterns.pango_matrix_transform_distance(matrix, ref dx, ref dy);
        return matrix;
    }

    public static PangoMatrixHandle TransformRectangle(this PangoMatrixHandle matrix, PangoRectangleHandle rect)
    {
        PangoMatrixExterns.pango_matrix_transform_rectangle(matrix, rect);
        return matrix;
    }

    public static PangoMatrixHandle TransformPixelRectangle(this PangoMatrixHandle matrix, PangoRectangleHandle rect)
    {
        PangoMatrixExterns.pango_matrix_transform_pixel_rectangle(matrix, rect);
        return matrix;
    }

    public static double GetFontScaleFactor(this PangoMatrixHandle matrix)
    {
        return PangoMatrixExterns.pango_matrix_get_font_scale_factor(matrix);
    }

    public static PangoMatrixHandle GetFontScaleFactors(this PangoMatrixHandle matrix, ref double xscale, ref double yscale)
    {
        PangoMatrixExterns.pango_matrix_get_font_scale_factors(matrix, ref xscale, ref yscale);
        return matrix;
    }

    public static double GetSlantRatio(this PangoMatrixHandle matrix)
    {
        return PangoMatrixExterns.pango_matrix_get_slant_ratio(matrix);
    }

    public static PangoGravity PangoGravityGetForMatrix(this PangoMatrixHandle matrix)
    {
        return PangoMatrixExterns.pango_gravity_get_for_matrix(matrix);
    }
}
