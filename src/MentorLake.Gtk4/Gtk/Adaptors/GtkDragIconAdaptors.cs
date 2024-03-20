using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDragIconAdaptors
{
    public static GtkDragIconHandle SetChild(this GtkDragIconHandle self, GtkWidgetHandle child)
    {
        GtkDragIconExterns.gtk_drag_icon_set_child(self, child);
        return self;
    }

    public static GtkWidgetHandle GetChild(this GtkDragIconHandle self)
    {
        return GtkDragIconExterns.gtk_drag_icon_get_child(self);
    }
}
