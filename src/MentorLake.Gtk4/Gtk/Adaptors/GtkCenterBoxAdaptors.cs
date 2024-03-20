using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCenterBoxAdaptors
{
	public static GtkCenterBoxHandle SetStartWidget(this GtkCenterBoxHandle self, GtkWidgetHandle child)
	{
		GtkCenterBoxExterns.gtk_center_box_set_start_widget(self, child);
		return self;
	}

	public static GtkCenterBoxHandle SetCenterWidget(this GtkCenterBoxHandle self, GtkWidgetHandle child)
	{
		GtkCenterBoxExterns.gtk_center_box_set_center_widget(self, child);
		return self;
	}

	public static GtkCenterBoxHandle SetEndWidget(this GtkCenterBoxHandle self, GtkWidgetHandle child)
	{
		GtkCenterBoxExterns.gtk_center_box_set_end_widget(self, child);
		return self;
	}

	public static GtkWidgetHandle GetStartWidget(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_start_widget(self);
	}

	public static GtkWidgetHandle GetCenterWidget(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_center_widget(self);
	}

	public static GtkWidgetHandle GetEndWidget(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_end_widget(self);
	}

	public static GtkCenterBoxHandle SetBaselinePosition(this GtkCenterBoxHandle self, GtkBaselinePosition position)
	{
		GtkCenterBoxExterns.gtk_center_box_set_baseline_position(self, position);
		return self;
	}

	public static GtkBaselinePosition GetBaselinePosition(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_baseline_position(self);
	}
}
