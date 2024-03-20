using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSpinButtonAdaptors
{
	public static GtkSpinButtonHandle Configure(this GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		GtkSpinButtonExterns.gtk_spin_button_configure(spin_button, adjustment, climb_rate, digits);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetAdjustment(this GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_adjustment(spin_button, adjustment);
		return spin_button;
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_adjustment(spin_button);
	}

	public static GtkSpinButtonHandle SetDigits(this GtkSpinButtonHandle spin_button, uint digits)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_digits(spin_button, digits);
		return spin_button;
	}

	public static uint GetDigits(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_digits(spin_button);
	}

	public static GtkSpinButtonHandle SetIncrements(this GtkSpinButtonHandle spin_button, double step, double page)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_increments(spin_button, step, page);
		return spin_button;
	}

	public static GtkSpinButtonHandle GetIncrements(this GtkSpinButtonHandle spin_button, out double step, out double page)
	{
		GtkSpinButtonExterns.gtk_spin_button_get_increments(spin_button, out step, out page);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetRange(this GtkSpinButtonHandle spin_button, double min, double max)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_range(spin_button, min, max);
		return spin_button;
	}

	public static GtkSpinButtonHandle GetRange(this GtkSpinButtonHandle spin_button, out double min, out double max)
	{
		GtkSpinButtonExterns.gtk_spin_button_get_range(spin_button, out min, out max);
		return spin_button;
	}

	public static double GetValue(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_value(spin_button);
	}

	public static int GetValueAsInt(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_value_as_int(spin_button);
	}

	public static GtkSpinButtonHandle SetValue(this GtkSpinButtonHandle spin_button, double value)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_value(spin_button, value);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetUpdatePolicy(this GtkSpinButtonHandle spin_button, GtkSpinButtonUpdatePolicy policy)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_update_policy(spin_button, policy);
		return spin_button;
	}

	public static GtkSpinButtonUpdatePolicy GetUpdatePolicy(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_update_policy(spin_button);
	}

	public static GtkSpinButtonHandle SetNumeric(this GtkSpinButtonHandle spin_button, int numeric)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_numeric(spin_button, numeric);
		return spin_button;
	}

	public static int GetNumeric(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_numeric(spin_button);
	}

	public static GtkSpinButtonHandle Spin(this GtkSpinButtonHandle spin_button, GtkSpinType direction, double increment)
	{
		GtkSpinButtonExterns.gtk_spin_button_spin(spin_button, direction, increment);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetWrap(this GtkSpinButtonHandle spin_button, int wrap)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_wrap(spin_button, wrap);
		return spin_button;
	}

	public static int GetWrap(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_wrap(spin_button);
	}

	public static GtkSpinButtonHandle SetSnapToTicks(this GtkSpinButtonHandle spin_button, int snap_to_ticks)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_snap_to_ticks(spin_button, snap_to_ticks);
		return spin_button;
	}

	public static int GetSnapToTicks(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_snap_to_ticks(spin_button);
	}

	public static GtkSpinButtonHandle SetClimbRate(this GtkSpinButtonHandle spin_button, double climb_rate)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_climb_rate(spin_button, climb_rate);
		return spin_button;
	}

	public static double GetClimbRate(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_climb_rate(spin_button);
	}

	public static GtkSpinButtonHandle Update(this GtkSpinButtonHandle spin_button)
	{
		GtkSpinButtonExterns.gtk_spin_button_update(spin_button);
		return spin_button;
	}
}
