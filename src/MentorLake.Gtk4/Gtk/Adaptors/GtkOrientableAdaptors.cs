using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkOrientableAdaptors
{
    public static GtkOrientableHandle SetOrientation(this GtkOrientableHandle orientable, GtkOrientation orientation)
    {
        GtkOrientableExterns.gtk_orientable_set_orientation(orientable, orientation);
        return orientable;
    }

    public static GtkOrientation GetOrientation(this GtkOrientableHandle orientable)
    {
        return GtkOrientableExterns.gtk_orientable_get_orientation(orientable);
    }
}
