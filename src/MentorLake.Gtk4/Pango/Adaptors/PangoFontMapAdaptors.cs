using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontMapAdaptors
{
    public static PangoContextHandle CreateContext(this PangoFontMapHandle fontmap)
    {
        return PangoFontMapExterns.pango_font_map_create_context(fontmap);
    }

    public static PangoFontHandle LoadFont(this PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc)
    {
        return PangoFontMapExterns.pango_font_map_load_font(fontmap, context, desc);
    }

    public static PangoFontsetHandle LoadFontset(this PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language)
    {
        return PangoFontMapExterns.pango_font_map_load_fontset(fontmap, context, desc, language);
    }

    public static PangoFontMapHandle ListFamilies(this PangoFontMapHandle fontmap, out PangoFontFamily[] families, out int n_families)
    {
        PangoFontMapExterns.pango_font_map_list_families(fontmap, out families, out n_families);
        return fontmap;
    }

    public static uint GetSerial(this PangoFontMapHandle fontmap)
    {
        return PangoFontMapExterns.pango_font_map_get_serial(fontmap);
    }

    public static PangoFontMapHandle Changed(this PangoFontMapHandle fontmap)
    {
        PangoFontMapExterns.pango_font_map_changed(fontmap);
        return fontmap;
    }

    public static PangoFontFamilyHandle GetFamily(this PangoFontMapHandle fontmap, string name)
    {
        return PangoFontMapExterns.pango_font_map_get_family(fontmap, name);
    }
}
