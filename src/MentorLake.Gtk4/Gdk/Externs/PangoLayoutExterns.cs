using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gdk;

public static class PangoLayoutExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_pango_layout_get_clip_region")]
	internal static extern cairo_regionHandle gdk_pango_layout_get_clip_region(this PangoLayoutHandle layout, int x_origin, int y_origin, int[] index_ranges, int n_ranges);
}
