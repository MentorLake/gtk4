using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEventControllerMotionAdaptors
{
    public static int ContainsPointer(this GtkEventControllerMotionHandle self)
    {
        return GtkEventControllerMotionExterns.gtk_event_controller_motion_contains_pointer(self);
    }

    public static int IsPointer(this GtkEventControllerMotionHandle self)
    {
        return GtkEventControllerMotionExterns.gtk_event_controller_motion_is_pointer(self);
    }
}
