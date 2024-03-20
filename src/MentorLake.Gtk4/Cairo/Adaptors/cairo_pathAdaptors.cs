using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_pathAdaptors
{
    public static cairo_pathHandle CairoPathDestroy(this cairo_pathHandle path)
    {
        cairo_pathExterns.cairo_path_destroy(path);
        return path;
    }
}
