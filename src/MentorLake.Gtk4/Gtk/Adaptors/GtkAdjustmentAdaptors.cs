using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAdjustmentAdaptors
{
	public static GtkAdjustmentHandle ClampPage(this GtkAdjustmentHandle adjustment, double lower, double upper)
	{
		GtkAdjustmentExterns.gtk_adjustment_clamp_page(adjustment, lower, upper);
		return adjustment;
	}

	public static double GetValue(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_value(adjustment);
	}

	public static GtkAdjustmentHandle SetValue(this GtkAdjustmentHandle adjustment, double value)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_value(adjustment, value);
		return adjustment;
	}

	public static double GetLower(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_lower(adjustment);
	}

	public static GtkAdjustmentHandle SetLower(this GtkAdjustmentHandle adjustment, double lower)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_lower(adjustment, lower);
		return adjustment;
	}

	public static double GetUpper(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_upper(adjustment);
	}

	public static GtkAdjustmentHandle SetUpper(this GtkAdjustmentHandle adjustment, double upper)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_upper(adjustment, upper);
		return adjustment;
	}

	public static double GetStepIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_step_increment(adjustment);
	}

	public static GtkAdjustmentHandle SetStepIncrement(this GtkAdjustmentHandle adjustment, double step_increment)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_step_increment(adjustment, step_increment);
		return adjustment;
	}

	public static double GetPageIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_page_increment(adjustment);
	}

	public static GtkAdjustmentHandle SetPageIncrement(this GtkAdjustmentHandle adjustment, double page_increment)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_page_increment(adjustment, page_increment);
		return adjustment;
	}

	public static double GetPageSize(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_page_size(adjustment);
	}

	public static GtkAdjustmentHandle SetPageSize(this GtkAdjustmentHandle adjustment, double page_size)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_page_size(adjustment, page_size);
		return adjustment;
	}

	public static GtkAdjustmentHandle Configure(this GtkAdjustmentHandle adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		GtkAdjustmentExterns.gtk_adjustment_configure(adjustment, value, lower, upper, step_increment, page_increment, page_size);
		return adjustment;
	}

	public static double GetMinimumIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_minimum_increment(adjustment);
	}

	public static GtkSpinButtonHandle GtkSpinButtonNew(this GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		return GtkAdjustmentExterns.gtk_spin_button_new(adjustment, climb_rate, digits);
	}

	public static GtkViewportHandle GtkViewportNew(this GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment)
	{
		return GtkAdjustmentExterns.gtk_viewport_new(hadjustment, vadjustment);
	}
}
