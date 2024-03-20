using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCenterLayoutAdaptors
{
    public static GtkCenterLayoutHandle SetOrientation(this GtkCenterLayoutHandle self, GtkOrientation orientation)
    {
        GtkCenterLayoutExterns.gtk_center_layout_set_orientation(self, orientation);
        return self;
    }

    public static GtkOrientation GetOrientation(this GtkCenterLayoutHandle self)
    {
        return GtkCenterLayoutExterns.gtk_center_layout_get_orientation(self);
    }

    public static GtkCenterLayoutHandle SetBaselinePosition(this GtkCenterLayoutHandle self, GtkBaselinePosition baseline_position)
    {
        GtkCenterLayoutExterns.gtk_center_layout_set_baseline_position(self, baseline_position);
        return self;
    }

    public static GtkBaselinePosition GetBaselinePosition(this GtkCenterLayoutHandle self)
    {
        return GtkCenterLayoutExterns.gtk_center_layout_get_baseline_position(self);
    }

    public static GtkCenterLayoutHandle SetStartWidget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget)
    {
        GtkCenterLayoutExterns.gtk_center_layout_set_start_widget(self, widget);
        return self;
    }

    public static GtkWidgetHandle GetStartWidget(this GtkCenterLayoutHandle self)
    {
        return GtkCenterLayoutExterns.gtk_center_layout_get_start_widget(self);
    }

    public static GtkCenterLayoutHandle SetCenterWidget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget)
    {
        GtkCenterLayoutExterns.gtk_center_layout_set_center_widget(self, widget);
        return self;
    }

    public static GtkWidgetHandle GetCenterWidget(this GtkCenterLayoutHandle self)
    {
        return GtkCenterLayoutExterns.gtk_center_layout_get_center_widget(self);
    }

    public static GtkCenterLayoutHandle SetEndWidget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget)
    {
        GtkCenterLayoutExterns.gtk_center_layout_set_end_widget(self, widget);
        return self;
    }

    public static GtkWidgetHandle GetEndWidget(this GtkCenterLayoutHandle self)
    {
        return GtkCenterLayoutExterns.gtk_center_layout_get_end_widget(self);
    }
}
