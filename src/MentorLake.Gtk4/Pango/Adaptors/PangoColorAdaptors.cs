using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoColorAdaptors
{
    public static PangoColorHandle Copy(this PangoColorHandle src)
    {
        return PangoColorExterns.pango_color_copy(src);
    }

    public static PangoColorHandle Free(this PangoColorHandle color)
    {
        PangoColorExterns.pango_color_free(color);
        return color;
    }

    public static int Parse(this PangoColorHandle color, string spec)
    {
        return PangoColorExterns.pango_color_parse(color, spec);
    }

    public static int ParseWithAlpha(this PangoColorHandle color, out ushort alpha, string spec)
    {
        return PangoColorExterns.pango_color_parse_with_alpha(color, out alpha, spec);
    }

    public static string ToString(this PangoColorHandle color)
    {
        return PangoColorExterns.pango_color_to_string(color);
    }
}
