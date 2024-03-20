using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Pango;
public class PangoRendererClassHandle : GObjectHandle
{
}

public class PangoRectangleHandle : GObjectHandle
{
}

public class PangoEngineShapeHandle : GObjectHandle
{
}

public class PangoTabArrayHandle : GObjectHandle
{
	public static PangoTabArrayHandle New(int initial_size, int positions_in_pixels)
	{
		return PangoTabArrayExterns.pango_tab_array_new(initial_size, positions_in_pixels);
	}

	public static PangoTabArrayHandle NewWithPositions(int size, int positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist)
	{
		return PangoTabArrayExterns.pango_tab_array_new_with_positions(size, positions_in_pixels, first_alignment, first_position, @__arglist);
	}
}

public class PangoEngineHandle : GObjectHandle
{
}

public class PangoFontClassHandle : GObjectHandle
{
}

public class PangoAttrIntHandle : GObjectHandle
{
}

public class PangoScriptIterHandle : GObjectHandle
{
	public static PangoScriptIterHandle New(string text, int length)
	{
		return PangoScriptIterExterns.pango_script_iter_new(text, length);
	}
}

public class PangoEngineClassHandle : GObjectHandle
{
}

public class PangoGlyphItemIterHandle : GObjectHandle
{
}

public class PangoAttrShapeHandle : GObjectHandle
{
}

public class PangoFontsetClassHandle : GObjectHandle
{
}

public class PangoLanguageHandle : GObjectHandle
{
}

public class PangoRendererPrivateHandle : GObjectHandle
{
}

public class PangoLayoutIterHandle : GObjectHandle
{
}

public class PangoAttrClassHandle : GObjectHandle
{
}

public class PangoEngineLangClassHandle : GObjectHandle
{
}

public class PangoEngineInfoHandle : GObjectHandle
{
}

public class PangoFontHandle : GObjectHandle
{
}

public class PangoFontMapHandle : GObjectHandle
{
}

public class PangoRendererHandle : GObjectHandle
{
}

public class PangoAttributeHandle : GObjectHandle
{
	public static PangoAttributeHandle PangoAttrFamilyNew(string family)
	{
		return PangoAttributeExterns.pango_attr_family_new(family);
	}

	public static PangoAttributeHandle PangoAttrForegroundNew(ushort red, ushort green, ushort blue)
	{
		return PangoAttributeExterns.pango_attr_foreground_new(red, green, blue);
	}

	public static PangoAttributeHandle PangoAttrBackgroundNew(ushort red, ushort green, ushort blue)
	{
		return PangoAttributeExterns.pango_attr_background_new(red, green, blue);
	}

	public static PangoAttributeHandle PangoAttrSizeNew(int size)
	{
		return PangoAttributeExterns.pango_attr_size_new(size);
	}

	public static PangoAttributeHandle PangoAttrSizeNewAbsolute(int size)
	{
		return PangoAttributeExterns.pango_attr_size_new_absolute(size);
	}

	public static PangoAttributeHandle PangoAttrStyleNew(PangoStyle style)
	{
		return PangoAttributeExterns.pango_attr_style_new(style);
	}

	public static PangoAttributeHandle PangoAttrWeightNew(PangoWeight weight)
	{
		return PangoAttributeExterns.pango_attr_weight_new(weight);
	}

	public static PangoAttributeHandle PangoAttrVariantNew(PangoVariant variant)
	{
		return PangoAttributeExterns.pango_attr_variant_new(variant);
	}

	public static PangoAttributeHandle PangoAttrStretchNew(PangoStretch stretch)
	{
		return PangoAttributeExterns.pango_attr_stretch_new(stretch);
	}

	public static PangoAttributeHandle PangoAttrUnderlineNew(PangoUnderline underline)
	{
		return PangoAttributeExterns.pango_attr_underline_new(underline);
	}

	public static PangoAttributeHandle PangoAttrUnderlineColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoAttributeExterns.pango_attr_underline_color_new(red, green, blue);
	}

	public static PangoAttributeHandle PangoAttrStrikethroughNew(int strikethrough)
	{
		return PangoAttributeExterns.pango_attr_strikethrough_new(strikethrough);
	}

	public static PangoAttributeHandle PangoAttrStrikethroughColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoAttributeExterns.pango_attr_strikethrough_color_new(red, green, blue);
	}

	public static PangoAttributeHandle PangoAttrRiseNew(int rise)
	{
		return PangoAttributeExterns.pango_attr_rise_new(rise);
	}

	public static PangoAttributeHandle PangoAttrBaselineShiftNew(int shift)
	{
		return PangoAttributeExterns.pango_attr_baseline_shift_new(shift);
	}

	public static PangoAttributeHandle PangoAttrFontScaleNew(PangoFontScale scale)
	{
		return PangoAttributeExterns.pango_attr_font_scale_new(scale);
	}

	public static PangoAttributeHandle PangoAttrScaleNew(double scale_factor)
	{
		return PangoAttributeExterns.pango_attr_scale_new(scale_factor);
	}

	public static PangoAttributeHandle PangoAttrFallbackNew(int enable_fallback)
	{
		return PangoAttributeExterns.pango_attr_fallback_new(enable_fallback);
	}

	public static PangoAttributeHandle PangoAttrLetterSpacingNew(int letter_spacing)
	{
		return PangoAttributeExterns.pango_attr_letter_spacing_new(letter_spacing);
	}

	public static PangoAttributeHandle PangoAttrGravityNew(PangoGravity gravity)
	{
		return PangoAttributeExterns.pango_attr_gravity_new(gravity);
	}

	public static PangoAttributeHandle PangoAttrGravityHintNew(PangoGravityHint hint)
	{
		return PangoAttributeExterns.pango_attr_gravity_hint_new(hint);
	}

	public static PangoAttributeHandle PangoAttrFontFeaturesNew(string features)
	{
		return PangoAttributeExterns.pango_attr_font_features_new(features);
	}

	public static PangoAttributeHandle PangoAttrForegroundAlphaNew(ushort alpha)
	{
		return PangoAttributeExterns.pango_attr_foreground_alpha_new(alpha);
	}

	public static PangoAttributeHandle PangoAttrBackgroundAlphaNew(ushort alpha)
	{
		return PangoAttributeExterns.pango_attr_background_alpha_new(alpha);
	}

	public static PangoAttributeHandle PangoAttrAllowBreaksNew(int allow_breaks)
	{
		return PangoAttributeExterns.pango_attr_allow_breaks_new(allow_breaks);
	}

	public static PangoAttributeHandle PangoAttrWordNew()
	{
		return PangoAttributeExterns.pango_attr_word_new();
	}

	public static PangoAttributeHandle PangoAttrSentenceNew()
	{
		return PangoAttributeExterns.pango_attr_sentence_new();
	}

	public static PangoAttributeHandle PangoAttrInsertHyphensNew(int insert_hyphens)
	{
		return PangoAttributeExterns.pango_attr_insert_hyphens_new(insert_hyphens);
	}

	public static PangoAttributeHandle PangoAttrOverlineNew(PangoOverline overline)
	{
		return PangoAttributeExterns.pango_attr_overline_new(overline);
	}

	public static PangoAttributeHandle PangoAttrOverlineColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoAttributeExterns.pango_attr_overline_color_new(red, green, blue);
	}

	public static PangoAttributeHandle PangoAttrShowNew(PangoShowFlags flags)
	{
		return PangoAttributeExterns.pango_attr_show_new(flags);
	}

	public static PangoAttributeHandle PangoAttrLineHeightNew(double factor)
	{
		return PangoAttributeExterns.pango_attr_line_height_new(factor);
	}

	public static PangoAttributeHandle PangoAttrLineHeightNewAbsolute(int height)
	{
		return PangoAttributeExterns.pango_attr_line_height_new_absolute(height);
	}

	public static PangoAttributeHandle PangoAttrTextTransformNew(PangoTextTransform transform)
	{
		return PangoAttributeExterns.pango_attr_text_transform_new(transform);
	}
}

public class PangoGlyphItemHandle : GObjectHandle
{
}

public class PangoGlyphInfoHandle : GObjectHandle
{
}

public class PangoFontFamilyHandle : GObjectHandle
{
}

public class PangoAttrSizeHandle : GObjectHandle
{
}

public class PangoAttrFontFeaturesHandle : GObjectHandle
{
}

public class PangoLayoutClassHandle : GObjectHandle
{
}

public class PangoAttrColorHandle : GObjectHandle
{
}

public class PangoLayoutLineHandle : GObjectHandle
{
}

public class PangoColorHandle : GObjectHandle
{
}

public class PangoFontFaceHandle : GObjectHandle
{
}

public class PangoEngineLangHandle : GObjectHandle
{
}

public class PangoEngineScriptInfoHandle : GObjectHandle
{
}

public class PangoMatrixHandle : GObjectHandle
{
}

public class PangoAttrFloatHandle : GObjectHandle
{
}

public class PangoFontsetHandle : GObjectHandle
{
}

public class PangoGlyphVisAttrHandle : GObjectHandle
{
}

public class PangoFontMapClassHandle : GObjectHandle
{
}

public class PangoFontFaceClassHandle : GObjectHandle
{
}

public class PangoGlyphStringHandle : GObjectHandle
{
	public static PangoGlyphStringHandle New()
	{
		return PangoGlyphStringExterns.pango_glyph_string_new();
	}
}

public class PangoFontsetSimpleClassHandle : GObjectHandle
{
}

public class PangoAttrFontDescHandle : GObjectHandle
{
}

public class PangoFontFamilyClassHandle : GObjectHandle
{
}

public class PangoFontMetricsHandle : GObjectHandle
{
}

public class PangoFontDescriptionHandle : GObjectHandle
{
	public static PangoFontDescriptionHandle New()
	{
		return PangoFontDescriptionExterns.pango_font_description_new();
	}
}

public class PangoAttrListHandle : GObjectHandle
{
	public static PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}
}

public class PangoAttrIteratorHandle : GObjectHandle
{
}

public class PangoLogAttrHandle : GObjectHandle
{
}

public class PangoLayoutHandle : GObjectHandle
{
}

public class PangoContextHandle : GObjectHandle
{
	public static PangoContextHandle New()
	{
		return PangoContextExterns.pango_context_new();
	}
}

public class PangoGlyphGeometryHandle : GObjectHandle
{
}

public class PangoContextClassHandle : GObjectHandle
{
}

public class PangoItemHandle : GObjectHandle
{
	public static PangoItemHandle New()
	{
		return PangoItemExterns.pango_item_new();
	}
}

public class PangoAttrStringHandle : GObjectHandle
{
}

public class PangoEngineShapeClassHandle : GObjectHandle
{
}

public class PangoAnalysisHandle : GObjectHandle
{
}

public class PangoAttrLanguageHandle : GObjectHandle
{
}

public class PangoCoverageHandle : GObjectHandle
{
	public static PangoCoverageHandle New()
	{
		return PangoCoverageExterns.pango_coverage_new();
	}
}

public class PangoFontsetSimpleHandle : GObjectHandle
{
}
