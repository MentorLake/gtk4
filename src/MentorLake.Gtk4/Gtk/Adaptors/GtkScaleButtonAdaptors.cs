using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScaleButtonAdaptors
{
	public static GtkScaleButtonHandle SetIcons(this GtkScaleButtonHandle button, string[] icons)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_icons(button, icons);
		return button;
	}

	public static double GetValue(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_value(button);
	}

	public static GtkScaleButtonHandle SetValue(this GtkScaleButtonHandle button, double value)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_value(button, value);
		return button;
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_adjustment(button);
	}

	public static GtkScaleButtonHandle SetAdjustment(this GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_adjustment(button, adjustment);
		return button;
	}

	public static GtkWidgetHandle GetPlusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_plus_button(button);
	}

	public static GtkWidgetHandle GetMinusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_minus_button(button);
	}

	public static GtkWidgetHandle GetPopup(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_popup(button);
	}
}
