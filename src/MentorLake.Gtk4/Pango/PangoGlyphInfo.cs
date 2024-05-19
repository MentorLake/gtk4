namespace MentorLake.Gtk4.Pango;

public class PangoGlyphInfoHandle : BaseSafeHandle
{
}

internal class PangoGlyphInfoExterns
{
}

public struct PangoGlyphInfo
{
	public PangoGlyph glyph;
	public PangoGlyphGeometry geometry;
	public PangoGlyphVisAttr attr;
}
