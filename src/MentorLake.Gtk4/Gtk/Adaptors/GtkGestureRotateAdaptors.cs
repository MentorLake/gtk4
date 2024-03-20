using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureRotateAdaptors
{
    public static double GetAngleDelta(this GtkGestureRotateHandle gesture)
    {
        return GtkGestureRotateExterns.gtk_gesture_rotate_get_angle_delta(gesture);
    }
}
