using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_matrixAdaptors
{
    public static cairo_matrixHandle CairoMatrixInit(this cairo_matrixHandle matrix, double xx, double yx, double xy, double yy, double x0, double y0)
    {
        cairo_matrixExterns.cairo_matrix_init(matrix, xx, yx, xy, yy, x0, y0);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixInitIdentity(this cairo_matrixHandle matrix)
    {
        cairo_matrixExterns.cairo_matrix_init_identity(matrix);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixInitTranslate(this cairo_matrixHandle matrix, double tx, double ty)
    {
        cairo_matrixExterns.cairo_matrix_init_translate(matrix, tx, ty);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixInitScale(this cairo_matrixHandle matrix, double sx, double sy)
    {
        cairo_matrixExterns.cairo_matrix_init_scale(matrix, sx, sy);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixInitRotate(this cairo_matrixHandle matrix, double radians)
    {
        cairo_matrixExterns.cairo_matrix_init_rotate(matrix, radians);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixTranslate(this cairo_matrixHandle matrix, double tx, double ty)
    {
        cairo_matrixExterns.cairo_matrix_translate(matrix, tx, ty);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixScale(this cairo_matrixHandle matrix, double sx, double sy)
    {
        cairo_matrixExterns.cairo_matrix_scale(matrix, sx, sy);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixRotate(this cairo_matrixHandle matrix, double radians)
    {
        cairo_matrixExterns.cairo_matrix_rotate(matrix, radians);
        return matrix;
    }

    public static _cairo_status CairoMatrixInvert(this cairo_matrixHandle matrix)
    {
        return cairo_matrixExterns.cairo_matrix_invert(matrix);
    }

    public static cairo_matrixHandle CairoMatrixMultiply(this cairo_matrixHandle result, cairo_matrixHandle a, cairo_matrixHandle b)
    {
        cairo_matrixExterns.cairo_matrix_multiply(result, a, b);
        return result;
    }

    public static cairo_matrixHandle CairoMatrixTransformDistance(this cairo_matrixHandle matrix, ref double dx, ref double dy)
    {
        cairo_matrixExterns.cairo_matrix_transform_distance(matrix, ref dx, ref dy);
        return matrix;
    }

    public static cairo_matrixHandle CairoMatrixTransformPoint(this cairo_matrixHandle matrix, ref double x, ref double y)
    {
        cairo_matrixExterns.cairo_matrix_transform_point(matrix, ref x, ref y);
        return matrix;
    }
}
