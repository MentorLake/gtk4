using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureDragAdaptors
{
    public static int GetStartPoint(this GtkGestureDragHandle gesture, out double x, out double y)
    {
        return GtkGestureDragExterns.gtk_gesture_drag_get_start_point(gesture, out x, out y);
    }

    public static int GetOffset(this GtkGestureDragHandle gesture, out double x, out double y)
    {
        return GtkGestureDragExterns.gtk_gesture_drag_get_offset(gesture, out x, out y);
    }
}
