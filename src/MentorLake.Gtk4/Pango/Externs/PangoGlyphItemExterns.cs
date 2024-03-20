using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class PangoGlyphItemExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_split")]
	internal static extern PangoGlyphItemHandle pango_glyph_item_split(this PangoGlyphItemHandle orig, string text, int split_index);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_copy")]
	internal static extern PangoGlyphItemHandle pango_glyph_item_copy(this PangoGlyphItemHandle orig);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_free")]
	internal static extern void pango_glyph_item_free(this PangoGlyphItemHandle glyph_item);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_apply_attrs")]
	internal static extern GSListHandle pango_glyph_item_apply_attrs(this PangoGlyphItemHandle glyph_item, string text, PangoAttrListHandle list);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_letter_space")]
	internal static extern void pango_glyph_item_letter_space(this PangoGlyphItemHandle glyph_item, string text, PangoLogAttrHandle log_attrs, int letter_spacing);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_get_logical_widths")]
	internal static extern void pango_glyph_item_get_logical_widths(this PangoGlyphItemHandle glyph_item, string text, out int logical_widths);
}
