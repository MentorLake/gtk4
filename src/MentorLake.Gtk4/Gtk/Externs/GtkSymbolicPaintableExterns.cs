using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkSymbolicPaintableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_symbolic_paintable_snapshot_symbolic")]
	internal static extern void gtk_symbolic_paintable_snapshot_symbolic(this GtkSymbolicPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height, GdkRGBAHandle colors, nuint n_colors);
}
