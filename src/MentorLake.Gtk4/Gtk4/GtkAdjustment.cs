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

public class GtkAdjustmentHandle : GInitiallyUnownedHandle
{
	public static GtkAdjustmentHandle New(double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		return GtkAdjustmentExterns.gtk_adjustment_new(value, lower, upper, step_increment, page_increment, page_size);
	}
}

public class GtkAdjustmentSignal
{
	public string Value { get; set; }
	public GtkAdjustmentSignal(string value) => Value = value;
}

public static class GtkAdjustmentSignals
{
	public static GtkAdjustmentSignal Changed = new("changed");
	public static GtkAdjustmentSignal ValueChanged = new("value-changed");
}

public static class GtkAdjustmentHandleExtensions
{
	public static GtkAdjustmentHandle ClampPage(this GtkAdjustmentHandle adjustment, double lower, double upper)
	{
		GtkAdjustmentExterns.gtk_adjustment_clamp_page(adjustment, lower, upper);
		return adjustment;
	}

	public static GtkAdjustmentHandle Configure(this GtkAdjustmentHandle adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		GtkAdjustmentExterns.gtk_adjustment_configure(adjustment, value, lower, upper, step_increment, page_increment, page_size);
		return adjustment;
	}

	public static double GetLower(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_lower(adjustment);
	}

	public static double GetMinimumIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_minimum_increment(adjustment);
	}

	public static double GetPageIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_page_increment(adjustment);
	}

	public static double GetPageSize(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_page_size(adjustment);
	}

	public static double GetStepIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_step_increment(adjustment);
	}

	public static double GetUpper(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_upper(adjustment);
	}

	public static double GetValue(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_value(adjustment);
	}

	public static GtkAdjustmentHandle SetLower(this GtkAdjustmentHandle adjustment, double lower)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_lower(adjustment, lower);
		return adjustment;
	}

	public static GtkAdjustmentHandle SetPageIncrement(this GtkAdjustmentHandle adjustment, double page_increment)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_page_increment(adjustment, page_increment);
		return adjustment;
	}

	public static GtkAdjustmentHandle SetPageSize(this GtkAdjustmentHandle adjustment, double page_size)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_page_size(adjustment, page_size);
		return adjustment;
	}

	public static GtkAdjustmentHandle SetStepIncrement(this GtkAdjustmentHandle adjustment, double step_increment)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_step_increment(adjustment, step_increment);
		return adjustment;
	}

	public static GtkAdjustmentHandle SetUpper(this GtkAdjustmentHandle adjustment, double upper)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_upper(adjustment, upper);
		return adjustment;
	}

	public static GtkAdjustmentHandle SetValue(this GtkAdjustmentHandle adjustment, double value)
	{
		GtkAdjustmentExterns.gtk_adjustment_set_value(adjustment, value);
		return adjustment;
	}

	public static GtkAdjustmentHandle Connect(this GtkAdjustmentHandle instance, GtkAdjustmentSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkAdjustmentExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_clamp_page(GtkAdjustmentHandle adjustment, double lower, double upper);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_configure(GtkAdjustmentHandle adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_lower(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_minimum_increment(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_page_increment(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_page_size(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_step_increment(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_upper(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_adjustment_get_value(GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_set_lower(GtkAdjustmentHandle adjustment, double lower);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_set_page_increment(GtkAdjustmentHandle adjustment, double page_increment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_set_page_size(GtkAdjustmentHandle adjustment, double page_size);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_set_step_increment(GtkAdjustmentHandle adjustment, double step_increment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_set_upper(GtkAdjustmentHandle adjustment, double upper);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_adjustment_set_value(GtkAdjustmentHandle adjustment, double value);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);
}
