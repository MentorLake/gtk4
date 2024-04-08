using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkSpinButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkConstraintTargetHandle, GtkEditableHandle, GtkOrientableHandle
{
	public static GtkSpinButtonHandle New(GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		return GtkSpinButtonExterns.gtk_spin_button_new(adjustment, climb_rate, digits);
	}

	public static GtkSpinButtonHandle NewWithRange(double min, double max, double step)
	{
		return GtkSpinButtonExterns.gtk_spin_button_new_with_range(min, max, step);
	}

}

public class GtkSpinButtonSignal
{
	public string Value { get; set; }
	public GtkSpinButtonSignal(string value) => Value = value;
}

public static class GtkSpinButtonSignals
{
	public static GtkSpinButtonSignal Activate = new("activate");
	public static GtkSpinButtonSignal ChangeValue = new("change-value");
	public static GtkSpinButtonSignal Input = new("input");
	public static GtkSpinButtonSignal Output = new("output");
	public static GtkSpinButtonSignal ValueChanged = new("value-changed");
	public static GtkSpinButtonSignal Wrapped = new("wrapped");
}

public static class GtkSpinButtonHandleExtensions
{
	public static GtkSpinButtonHandle Configure(this GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		GtkSpinButtonExterns.gtk_spin_button_configure(spin_button, adjustment, climb_rate, digits);
		return spin_button;
	}

	public static bool GetActivatesDefault(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_activates_default(spin_button);
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_adjustment(spin_button);
	}

	public static double GetClimbRate(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_climb_rate(spin_button);
	}

	public static uint GetDigits(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_digits(spin_button);
	}

	public static GtkSpinButtonHandle GetIncrements(this GtkSpinButtonHandle spin_button, out double step, out double page)
	{
		GtkSpinButtonExterns.gtk_spin_button_get_increments(spin_button, out step, out page);
		return spin_button;
	}

	public static bool GetNumeric(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_numeric(spin_button);
	}

	public static GtkSpinButtonHandle GetRange(this GtkSpinButtonHandle spin_button, out double min, out double max)
	{
		GtkSpinButtonExterns.gtk_spin_button_get_range(spin_button, out min, out max);
		return spin_button;
	}

	public static bool GetSnapToTicks(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_snap_to_ticks(spin_button);
	}

	public static GtkSpinButtonUpdatePolicy GetUpdatePolicy(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_update_policy(spin_button);
	}

	public static double GetValue(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_value(spin_button);
	}

	public static int GetValueAsInt(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_value_as_int(spin_button);
	}

	public static bool GetWrap(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_wrap(spin_button);
	}

	public static GtkSpinButtonHandle SetActivatesDefault(this GtkSpinButtonHandle spin_button, bool activates_default)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_activates_default(spin_button, activates_default);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetAdjustment(this GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_adjustment(spin_button, adjustment);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetClimbRate(this GtkSpinButtonHandle spin_button, double climb_rate)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_climb_rate(spin_button, climb_rate);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetDigits(this GtkSpinButtonHandle spin_button, uint digits)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_digits(spin_button, digits);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetIncrements(this GtkSpinButtonHandle spin_button, double step, double page)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_increments(spin_button, step, page);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetNumeric(this GtkSpinButtonHandle spin_button, bool numeric)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_numeric(spin_button, numeric);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetRange(this GtkSpinButtonHandle spin_button, double min, double max)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_range(spin_button, min, max);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetSnapToTicks(this GtkSpinButtonHandle spin_button, bool snap_to_ticks)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_snap_to_ticks(spin_button, snap_to_ticks);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetUpdatePolicy(this GtkSpinButtonHandle spin_button, GtkSpinButtonUpdatePolicy policy)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_update_policy(spin_button, policy);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetValue(this GtkSpinButtonHandle spin_button, double value)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_value(spin_button, value);
		return spin_button;
	}

	public static GtkSpinButtonHandle SetWrap(this GtkSpinButtonHandle spin_button, bool wrap)
	{
		GtkSpinButtonExterns.gtk_spin_button_set_wrap(spin_button, wrap);
		return spin_button;
	}

	public static GtkSpinButtonHandle Spin(this GtkSpinButtonHandle spin_button, GtkSpinType direction, double increment)
	{
		GtkSpinButtonExterns.gtk_spin_button_spin(spin_button, direction, increment);
		return spin_button;
	}

	public static GtkSpinButtonHandle Update(this GtkSpinButtonHandle spin_button)
	{
		GtkSpinButtonExterns.gtk_spin_button_update(spin_button);
		return spin_button;
	}

	public static GtkSpinButtonHandle Connect(this GtkSpinButtonHandle instance, GtkSpinButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkSpinButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSpinButtonHandle gtk_spin_button_new(GtkAdjustmentHandle adjustment, double climb_rate, uint digits);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSpinButtonHandle gtk_spin_button_new_with_range(double min, double max, double step);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_configure(GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment, double climb_rate, uint digits);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_spin_button_get_activates_default(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_spin_button_get_adjustment(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_spin_button_get_climb_rate(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_spin_button_get_digits(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_get_increments(GtkSpinButtonHandle spin_button, out double step, out double page);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_spin_button_get_numeric(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_get_range(GtkSpinButtonHandle spin_button, out double min, out double max);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_spin_button_get_snap_to_ticks(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_spin_button_get_value(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_spin_button_get_value_as_int(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_spin_button_get_wrap(GtkSpinButtonHandle spin_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_activates_default(GtkSpinButtonHandle spin_button, bool activates_default);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_adjustment(GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_climb_rate(GtkSpinButtonHandle spin_button, double climb_rate);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_digits(GtkSpinButtonHandle spin_button, uint digits);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_increments(GtkSpinButtonHandle spin_button, double step, double page);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_numeric(GtkSpinButtonHandle spin_button, bool numeric);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_range(GtkSpinButtonHandle spin_button, double min, double max);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_snap_to_ticks(GtkSpinButtonHandle spin_button, bool snap_to_ticks);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_update_policy(GtkSpinButtonHandle spin_button, GtkSpinButtonUpdatePolicy policy);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_value(GtkSpinButtonHandle spin_button, double value);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_set_wrap(GtkSpinButtonHandle spin_button, bool wrap);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_spin(GtkSpinButtonHandle spin_button, GtkSpinType direction, double increment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spin_button_update(GtkSpinButtonHandle spin_button);
}
