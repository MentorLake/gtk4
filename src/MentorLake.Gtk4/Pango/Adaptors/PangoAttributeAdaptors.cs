using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoAttributeAdaptors
{
	public static PangoAttributeHandle Init(this PangoAttributeHandle attr, PangoAttrClassHandle klass)
	{
		PangoAttributeExterns.pango_attribute_init(attr, klass);
		return attr;
	}

	public static PangoAttributeHandle Copy(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_copy(attr);
	}

	public static PangoAttributeHandle Destroy(this PangoAttributeHandle attr)
	{
		PangoAttributeExterns.pango_attribute_destroy(attr);
		return attr;
	}

	public static int Equal(this PangoAttributeHandle attr1, PangoAttributeHandle attr2)
	{
		return PangoAttributeExterns.pango_attribute_equal(attr1, attr2);
	}

	public static PangoAttrStringHandle AsString(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_string(attr);
	}

	public static PangoAttrLanguageHandle AsLanguage(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_language(attr);
	}

	public static PangoAttrIntHandle AsInt(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_int(attr);
	}

	public static PangoAttrSizeHandle AsSize(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_size(attr);
	}

	public static PangoAttrFloatHandle AsFloat(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_float(attr);
	}

	public static PangoAttrColorHandle AsColor(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_color(attr);
	}

	public static PangoAttrFontDescHandle AsFontDesc(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_font_desc(attr);
	}

	public static PangoAttrShapeHandle AsShape(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_shape(attr);
	}

	public static PangoAttrFontFeaturesHandle AsFontFeatures(this PangoAttributeHandle attr)
	{
		return PangoAttributeExterns.pango_attribute_as_font_features(attr);
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
