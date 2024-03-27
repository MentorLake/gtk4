using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkSymbolicPaintableHandle  : GdkPaintableHandle
{
}

public static class GtkSymbolicPaintableHandleExtensions
{
	public static GtkSymbolicPaintableHandle SnapshotSymbolic(this GtkSymbolicPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height, GdkRGBA[] colors, int n_colors)
	{
		GtkSymbolicPaintableExterns.gtk_symbolic_paintable_snapshot_symbolic(paintable, snapshot, width, height, colors, n_colors);
		return paintable;
	}

}

internal class GtkSymbolicPaintableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_symbolic_paintable_snapshot_symbolic(GtkSymbolicPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height, GdkRGBA[] colors, int n_colors);
}
