using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureStylusAdaptors
{
    public static int GetAxis(this GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value)
    {
        return GtkGestureStylusExterns.gtk_gesture_stylus_get_axis(gesture, axis, out value);
    }

    public static int GetAxes(this GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values)
    {
        return GtkGestureStylusExterns.gtk_gesture_stylus_get_axes(gesture, axes, out values);
    }

    public static int GetBacklog(this GtkGestureStylusHandle gesture, out GdkTimeCoord[] backlog, out uint n_elems)
    {
        return GtkGestureStylusExterns.gtk_gesture_stylus_get_backlog(gesture, out backlog, out n_elems);
    }

    public static GdkDeviceToolHandle GetDeviceTool(this GtkGestureStylusHandle gesture)
    {
        return GtkGestureStylusExterns.gtk_gesture_stylus_get_device_tool(gesture);
    }
}
