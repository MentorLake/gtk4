namespace MentorLake.Gtk4.Pango;

public class PangoGlyphStringHandle : BaseSafeHandle
{
	public static PangoGlyphStringHandle New()
	{
		return PangoGlyphStringExterns.pango_glyph_string_new();
	}

}

internal class PangoGlyphStringExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoGlyphStringHandle pango_glyph_string_new();

}

public struct PangoGlyphString
{
	public int num_glyphs;
	public PangoGlyphInfoHandle glyphs;
	public int[] log_clusters;
}
