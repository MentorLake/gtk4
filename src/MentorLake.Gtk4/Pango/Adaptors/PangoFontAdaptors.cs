using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontAdaptors
{
    public static PangoFontDescriptionHandle Describe(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_describe(font);
    }

    public static PangoFontDescriptionHandle DescribeWithAbsoluteSize(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_describe_with_absolute_size(font);
    }

    public static PangoCoverageHandle GetCoverage(this PangoFontHandle font, PangoLanguageHandle language)
    {
        return PangoFontExterns.pango_font_get_coverage(font, language);
    }

    public static PangoEngineShapeHandle FindShaper(this PangoFontHandle font, PangoLanguageHandle language, uint ch)
    {
        return PangoFontExterns.pango_font_find_shaper(font, language, ch);
    }

    public static PangoFontMetricsHandle GetMetrics(this PangoFontHandle font, PangoLanguageHandle language)
    {
        return PangoFontExterns.pango_font_get_metrics(font, language);
    }

    public static PangoFontHandle GetGlyphExtents(this PangoFontHandle font, PangoGlyph glyph, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoFontExterns.pango_font_get_glyph_extents(font, glyph, ink_rect, logical_rect);
        return font;
    }

    public static PangoFontMapHandle GetFontMap(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_get_font_map(font);
    }

    public static PangoFontFaceHandle GetFace(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_get_face(font);
    }

    public static int HasChar(this PangoFontHandle font, uint wc)
    {
        return PangoFontExterns.pango_font_has_char(font, wc);
    }

    public static PangoFontHandle GetFeatures(this PangoFontHandle font, IntPtr features, uint len, out uint num_features)
    {
        PangoFontExterns.pango_font_get_features(font, features, len, out num_features);
        return font;
    }

    public static IntPtr GetHbFont(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_get_hb_font(font);
    }

    public static PangoLanguageHandle[] GetLanguages(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_get_languages(font);
    }

    public static GBytesHandle Serialize(this PangoFontHandle font)
    {
        return PangoFontExterns.pango_font_serialize(font);
    }
}
