using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GdkDragAdaptors
{
    public static GtkWidgetHandle GtkDragIconGetForDrag(this GdkDragHandle drag)
    {
        return GdkDragExterns.gtk_drag_icon_get_for_drag(drag);
    }

    public static GdkDragHandle GtkDragIconSetFromPaintable(this GdkDragHandle drag, GdkPaintableHandle paintable, int hot_x, int hot_y)
    {
        GdkDragExterns.gtk_drag_icon_set_from_paintable(drag, paintable, hot_x, hot_y);
        return drag;
    }
}
