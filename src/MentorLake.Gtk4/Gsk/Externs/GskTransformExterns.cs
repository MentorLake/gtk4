using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskTransformExterns
{
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_ref")]
    internal static extern GskTransformHandle gsk_transform_ref(this GskTransformHandle self);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_unref")]
    internal static extern void gsk_transform_unref(this GskTransformHandle self);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_print")]
    internal static extern void gsk_transform_print(this GskTransformHandle self, GStringHandle @string);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_to_string")]
    internal static extern string gsk_transform_to_string(this GskTransformHandle self);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_to_matrix")]
    internal static extern void gsk_transform_to_matrix(this GskTransformHandle self, graphene_matrix_tHandle out_matrix);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_to_2d")]
    internal static extern void gsk_transform_to_2d(this GskTransformHandle self, out float out_xx, out float out_yx, out float out_xy, out float out_yy, out float out_dx, out float out_dy);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_to_2d_components")]
    internal static extern void gsk_transform_to_2d_components(this GskTransformHandle self, out float out_skew_x, out float out_skew_y, out float out_scale_x, out float out_scale_y, out float out_angle, out float out_dx, out float out_dy);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_to_affine")]
    internal static extern void gsk_transform_to_affine(this GskTransformHandle self, out float out_scale_x, out float out_scale_y, out float out_dx, out float out_dy);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_to_translate")]
    internal static extern void gsk_transform_to_translate(this GskTransformHandle self, out float out_dx, out float out_dy);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_get_category")]
    internal static extern GskTransformCategory gsk_transform_get_category(this GskTransformHandle self);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_equal")]
    internal static extern int gsk_transform_equal(this GskTransformHandle first, GskTransformHandle second);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_transform")]
    internal static extern GskTransformHandle gsk_transform_transform(this GskTransformHandle next, GskTransformHandle other);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_invert")]
    internal static extern GskTransformHandle gsk_transform_invert(this GskTransformHandle self);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_matrix")]
    internal static extern GskTransformHandle gsk_transform_matrix(this GskTransformHandle next, graphene_matrix_tHandle matrix);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_translate")]
    internal static extern GskTransformHandle gsk_transform_translate(this GskTransformHandle next, graphene_point_tHandle point);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_translate_3d")]
    internal static extern GskTransformHandle gsk_transform_translate_3d(this GskTransformHandle next, graphene_point3d_tHandle point);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_skew")]
    internal static extern GskTransformHandle gsk_transform_skew(this GskTransformHandle next, float skew_x, float skew_y);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_rotate")]
    internal static extern GskTransformHandle gsk_transform_rotate(this GskTransformHandle next, float angle);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_rotate_3d")]
    internal static extern GskTransformHandle gsk_transform_rotate_3d(this GskTransformHandle next, float angle, graphene_vec3_tHandle axis);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_scale")]
    internal static extern GskTransformHandle gsk_transform_scale(this GskTransformHandle next, float factor_x, float factor_y);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_scale_3d")]
    internal static extern GskTransformHandle gsk_transform_scale_3d(this GskTransformHandle next, float factor_x, float factor_y, float factor_z);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_perspective")]
    internal static extern GskTransformHandle gsk_transform_perspective(this GskTransformHandle next, float depth);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_transform_bounds")]
    internal static extern void gsk_transform_transform_bounds(this GskTransformHandle self, graphene_rect_tHandle rect, graphene_rect_tHandle out_rect);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_transform_point")]
    internal static extern void gsk_transform_transform_point(this GskTransformHandle self, graphene_point_tHandle point, graphene_point_tHandle out_point);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskTransformHandle gsk_transform_new();
}
