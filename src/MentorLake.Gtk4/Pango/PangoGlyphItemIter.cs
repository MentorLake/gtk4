namespace MentorLake.Gtk4.Pango;

public class PangoGlyphItemIterHandle : BaseSafeHandle
{
}

internal class PangoGlyphItemIterExterns
{
}

public struct PangoGlyphItemIter
{
	public PangoGlyphItemHandle glyph_item;
	public string text;
	public int start_glyph;
	public int start_index;
	public int start_char;
	public int end_glyph;
	public int end_index;
	public int end_char;
}
