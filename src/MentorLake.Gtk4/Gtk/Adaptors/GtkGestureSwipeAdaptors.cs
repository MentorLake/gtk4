using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureSwipeAdaptors
{
    public static int GetVelocity(this GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y)
    {
        return GtkGestureSwipeExterns.gtk_gesture_swipe_get_velocity(gesture, out velocity_x, out velocity_y);
    }
}
