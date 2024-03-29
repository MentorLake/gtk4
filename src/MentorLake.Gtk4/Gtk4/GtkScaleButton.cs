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

public class GtkScaleButtonHandle : GtkWidgetHandle
{
	public static GtkScaleButtonHandle New(double min, double max, double step, string[] icons)
	{
		return GtkScaleButtonExterns.gtk_scale_button_new(min, max, step, icons);
	}

}

public class GtkScaleButtonSignal
{
	public string Value { get; set; }
	public GtkScaleButtonSignal(string value) => Value = value;
}

public static class GtkScaleButtonSignals
{
	public static GtkScaleButtonSignal Popdown = new("popdown");
	public static GtkScaleButtonSignal Popup = new("popup");
	public static GtkScaleButtonSignal ValueChanged = new("value-changed");
}

public static class GtkScaleButtonHandleExtensions
{
	public static bool GetActive(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_active(button);
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_adjustment(button);
	}

	public static bool GetHasFrame(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_has_frame(button);
	}

	public static GtkWidgetHandle GetMinusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_minus_button(button);
	}

	public static GtkWidgetHandle GetPlusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_plus_button(button);
	}

	public static GtkWidgetHandle GetPopup(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_popup(button);
	}

	public static double GetValue(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_value(button);
	}

	public static GtkScaleButtonHandle SetAdjustment(this GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_adjustment(button, adjustment);
		return button;
	}

	public static GtkScaleButtonHandle SetHasFrame(this GtkScaleButtonHandle button, bool has_frame)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_has_frame(button, has_frame);
		return button;
	}

	public static GtkScaleButtonHandle SetIcons(this GtkScaleButtonHandle button, string[] icons)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_icons(button, icons);
		return button;
	}

	public static GtkScaleButtonHandle SetValue(this GtkScaleButtonHandle button, double value)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_value(button, value);
		return button;
	}

	public static GtkScaleButtonHandle Connect(this GtkScaleButtonHandle instance, GtkScaleButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkScaleButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScaleButtonHandle gtk_scale_button_new(double min, double max, double step, string[] icons);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scale_button_get_active(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scale_button_get_adjustment(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scale_button_get_has_frame(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_minus_button(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_plus_button(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_popup(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_scale_button_get_value(GtkScaleButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_adjustment(GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_has_frame(GtkScaleButtonHandle button, bool has_frame);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_icons(GtkScaleButtonHandle button, string[] icons);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_value(GtkScaleButtonHandle button, double value);
}
