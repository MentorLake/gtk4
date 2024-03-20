using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoRendererAdaptors
{
    public static PangoRendererHandle DrawLayout(this PangoRendererHandle renderer, PangoLayoutHandle layout, int x, int y)
    {
        PangoRendererExterns.pango_renderer_draw_layout(renderer, layout, x, y);
        return renderer;
    }

    public static PangoRendererHandle DrawLayoutLine(this PangoRendererHandle renderer, PangoLayoutLineHandle line, int x, int y)
    {
        PangoRendererExterns.pango_renderer_draw_layout_line(renderer, line, x, y);
        return renderer;
    }

    public static PangoRendererHandle DrawGlyphs(this PangoRendererHandle renderer, PangoFontHandle font, PangoGlyphStringHandle glyphs, int x, int y)
    {
        PangoRendererExterns.pango_renderer_draw_glyphs(renderer, font, glyphs, x, y);
        return renderer;
    }

    public static PangoRendererHandle DrawGlyphItem(this PangoRendererHandle renderer, string text, PangoGlyphItemHandle glyph_item, int x, int y)
    {
        PangoRendererExterns.pango_renderer_draw_glyph_item(renderer, text, glyph_item, x, y);
        return renderer;
    }

    public static PangoRendererHandle DrawRectangle(this PangoRendererHandle renderer, PangoRenderPart part, int x, int y, int width, int height)
    {
        PangoRendererExterns.pango_renderer_draw_rectangle(renderer, part, x, y, width, height);
        return renderer;
    }

    public static PangoRendererHandle DrawErrorUnderline(this PangoRendererHandle renderer, int x, int y, int width, int height)
    {
        PangoRendererExterns.pango_renderer_draw_error_underline(renderer, x, y, width, height);
        return renderer;
    }

    public static PangoRendererHandle DrawTrapezoid(this PangoRendererHandle renderer, PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22)
    {
        PangoRendererExterns.pango_renderer_draw_trapezoid(renderer, part, y1_, x11, x21, y2, x12, x22);
        return renderer;
    }

    public static PangoRendererHandle DrawGlyph(this PangoRendererHandle renderer, PangoFontHandle font, PangoGlyph glyph, double x, double y)
    {
        PangoRendererExterns.pango_renderer_draw_glyph(renderer, font, glyph, x, y);
        return renderer;
    }

    public static PangoRendererHandle Activate(this PangoRendererHandle renderer)
    {
        PangoRendererExterns.pango_renderer_activate(renderer);
        return renderer;
    }

    public static PangoRendererHandle Deactivate(this PangoRendererHandle renderer)
    {
        PangoRendererExterns.pango_renderer_deactivate(renderer);
        return renderer;
    }

    public static PangoRendererHandle PartChanged(this PangoRendererHandle renderer, PangoRenderPart part)
    {
        PangoRendererExterns.pango_renderer_part_changed(renderer, part);
        return renderer;
    }

    public static PangoRendererHandle SetColor(this PangoRendererHandle renderer, PangoRenderPart part, PangoColorHandle color)
    {
        PangoRendererExterns.pango_renderer_set_color(renderer, part, color);
        return renderer;
    }

    public static PangoColorHandle GetColor(this PangoRendererHandle renderer, PangoRenderPart part)
    {
        return PangoRendererExterns.pango_renderer_get_color(renderer, part);
    }

    public static PangoRendererHandle SetAlpha(this PangoRendererHandle renderer, PangoRenderPart part, ushort alpha)
    {
        PangoRendererExterns.pango_renderer_set_alpha(renderer, part, alpha);
        return renderer;
    }

    public static ushort GetAlpha(this PangoRendererHandle renderer, PangoRenderPart part)
    {
        return PangoRendererExterns.pango_renderer_get_alpha(renderer, part);
    }

    public static PangoRendererHandle SetMatrix(this PangoRendererHandle renderer, PangoMatrixHandle matrix)
    {
        PangoRendererExterns.pango_renderer_set_matrix(renderer, matrix);
        return renderer;
    }

    public static PangoMatrixHandle GetMatrix(this PangoRendererHandle renderer)
    {
        return PangoRendererExterns.pango_renderer_get_matrix(renderer);
    }

    public static PangoLayoutHandle GetLayout(this PangoRendererHandle renderer)
    {
        return PangoRendererExterns.pango_renderer_get_layout(renderer);
    }

    public static PangoLayoutLineHandle GetLayoutLine(this PangoRendererHandle renderer)
    {
        return PangoRendererExterns.pango_renderer_get_layout_line(renderer);
    }
}
