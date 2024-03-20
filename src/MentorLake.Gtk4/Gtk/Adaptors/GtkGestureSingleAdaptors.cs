using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureSingleAdaptors
{
    public static int GetTouchOnly(this GtkGestureSingleHandle gesture)
    {
        return GtkGestureSingleExterns.gtk_gesture_single_get_touch_only(gesture);
    }

    public static GtkGestureSingleHandle SetTouchOnly(this GtkGestureSingleHandle gesture, int touch_only)
    {
        GtkGestureSingleExterns.gtk_gesture_single_set_touch_only(gesture, touch_only);
        return gesture;
    }

    public static int GetExclusive(this GtkGestureSingleHandle gesture)
    {
        return GtkGestureSingleExterns.gtk_gesture_single_get_exclusive(gesture);
    }

    public static GtkGestureSingleHandle SetExclusive(this GtkGestureSingleHandle gesture, int exclusive)
    {
        GtkGestureSingleExterns.gtk_gesture_single_set_exclusive(gesture, exclusive);
        return gesture;
    }

    public static uint GetButton(this GtkGestureSingleHandle gesture)
    {
        return GtkGestureSingleExterns.gtk_gesture_single_get_button(gesture);
    }

    public static GtkGestureSingleHandle SetButton(this GtkGestureSingleHandle gesture, uint button)
    {
        GtkGestureSingleExterns.gtk_gesture_single_set_button(gesture, button);
        return gesture;
    }

    public static uint GetCurrentButton(this GtkGestureSingleHandle gesture)
    {
        return GtkGestureSingleExterns.gtk_gesture_single_get_current_button(gesture);
    }

    public static GdkEventSequenceHandle GetCurrentSequence(this GtkGestureSingleHandle gesture)
    {
        return GtkGestureSingleExterns.gtk_gesture_single_get_current_sequence(gesture);
    }
}
