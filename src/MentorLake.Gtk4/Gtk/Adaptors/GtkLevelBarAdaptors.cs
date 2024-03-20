using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLevelBarAdaptors
{
	public static GtkLevelBarHandle SetMode(this GtkLevelBarHandle self, GtkLevelBarMode mode)
	{
		GtkLevelBarExterns.gtk_level_bar_set_mode(self, mode);
		return self;
	}

	public static GtkLevelBarMode GetMode(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_mode(self);
	}

	public static GtkLevelBarHandle SetValue(this GtkLevelBarHandle self, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_set_value(self, value);
		return self;
	}

	public static double GetValue(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_value(self);
	}

	public static GtkLevelBarHandle SetMinValue(this GtkLevelBarHandle self, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_set_min_value(self, value);
		return self;
	}

	public static double GetMinValue(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_min_value(self);
	}

	public static GtkLevelBarHandle SetMaxValue(this GtkLevelBarHandle self, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_set_max_value(self, value);
		return self;
	}

	public static double GetMaxValue(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_max_value(self);
	}

	public static GtkLevelBarHandle SetInverted(this GtkLevelBarHandle self, int inverted)
	{
		GtkLevelBarExterns.gtk_level_bar_set_inverted(self, inverted);
		return self;
	}

	public static int GetInverted(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_inverted(self);
	}

	public static GtkLevelBarHandle AddOffsetValue(this GtkLevelBarHandle self, string name, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_add_offset_value(self, name, value);
		return self;
	}

	public static GtkLevelBarHandle RemoveOffsetValue(this GtkLevelBarHandle self, string name)
	{
		GtkLevelBarExterns.gtk_level_bar_remove_offset_value(self, name);
		return self;
	}

	public static int GetOffsetValue(this GtkLevelBarHandle self, string name, out double value)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_offset_value(self, name, out value);
	}

	public static GtkLevelBarHandle NewForInterval(double min_value, double max_value)
	{
		return GtkLevelBarExterns.gtk_level_bar_new_for_interval(min_value, max_value);
	}
}
