using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_scaled_fontAdaptors
{
    public static cairo_scaled_fontHandle CairoScaledFontReference(this cairo_scaled_fontHandle scaled_font)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_reference(scaled_font);
    }

    public static cairo_scaled_fontHandle CairoScaledFontDestroy(this cairo_scaled_fontHandle scaled_font)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_destroy(scaled_font);
        return scaled_font;
    }

    public static uint CairoScaledFontGetReferenceCount(this cairo_scaled_fontHandle scaled_font)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_get_reference_count(scaled_font);
    }

    public static _cairo_status CairoScaledFontStatus(this cairo_scaled_fontHandle scaled_font)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_status(scaled_font);
    }

    public static _cairo_font_type CairoScaledFontGetType(this cairo_scaled_fontHandle scaled_font)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_get_type(scaled_font);
    }

    public static IntPtr CairoScaledFontGetUserData(this cairo_scaled_fontHandle scaled_font, cairo_user_data_keyHandle key)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_get_user_data(scaled_font, key);
    }

    public static _cairo_status CairoScaledFontSetUserData(this cairo_scaled_fontHandle scaled_font, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_set_user_data(scaled_font, key, user_data, destroy);
    }

    public static cairo_scaled_fontHandle CairoScaledFontExtents(this cairo_scaled_fontHandle scaled_font, cairo_font_extents_tHandle extents)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_extents(scaled_font, extents);
        return scaled_font;
    }

    public static cairo_scaled_fontHandle CairoScaledFontTextExtents(this cairo_scaled_fontHandle scaled_font, string utf8, cairo_text_extents_tHandle extents)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_text_extents(scaled_font, utf8, extents);
        return scaled_font;
    }

    public static cairo_scaled_fontHandle CairoScaledFontGlyphExtents(this cairo_scaled_fontHandle scaled_font, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_glyph_extents(scaled_font, glyphs, num_glyphs, extents);
        return scaled_font;
    }

    public static _cairo_status CairoScaledFontTextToGlyphs(this cairo_scaled_fontHandle scaled_font, double x, double y, string utf8, int utf8_len, cairo_glyph_tHandle[] glyphs, ref int num_glyphs, cairo_text_cluster_tHandle[] clusters, ref int num_clusters, out _cairo_text_cluster_flags cluster_flags)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_text_to_glyphs(scaled_font, x, y, utf8, utf8_len, glyphs, ref num_glyphs, clusters, ref num_clusters, out cluster_flags);
    }

    public static cairo_font_faceHandle CairoScaledFontGetFontFace(this cairo_scaled_fontHandle scaled_font)
    {
        return cairo_scaled_fontExterns.cairo_scaled_font_get_font_face(scaled_font);
    }

    public static cairo_scaled_fontHandle CairoScaledFontGetFontMatrix(this cairo_scaled_fontHandle scaled_font, cairo_matrixHandle font_matrix)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_get_font_matrix(scaled_font, font_matrix);
        return scaled_font;
    }

    public static cairo_scaled_fontHandle CairoScaledFontGetCtm(this cairo_scaled_fontHandle scaled_font, cairo_matrixHandle ctm)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_get_ctm(scaled_font, ctm);
        return scaled_font;
    }

    public static cairo_scaled_fontHandle CairoScaledFontGetScaleMatrix(this cairo_scaled_fontHandle scaled_font, cairo_matrixHandle scale_matrix)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_get_scale_matrix(scaled_font, scale_matrix);
        return scaled_font;
    }

    public static cairo_scaled_fontHandle CairoScaledFontGetFontOptions(this cairo_scaled_fontHandle scaled_font, cairo_font_optionsHandle options)
    {
        cairo_scaled_fontExterns.cairo_scaled_font_get_font_options(scaled_font, options);
        return scaled_font;
    }
}
