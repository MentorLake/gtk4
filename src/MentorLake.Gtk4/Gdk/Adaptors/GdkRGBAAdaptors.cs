using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkRGBAAdaptors
{
    public static GdkRGBAHandle GdkRgbaCopy(this GdkRGBAHandle rgba)
    {
        return GdkRGBAExterns.gdk_rgba_copy(rgba);
    }

    public static GdkRGBAHandle GdkRgbaFree(this GdkRGBAHandle rgba)
    {
        GdkRGBAExterns.gdk_rgba_free(rgba);
        return rgba;
    }

    public static int GdkRgbaIsClear(this GdkRGBAHandle rgba)
    {
        return GdkRGBAExterns.gdk_rgba_is_clear(rgba);
    }

    public static int GdkRgbaIsOpaque(this GdkRGBAHandle rgba)
    {
        return GdkRGBAExterns.gdk_rgba_is_opaque(rgba);
    }

    public static int GdkRgbaParse(this GdkRGBAHandle rgba, string spec)
    {
        return GdkRGBAExterns.gdk_rgba_parse(rgba, spec);
    }

    public static string GdkRgbaToString(this GdkRGBAHandle rgba)
    {
        return GdkRGBAExterns.gdk_rgba_to_string(rgba);
    }
}
