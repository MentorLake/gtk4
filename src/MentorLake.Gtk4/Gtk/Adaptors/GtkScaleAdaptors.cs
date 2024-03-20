using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScaleAdaptors
{
	public static GtkScaleHandle SetDigits(this GtkScaleHandle scale, int digits)
	{
		GtkScaleExterns.gtk_scale_set_digits(scale, digits);
		return scale;
	}

	public static int GetDigits(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_digits(scale);
	}

	public static GtkScaleHandle SetDrawValue(this GtkScaleHandle scale, int draw_value)
	{
		GtkScaleExterns.gtk_scale_set_draw_value(scale, draw_value);
		return scale;
	}

	public static int GetDrawValue(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_draw_value(scale);
	}

	public static GtkScaleHandle SetHasOrigin(this GtkScaleHandle scale, int has_origin)
	{
		GtkScaleExterns.gtk_scale_set_has_origin(scale, has_origin);
		return scale;
	}

	public static int GetHasOrigin(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_has_origin(scale);
	}

	public static GtkScaleHandle SetValuePos(this GtkScaleHandle scale, GtkPositionType pos)
	{
		GtkScaleExterns.gtk_scale_set_value_pos(scale, pos);
		return scale;
	}

	public static GtkPositionType GetValuePos(this GtkScaleHandle scale)
	{
		return GtkScaleExterns.gtk_scale_get_value_pos(scale);
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

	public static GtkScaleHandle SetFormatValueFunc(this GtkScaleHandle scale, GtkScaleFormatValueFunc func, IntPtr user_data, GDestroyNotify destroy_notify)
	{
		GtkScaleExterns.gtk_scale_set_format_value_func(scale, func, user_data, destroy_notify);
		return scale;
	}

	public static GtkScaleHandle NewWithRange(GtkOrientation orientation, double min, double max, double step)
	{
		return GtkScaleExterns.gtk_scale_new_with_range(orientation, min, max, step);
	}
}
