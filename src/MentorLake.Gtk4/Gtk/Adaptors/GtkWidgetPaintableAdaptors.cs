using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWidgetPaintableAdaptors
{
    public static GtkWidgetHandle GetWidget(this GtkWidgetPaintableHandle self)
    {
        return GtkWidgetPaintableExterns.gtk_widget_paintable_get_widget(self);
    }

    public static GtkWidgetPaintableHandle SetWidget(this GtkWidgetPaintableHandle self, GtkWidgetHandle widget)
    {
        GtkWidgetPaintableExterns.gtk_widget_paintable_set_widget(self, widget);
        return self;
    }
}
