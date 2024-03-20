using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gdk;
public static class PangoLayoutAdaptors
{
    public static cairo_regionHandle GdkPangoLayoutGetClipRegion(this PangoLayoutHandle layout, int x_origin, int y_origin, int[] index_ranges, int n_ranges)
    {
        return PangoLayoutExterns.gdk_pango_layout_get_clip_region(layout, x_origin, y_origin, index_ranges, n_ranges);
    }
}
