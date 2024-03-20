using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoRendererExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_layout")]
	internal static extern void pango_renderer_draw_layout(this PangoRendererHandle renderer, PangoLayoutHandle layout, int x, int y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_layout_line")]
	internal static extern void pango_renderer_draw_layout_line(this PangoRendererHandle renderer, PangoLayoutLineHandle line, int x, int y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_glyphs")]
	internal static extern void pango_renderer_draw_glyphs(this PangoRendererHandle renderer, PangoFontHandle font, PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_glyph_item")]
	internal static extern void pango_renderer_draw_glyph_item(this PangoRendererHandle renderer, string text, PangoGlyphItemHandle glyph_item, int x, int y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_rectangle")]
	internal static extern void pango_renderer_draw_rectangle(this PangoRendererHandle renderer, PangoRenderPart part, int x, int y, int width, int height);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_error_underline")]
	internal static extern void pango_renderer_draw_error_underline(this PangoRendererHandle renderer, int x, int y, int width, int height);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_trapezoid")]
	internal static extern void pango_renderer_draw_trapezoid(this PangoRendererHandle renderer, PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_draw_glyph")]
	internal static extern void pango_renderer_draw_glyph(this PangoRendererHandle renderer, PangoFontHandle font, PangoGlyph glyph, double x, double y);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_activate")]
	internal static extern void pango_renderer_activate(this PangoRendererHandle renderer);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_deactivate")]
	internal static extern void pango_renderer_deactivate(this PangoRendererHandle renderer);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_part_changed")]
	internal static extern void pango_renderer_part_changed(this PangoRendererHandle renderer, PangoRenderPart part);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_set_color")]
	internal static extern void pango_renderer_set_color(this PangoRendererHandle renderer, PangoRenderPart part, PangoColorHandle color);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_get_color")]
	internal static extern PangoColorHandle pango_renderer_get_color(this PangoRendererHandle renderer, PangoRenderPart part);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_set_alpha")]
	internal static extern void pango_renderer_set_alpha(this PangoRendererHandle renderer, PangoRenderPart part, ushort alpha);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_get_alpha")]
	internal static extern ushort pango_renderer_get_alpha(this PangoRendererHandle renderer, PangoRenderPart part);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_set_matrix")]
	internal static extern void pango_renderer_set_matrix(this PangoRendererHandle renderer, PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_get_matrix")]
	internal static extern PangoMatrixHandle pango_renderer_get_matrix(this PangoRendererHandle renderer);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_get_layout")]
	internal static extern PangoLayoutHandle pango_renderer_get_layout(this PangoRendererHandle renderer);

	[DllImport(Libraries.Pango, EntryPoint = "pango_renderer_get_layout_line")]
	internal static extern PangoLayoutLineHandle pango_renderer_get_layout_line(this PangoRendererHandle renderer);
}
