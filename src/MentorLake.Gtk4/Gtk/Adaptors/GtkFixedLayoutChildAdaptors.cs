using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gsk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFixedLayoutChildAdaptors
{
    public static GtkFixedLayoutChildHandle SetTransform(this GtkFixedLayoutChildHandle child, GskTransformHandle transform)
    {
        GtkFixedLayoutChildExterns.gtk_fixed_layout_child_set_transform(child, transform);
        return child;
    }

    public static GskTransformHandle GetTransform(this GtkFixedLayoutChildHandle child)
    {
        return GtkFixedLayoutChildExterns.gtk_fixed_layout_child_get_transform(child);
    }
}
