using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoAttributeExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_init")]
    internal static extern void pango_attribute_init(this PangoAttributeHandle attr, PangoAttrClassHandle klass);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_copy")]
    internal static extern PangoAttributeHandle pango_attribute_copy(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_destroy")]
    internal static extern void pango_attribute_destroy(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_equal")]
    internal static extern int pango_attribute_equal(this PangoAttributeHandle attr1, PangoAttributeHandle attr2);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_string")]
    internal static extern PangoAttrStringHandle pango_attribute_as_string(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_language")]
    internal static extern PangoAttrLanguageHandle pango_attribute_as_language(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_int")]
    internal static extern PangoAttrIntHandle pango_attribute_as_int(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_size")]
    internal static extern PangoAttrSizeHandle pango_attribute_as_size(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_float")]
    internal static extern PangoAttrFloatHandle pango_attribute_as_float(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_color")]
    internal static extern PangoAttrColorHandle pango_attribute_as_color(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_font_desc")]
    internal static extern PangoAttrFontDescHandle pango_attribute_as_font_desc(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_shape")]
    internal static extern PangoAttrShapeHandle pango_attribute_as_shape(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attribute_as_font_features")]
    internal static extern PangoAttrFontFeaturesHandle pango_attribute_as_font_features(this PangoAttributeHandle attr);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_family_new(string family);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_foreground_new(ushort red, ushort green, ushort blue);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_background_new(ushort red, ushort green, ushort blue);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_size_new(int size);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_size_new_absolute(int size);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_style_new(PangoStyle style);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_weight_new(PangoWeight weight);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_variant_new(PangoVariant variant);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_stretch_new(PangoStretch stretch);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_underline_new(PangoUnderline underline);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_underline_color_new(ushort red, ushort green, ushort blue);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_strikethrough_new(int strikethrough);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_strikethrough_color_new(ushort red, ushort green, ushort blue);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_rise_new(int rise);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_baseline_shift_new(int shift);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_font_scale_new(PangoFontScale scale);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_scale_new(double scale_factor);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_fallback_new(int enable_fallback);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_letter_spacing_new(int letter_spacing);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_gravity_new(PangoGravity gravity);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_gravity_hint_new(PangoGravityHint hint);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_font_features_new(string features);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_foreground_alpha_new(ushort alpha);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_background_alpha_new(ushort alpha);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_allow_breaks_new(int allow_breaks);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_word_new();
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_sentence_new();
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_insert_hyphens_new(int insert_hyphens);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_overline_new(PangoOverline overline);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_overline_color_new(ushort red, ushort green, ushort blue);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_show_new(PangoShowFlags flags);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_line_height_new(double factor);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_line_height_new_absolute(int height);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoAttributeHandle pango_attr_text_transform_new(PangoTextTransform transform);
}
