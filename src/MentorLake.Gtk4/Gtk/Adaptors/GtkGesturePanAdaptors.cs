using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGesturePanAdaptors
{
    public static GtkOrientation GetOrientation(this GtkGesturePanHandle gesture)
    {
        return GtkGesturePanExterns.gtk_gesture_pan_get_orientation(gesture);
    }

    public static GtkGesturePanHandle SetOrientation(this GtkGesturePanHandle gesture, GtkOrientation orientation)
    {
        GtkGesturePanExterns.gtk_gesture_pan_set_orientation(gesture, orientation);
        return gesture;
    }
}
