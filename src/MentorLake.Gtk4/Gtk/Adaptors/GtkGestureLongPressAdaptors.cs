using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureLongPressAdaptors
{
    public static GtkGestureLongPressHandle SetDelayFactor(this GtkGestureLongPressHandle gesture, double delay_factor)
    {
        GtkGestureLongPressExterns.gtk_gesture_long_press_set_delay_factor(gesture, delay_factor);
        return gesture;
    }

    public static double GetDelayFactor(this GtkGestureLongPressHandle gesture)
    {
        return GtkGestureLongPressExterns.gtk_gesture_long_press_get_delay_factor(gesture);
    }
}
