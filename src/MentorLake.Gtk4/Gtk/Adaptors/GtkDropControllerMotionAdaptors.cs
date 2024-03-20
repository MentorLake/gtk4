using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropControllerMotionAdaptors
{
    public static int ContainsPointer(this GtkDropControllerMotionHandle self)
    {
        return GtkDropControllerMotionExterns.gtk_drop_controller_motion_contains_pointer(self);
    }

    public static GdkDropHandle GetDrop(this GtkDropControllerMotionHandle self)
    {
        return GtkDropControllerMotionExterns.gtk_drop_controller_motion_get_drop(self);
    }

    public static int IsPointer(this GtkDropControllerMotionHandle self)
    {
        return GtkDropControllerMotionExterns.gtk_drop_controller_motion_is_pointer(self);
    }
}
