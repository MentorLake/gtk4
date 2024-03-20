using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontsetSimpleAdaptors
{
    public static PangoFontsetSimpleHandle Append(this PangoFontsetSimpleHandle fontset, PangoFontHandle font)
    {
        PangoFontsetSimpleExterns.pango_fontset_simple_append(fontset, font);
        return fontset;
    }

    public static int Size(this PangoFontsetSimpleHandle fontset)
    {
        return PangoFontsetSimpleExterns.pango_fontset_simple_size(fontset);
    }
}
