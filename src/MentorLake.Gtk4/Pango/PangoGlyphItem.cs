namespace MentorLake.Gtk4.Pango;

public class PangoGlyphItemHandle : BaseSafeHandle
{
}

internal class PangoGlyphItemExterns
{
}

public struct PangoGlyphItem
{
	public PangoItemHandle item;
	public PangoGlyphStringHandle glyphs;
	public int y_offset;
	public int start_x_offset;
	public int end_x_offset;
}
