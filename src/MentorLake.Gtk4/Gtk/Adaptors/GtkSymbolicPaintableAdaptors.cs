using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSymbolicPaintableAdaptors
{
    public static GtkSymbolicPaintableHandle SnapshotSymbolic(this GtkSymbolicPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height, GdkRGBAHandle colors, nuint n_colors)
    {
        GtkSymbolicPaintableExterns.gtk_symbolic_paintable_snapshot_symbolic(paintable, snapshot, width, height, colors, n_colors);
        return paintable;
    }
}
