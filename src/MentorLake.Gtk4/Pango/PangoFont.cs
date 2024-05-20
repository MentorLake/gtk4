namespace MentorLake.Gtk4.Pango;

public class PangoFontHandle : GObjectHandle
{
	public static void DescriptionsFree(PangoFontDescriptionHandle[] descs, int n_descs)
	{
		PangoFontExterns.pango_font_descriptions_free(descs, n_descs);
	}

	public static PangoFontHandle Deserialize(PangoContextHandle context, GBytesHandle bytes, out GErrorHandle error)
	{
		return PangoFontExterns.pango_font_deserialize(context, bytes, out error);
	}

}

public static class PangoFontHandleExtensions
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

	public static PangoFontFaceHandle GetFace(this PangoFontHandle font)
	{
		return PangoFontExterns.pango_font_get_face(font);
	}

	public static PangoFontHandle GetFeatures(this PangoFontHandle font, out hb_feature_t features, uint len, ref uint num_features)
	{
		PangoFontExterns.pango_font_get_features(font, out features, len, ref num_features);
		return font;
	}

	public static PangoFontMapHandle GetFontMap(this PangoFontHandle font)
	{
		return PangoFontExterns.pango_font_get_font_map(font);
	}

	public static PangoFontHandle GetGlyphExtents(this PangoFontHandle font, PangoGlyph glyph, out PangoRectangle ink_rect, out PangoRectangle logical_rect)
	{
		PangoFontExterns.pango_font_get_glyph_extents(font, glyph, out ink_rect, out logical_rect);
		return font;
	}

	public static hb_font_tHandle GetHbFont(this PangoFontHandle font)
	{
		return PangoFontExterns.pango_font_get_hb_font(font);
	}

	public static IntPtr GetLanguages(this PangoFontHandle font)
	{
		return PangoFontExterns.pango_font_get_languages(font);
	}

	public static PangoFontMetricsHandle GetMetrics(this PangoFontHandle font, PangoLanguageHandle language)
	{
		return PangoFontExterns.pango_font_get_metrics(font, language);
	}

	public static bool HasChar(this PangoFontHandle font, char wc)
	{
		return PangoFontExterns.pango_font_has_char(font, wc);
	}

	public static GBytesHandle Serialize(this PangoFontHandle font)
	{
		return PangoFontExterns.pango_font_serialize(font);
	}

}

internal class PangoFontExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_describe(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_describe_with_absolute_size(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_font_get_coverage(PangoFontHandle font, PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontFaceHandle pango_font_get_face(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_get_features(PangoFontHandle font, out hb_feature_t features, uint len, ref uint num_features);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMapHandle pango_font_get_font_map(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_get_glyph_extents(PangoFontHandle font, PangoGlyph glyph, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern hb_font_tHandle pango_font_get_hb_font(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern IntPtr pango_font_get_languages(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMetricsHandle pango_font_get_metrics(PangoFontHandle font, PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_has_char(PangoFontHandle font, char wc);

	[DllImport(Libraries.Pango)]
	internal static extern GBytesHandle pango_font_serialize(PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_descriptions_free(PangoFontDescriptionHandle[] descs, int n_descs);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontHandle pango_font_deserialize(PangoContextHandle context, GBytesHandle bytes, out GErrorHandle error);

}
