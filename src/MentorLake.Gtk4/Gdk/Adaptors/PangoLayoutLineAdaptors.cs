using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gdk;
public static class PangoLayoutLineAdaptors
{
    public static cairo_regionHandle GdkPangoLayoutLineGetClipRegion(this PangoLayoutLineHandle line, int x_origin, int y_origin, int[] index_ranges, int n_ranges)
    {
        return PangoLayoutLineExterns.gdk_pango_layout_line_get_clip_region(line, x_origin, y_origin, index_ranges, n_ranges);
    }
}
