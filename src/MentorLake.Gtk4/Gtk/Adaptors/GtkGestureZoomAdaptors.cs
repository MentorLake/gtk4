using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureZoomAdaptors
{
    public static double GetScaleDelta(this GtkGestureZoomHandle gesture)
    {
        return GtkGestureZoomExterns.gtk_gesture_zoom_get_scale_delta(gesture);
    }
}
