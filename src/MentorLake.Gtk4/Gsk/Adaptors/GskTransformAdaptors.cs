using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskTransformAdaptors
{
	public static GskTransformHandle Ref(this GskTransformHandle self)
	{
		return GskTransformExterns.gsk_transform_ref(self);
	}

	public static GskTransformHandle Unref(this GskTransformHandle self)
	{
		GskTransformExterns.gsk_transform_unref(self);
		return self;
	}

	public static GskTransformHandle Print(this GskTransformHandle self, GStringHandle @string)
	{
		GskTransformExterns.gsk_transform_print(self, @string);
		return self;
	}

	public static string ToString(this GskTransformHandle self)
	{
		return GskTransformExterns.gsk_transform_to_string(self);
	}

	public static GskTransformHandle ToMatrix(this GskTransformHandle self, graphene_matrix_tHandle out_matrix)
	{
		GskTransformExterns.gsk_transform_to_matrix(self, out_matrix);
		return self;
	}

	public static GskTransformHandle To2D(this GskTransformHandle self, out float out_xx, out float out_yx, out float out_xy, out float out_yy, out float out_dx, out float out_dy)
	{
		GskTransformExterns.gsk_transform_to_2d(self, out out_xx, out out_yx, out out_xy, out out_yy, out out_dx, out out_dy);
		return self;
	}

	public static GskTransformHandle To2DComponents(this GskTransformHandle self, out float out_skew_x, out float out_skew_y, out float out_scale_x, out float out_scale_y, out float out_angle, out float out_dx, out float out_dy)
	{
		GskTransformExterns.gsk_transform_to_2d_components(self, out out_skew_x, out out_skew_y, out out_scale_x, out out_scale_y, out out_angle, out out_dx, out out_dy);
		return self;
	}

	public static GskTransformHandle ToAffine(this GskTransformHandle self, out float out_scale_x, out float out_scale_y, out float out_dx, out float out_dy)
	{
		GskTransformExterns.gsk_transform_to_affine(self, out out_scale_x, out out_scale_y, out out_dx, out out_dy);
		return self;
	}

	public static GskTransformHandle ToTranslate(this GskTransformHandle self, out float out_dx, out float out_dy)
	{
		GskTransformExterns.gsk_transform_to_translate(self, out out_dx, out out_dy);
		return self;
	}

	public static GskTransformCategory GetCategory(this GskTransformHandle self)
	{
		return GskTransformExterns.gsk_transform_get_category(self);
	}

	public static int Equal(this GskTransformHandle first, GskTransformHandle second)
	{
		return GskTransformExterns.gsk_transform_equal(first, second);
	}

	public static GskTransformHandle Transform(this GskTransformHandle next, GskTransformHandle other)
	{
		return GskTransformExterns.gsk_transform_transform(next, other);
	}

	public static GskTransformHandle Invert(this GskTransformHandle self)
	{
		return GskTransformExterns.gsk_transform_invert(self);
	}

	public static GskTransformHandle Matrix(this GskTransformHandle next, graphene_matrix_tHandle matrix)
	{
		return GskTransformExterns.gsk_transform_matrix(next, matrix);
	}

	public static GskTransformHandle Translate(this GskTransformHandle next, graphene_point_tHandle point)
	{
		return GskTransformExterns.gsk_transform_translate(next, point);
	}

	public static GskTransformHandle Translate3D(this GskTransformHandle next, graphene_point3d_tHandle point)
	{
		return GskTransformExterns.gsk_transform_translate_3d(next, point);
	}

	public static GskTransformHandle Skew(this GskTransformHandle next, float skew_x, float skew_y)
	{
		return GskTransformExterns.gsk_transform_skew(next, skew_x, skew_y);
	}

	public static GskTransformHandle Rotate(this GskTransformHandle next, float angle)
	{
		return GskTransformExterns.gsk_transform_rotate(next, angle);
	}

	public static GskTransformHandle Rotate3D(this GskTransformHandle next, float angle, graphene_vec3_tHandle axis)
	{
		return GskTransformExterns.gsk_transform_rotate_3d(next, angle, axis);
	}

	public static GskTransformHandle Scale(this GskTransformHandle next, float factor_x, float factor_y)
	{
		return GskTransformExterns.gsk_transform_scale(next, factor_x, factor_y);
	}

	public static GskTransformHandle Scale3D(this GskTransformHandle next, float factor_x, float factor_y, float factor_z)
	{
		return GskTransformExterns.gsk_transform_scale_3d(next, factor_x, factor_y, factor_z);
	}

	public static GskTransformHandle Perspective(this GskTransformHandle next, float depth)
	{
		return GskTransformExterns.gsk_transform_perspective(next, depth);
	}

	public static GskTransformHandle TransformBounds(this GskTransformHandle self, graphene_rect_tHandle rect, graphene_rect_tHandle out_rect)
	{
		GskTransformExterns.gsk_transform_transform_bounds(self, rect, out_rect);
		return self;
	}

	public static GskTransformHandle TransformPoint(this GskTransformHandle self, graphene_point_tHandle point, graphene_point_tHandle out_point)
	{
		GskTransformExterns.gsk_transform_transform_point(self, point, out_point);
		return self;
	}
}
