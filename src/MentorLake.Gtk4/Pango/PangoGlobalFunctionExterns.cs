namespace MentorLake.Gtk4.Pango;

internal class PangoGlobalFunctionExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern GMarkupParseContextHandle pango_markup_parser_new(char accel_marker);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_overline_color_new(ushort red, ushort green, ushort blue);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_shape_with_flags(string item_text, int item_length, string paragraph_text, int paragraph_length, PangoAnalysisHandle analysis, PangoGlyphStringHandle glyphs, PangoShapeFlags flags);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_rise_new(int rise);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_weight_new(PangoWeight weight);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_parse_enum(GType type, string str, out int value, bool warn, out string possible_values);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_sentence_new();

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_foreground_new(ushort red, ushort green, ushort blue);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_strikethrough_color_new(ushort red, ushort green, ushort blue);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_background_new(ushort red, ushort green, ushort blue);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_letter_spacing_new(int letter_spacing);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_version();

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_break(string text, int length, PangoAttrListHandle attr_list, int offset, PangoLogAttr[] attrs, int attrs_len);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_units_from_double(double d);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_foreground_alpha_new(ushort alpha);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_parse_style(string str, out PangoStyle style, bool warn);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_trim_string(string str);

	[DllImport(Libraries.Pango)]
	internal static extern PangoDirection pango_unichar_direction(char ch);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_scan_word(ref string pos, GStringHandle @out);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_word_new();

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_style_new(PangoStyle style);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_shape_full(string item_text, int item_length, string paragraph_text, int paragraph_length, PangoAnalysisHandle analysis, PangoGlyphStringHandle glyphs);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_underline_color_new(ushort red, ushort green, ushort blue);

	[DllImport(Libraries.Pango)]
	internal static extern PangoDirection pango_find_base_dir(string text, int length);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_get_mirror_char(char ch, string mirrored_ch);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_shape_item(PangoItemHandle item, string paragraph_text, int paragraph_length, PangoLogAttrHandle log_attrs, PangoGlyphStringHandle glyphs, PangoShapeFlags flags);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_skip_space(ref string pos);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_insert_hyphens_new(bool insert_hyphens);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_variant_new(PangoVariant variant);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_background_alpha_new(ushort alpha);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_overline_new(PangoOverline overline);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_default_break(string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_underline_new(PangoUnderline underline);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_text_transform_new(PangoTextTransform transform);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_parse_weight(string str, out PangoWeight weight, bool warn);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_font_scale_new(PangoFontScale scale);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_scan_string(ref string pos, GStringHandle @out);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_stretch_new(PangoStretch stretch);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_strikethrough_new(bool strikethrough);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_quantize_line_geometry(ref int thickness, ref int position);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_show_new(PangoShowFlags flags);

	[DllImport(Libraries.Pango)]
	internal static extern IntPtr pango_split_file_list(string str);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_read_line(IntPtr stream, GStringHandle str);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_find_paragraph_boundary(string text, int length, out int paragraph_delimiter_index, out int next_paragraph_start);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_version_check(int required_major, int required_minor, int required_micro);

	[DllImport(Libraries.Pango)]
	internal static extern GListHandle pango_reorder_items(GListHandle items);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_line_height_new(double factor);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_allow_breaks_new(bool allow_breaks);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_gravity_new(PangoGravity gravity);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_extents_to_pixels(PangoRectangleHandle inclusive, PangoRectangleHandle nearest);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_line_height_new_absolute(int height);

	[DllImport(Libraries.Pango)]
	internal static extern double pango_units_to_double(int i);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_scan_int(ref string pos, out int @out);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_break(string text, int length, PangoAnalysisHandle analysis, PangoLogAttr[] attrs, int attrs_len);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_gravity_hint_new(PangoGravityHint hint);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_parse_stretch(string str, out PangoStretch stretch, bool warn);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_fallback_new(bool enable_fallback);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_baseline_shift_new(int shift);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_version_string();

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_parse_variant(string str, out PangoVariant variant, bool warn);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_scale_new(double scale_factor);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_shape(string text, int length, PangoAnalysisHandle analysis, PangoGlyphStringHandle glyphs);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_family_new(string family);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_parse_markup(string markup_text, int length, char accel_marker, out PangoAttrListHandle attr_list, out string text, out string accel_char, out GErrorHandle error);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_get_log_attrs(string text, int length, int level, PangoLanguageHandle language, PangoLogAttr[] attrs, int attrs_len);

	[DllImport(Libraries.Pango)]
	internal static extern IntPtr pango_log2vis_get_embedding_levels(string text, int length, ref PangoDirection pbase_dir);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_is_zero_width(char ch);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tailor_break(string text, int length, PangoAnalysisHandle analysis, int offset, PangoLogAttr[] attrs, int attrs_len);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_markup_parser_finish(GMarkupParseContextHandle context, out PangoAttrListHandle attr_list, out string text, out string accel_char, out GErrorHandle error);

}
