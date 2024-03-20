using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class Methods
{
	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_coverage_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoCoverageHandle pango_coverage_from_bytes(string bytes, int n_bytes);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_units_from_double(double d);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double pango_units_to_double(int i);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_matrix_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern PangoScript pango_script_for_unichar(uint ch);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_script_iter_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_language_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoLanguageHandle pango_language_get_default();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoLanguageHandle[] pango_language_get_preferred();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoLanguageHandle pango_language_from_string(string language);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoLanguageHandle pango_script_get_sample_language(PangoScript script);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double pango_gravity_to_rotation(PangoGravity gravity);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoGravity pango_gravity_get_for_script(PangoScript script, PangoGravity base_gravity, PangoGravityHint hint);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoGravity pango_gravity_get_for_script_and_width(PangoScript script, int wide, PangoGravity base_gravity, PangoGravityHint hint);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern PangoBidiType pango_bidi_type_for_unichar(uint ch);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern PangoDirection pango_unichar_direction(uint ch);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern PangoDirection pango_find_base_dir(string text, int length);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int pango_get_mirror_char(uint ch, out uint mirrored_ch);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_description_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_font_descriptions_free(out PangoFontDescriptionHandle descs, int n_descs);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoFontDescriptionHandle pango_font_description_from_string(string str);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_metrics_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_family_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_face_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_color_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_attribute_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoAttrType pango_attr_type_register(string name);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string pango_attr_type_get_name(PangoAttrType type);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_attr_list_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoAttrListHandle pango_attr_list_from_string(string text);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_attr_iterator_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_item_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void pango_break(string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_get_log_attrs(string text, int length, int level, PangoLanguageHandle language, PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_default_break(string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_tailor_break(string text, int length, PangoAnalysisHandle analysis, int offset, PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_attr_break(string text, int length, PangoAttrListHandle attr_list, int offset, PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_fontset_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_map_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_context_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_glyph_string_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_shape(string text, int length, PangoAnalysisHandle analysis, PangoGlyphStringHandle glyphs);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_shape_full(string item_text, int item_length, string paragraph_text, int paragraph_length, PangoAnalysisHandle analysis, PangoGlyphStringHandle glyphs);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_shape_with_flags(string item_text, int item_length, string paragraph_text, int paragraph_length, PangoAnalysisHandle analysis, PangoGlyphStringHandle glyphs, PangoShapeFlags flags);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_engine_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_engine_lang_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_engine_shape_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void script_engine_list(out PangoEngineInfo[] engines, out int n_engines);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void script_engine_exit();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoEngineHandle script_engine_create(string id);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_attr_type_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_underline_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_overline_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_show_flags_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_text_transform_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_baseline_shift_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_scale_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_bidi_type_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_coverage_level_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_direction_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_style_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_variant_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_weight_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_stretch_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_font_mask_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_shape_flags_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_gravity_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_gravity_hint_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_alignment_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_wrap_mode_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_ellipsize_mode_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_layout_serialize_flags_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_layout_deserialize_error_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_layout_deserialize_flags_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_render_part_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_script_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_tab_align_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_fontset_simple_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_glyph_item_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_glyph_item_iter_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_tab_array_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoTabArrayHandle pango_tab_array_from_string(string text);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_layout_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark pango_layout_deserialize_error_quark();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_layout_line_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_layout_iter_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_parse_markup(string markup_text, int length, uint accel_marker, out PangoAttrListHandle attr_list, string[] text, out uint accel_char, out GErrorHandle error);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType pango_renderer_get_type();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] pango_split_file_list(string str);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string pango_trim_string(string str);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_parse_style(string str, out PangoStyle style, int warn);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_parse_variant(string str, out PangoVariant variant, int warn);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_parse_weight(string str, out PangoWeight weight, int warn);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_parse_stretch(string str, out PangoStretch stretch, int warn);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_quantize_line_geometry(ref int thickness, ref int position);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte[] pango_log2vis_get_embedding_levels(string text, int length, ref PangoDirection pbase_dir);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_is_zero_width(uint ch);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void pango_find_paragraph_boundary(string text, int length, out int paragraph_delimiter_index, out int next_paragraph_start);

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int pango_version();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string pango_version_string();

	[DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string pango_version_check(int required_major, int required_minor, int required_micro);
}
