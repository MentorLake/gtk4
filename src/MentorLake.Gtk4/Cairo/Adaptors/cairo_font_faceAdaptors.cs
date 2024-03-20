using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_font_faceAdaptors
{
    public static cairo_font_faceHandle CairoFontFaceReference(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_font_face_reference(font_face);
    }

    public static cairo_font_faceHandle CairoFontFaceDestroy(this cairo_font_faceHandle font_face)
    {
        cairo_font_faceExterns.cairo_font_face_destroy(font_face);
        return font_face;
    }

    public static uint CairoFontFaceGetReferenceCount(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_font_face_get_reference_count(font_face);
    }

    public static _cairo_status CairoFontFaceStatus(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_font_face_status(font_face);
    }

    public static _cairo_font_type CairoFontFaceGetType(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_font_face_get_type(font_face);
    }

    public static IntPtr CairoFontFaceGetUserData(this cairo_font_faceHandle font_face, cairo_user_data_keyHandle key)
    {
        return cairo_font_faceExterns.cairo_font_face_get_user_data(font_face, key);
    }

    public static _cairo_status CairoFontFaceSetUserData(this cairo_font_faceHandle font_face, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy)
    {
        return cairo_font_faceExterns.cairo_font_face_set_user_data(font_face, key, user_data, destroy);
    }

    public static cairo_scaled_fontHandle CairoScaledFontCreate(this cairo_font_faceHandle font_face, cairo_matrixHandle font_matrix, cairo_matrixHandle ctm, cairo_font_optionsHandle options)
    {
        return cairo_font_faceExterns.cairo_scaled_font_create(font_face, font_matrix, ctm, options);
    }

    public static string CairoToyFontFaceGetFamily(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_toy_font_face_get_family(font_face);
    }

    public static _cairo_font_slant CairoToyFontFaceGetSlant(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_toy_font_face_get_slant(font_face);
    }

    public static _cairo_font_weight CairoToyFontFaceGetWeight(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_toy_font_face_get_weight(font_face);
    }

    public static cairo_font_faceHandle CairoUserFontFaceSetInitFunc(this cairo_font_faceHandle font_face, cairo_user_scaled_font_init_func_t init_func)
    {
        cairo_font_faceExterns.cairo_user_font_face_set_init_func(font_face, init_func);
        return font_face;
    }

    public static cairo_font_faceHandle CairoUserFontFaceSetRenderGlyphFunc(this cairo_font_faceHandle font_face, cairo_user_scaled_font_render_glyph_func_t render_glyph_func)
    {
        cairo_font_faceExterns.cairo_user_font_face_set_render_glyph_func(font_face, render_glyph_func);
        return font_face;
    }

    public static cairo_font_faceHandle CairoUserFontFaceSetTextToGlyphsFunc(this cairo_font_faceHandle font_face, cairo_user_scaled_font_text_to_glyphs_func_t text_to_glyphs_func)
    {
        cairo_font_faceExterns.cairo_user_font_face_set_text_to_glyphs_func(font_face, text_to_glyphs_func);
        return font_face;
    }

    public static cairo_font_faceHandle CairoUserFontFaceSetUnicodeToGlyphFunc(this cairo_font_faceHandle font_face, cairo_user_scaled_font_unicode_to_glyph_func_t unicode_to_glyph_func)
    {
        cairo_font_faceExterns.cairo_user_font_face_set_unicode_to_glyph_func(font_face, unicode_to_glyph_func);
        return font_face;
    }

    public static IntPtr CairoUserFontFaceGetInitFunc(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_user_font_face_get_init_func(font_face);
    }

    public static IntPtr CairoUserFontFaceGetRenderGlyphFunc(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_user_font_face_get_render_glyph_func(font_face);
    }

    public static IntPtr CairoUserFontFaceGetTextToGlyphsFunc(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_user_font_face_get_text_to_glyphs_func(font_face);
    }

    public static IntPtr CairoUserFontFaceGetUnicodeToGlyphFunc(this cairo_font_faceHandle font_face)
    {
        return cairo_font_faceExterns.cairo_user_font_face_get_unicode_to_glyph_func(font_face);
    }
}
