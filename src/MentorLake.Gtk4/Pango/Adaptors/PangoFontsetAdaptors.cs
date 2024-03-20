using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontsetAdaptors
{
    public static PangoFontHandle GetFont(this PangoFontsetHandle fontset, uint wc)
    {
        return PangoFontsetExterns.pango_fontset_get_font(fontset, wc);
    }

    public static PangoFontMetricsHandle GetMetrics(this PangoFontsetHandle fontset)
    {
        return PangoFontsetExterns.pango_fontset_get_metrics(fontset);
    }

    public static PangoFontsetHandle Foreach(this PangoFontsetHandle fontset, PangoFontsetForeachFunc func, IntPtr data)
    {
        PangoFontsetExterns.pango_fontset_foreach(fontset, func, data);
        return fontset;
    }
}
