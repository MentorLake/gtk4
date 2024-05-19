namespace MentorLake.Gtk4.Gtk4;

public class GtkScaleHandle : GtkRangeHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkScaleHandle New(GtkOrientation orientation, GtkAdjustmentHandle adjustment)
	{
		return GtkScaleExterns.gtk_scale_new(orientation, adjustment);
	}

	public static GtkScaleHandle NewWithRange(GtkOrientation orientation, double min, double max, double step)
	{
		return GtkScaleExterns.gtk_scale_new_with_range(orientation, min, max, step);
	}

}

public static class GtkScaleHandleExtensions
{
	public static GtkScaleHandle AddMark(this GtkScaleHandle scale, double value, GtkPositionType position, string markup)
	{
		GtkScaleExterns.gtk_scale_add_mark(scale, value, position, markup);
		return scale;
	}

	public static GtkScaleHandle ClearMarks(this GtkScaleHandle scale)
	{
		GtkScaleExterns.gtk_scale_clear_marks(scale);
		return scale;
	}

	public static int GetDigits(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_digits(scale);
	}

	public static bool GetDrawValue(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_draw_value(scale);
	}

	public static bool GetHasOrigin(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_has_origin(scale);
	}

	public static PangoLayoutHandle GetLayout(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_layout(scale);
	}

	public static GtkScaleHandle GetLayoutOffsets(this GtkScaleHandle scale, out int x, out int y)
	{
		GtkScaleExterns.gtk_scale_get_layout_offsets(scale, out x, out y);
		return scale;
	}

	public static GtkPositionType GetValuePos(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_value_pos(scale);
	}

	public static GtkScaleHandle SetDigits(this GtkScaleHandle scale, int digits)
	{
		GtkScaleExterns.gtk_scale_set_digits(scale, digits);
		return scale;
	}

	public static GtkScaleHandle SetDrawValue(this GtkScaleHandle scale, bool draw_value)
	{
		GtkScaleExterns.gtk_scale_set_draw_value(scale, draw_value);
		return scale;
	}

	public static GtkScaleHandle SetFormatValueFunc(this GtkScaleHandle scale, GtkScaleFormatValueFunc func, IntPtr user_data, GDestroyNotify destroy_notify)
	{
		GtkScaleExterns.gtk_scale_set_format_value_func(scale, func, user_data, destroy_notify);
		return scale;
	}

	public static GtkScaleHandle SetHasOrigin(this GtkScaleHandle scale, bool has_origin)
	{
		GtkScaleExterns.gtk_scale_set_has_origin(scale, has_origin);
		return scale;
	}

	public static GtkScaleHandle SetValuePos(this GtkScaleHandle scale, GtkPositionType pos)
	{
		GtkScaleExterns.gtk_scale_set_value_pos(scale, pos);
		return scale;
	}

}

internal class GtkScaleExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScaleHandle gtk_scale_new(GtkOrientation orientation, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScaleHandle gtk_scale_new_with_range(GtkOrientation orientation, double min, double max, double step);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_add_mark(GtkScaleHandle scale, double value, GtkPositionType position, string markup);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_clear_marks(GtkScaleHandle scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_scale_get_digits(GtkScaleHandle scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scale_get_draw_value(GtkScaleHandle scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scale_get_has_origin(GtkScaleHandle scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLayoutHandle gtk_scale_get_layout(GtkScaleHandle scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_get_layout_offsets(GtkScaleHandle scale, out int x, out int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPositionType gtk_scale_get_value_pos(GtkScaleHandle scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_set_digits(GtkScaleHandle scale, int digits);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_set_draw_value(GtkScaleHandle scale, bool draw_value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_set_format_value_func(GtkScaleHandle scale, GtkScaleFormatValueFunc func, IntPtr user_data, GDestroyNotify destroy_notify);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_set_has_origin(GtkScaleHandle scale, bool has_origin);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_set_value_pos(GtkScaleHandle scale, GtkPositionType pos);

}
