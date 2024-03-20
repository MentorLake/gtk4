namespace MentorLake.Gtk4.Pango;

public static class Constants
{
	public const int PANGO_VERSION_MAJOR = 1;
	public const int PANGO_VERSION_MINOR = 50;
	public const int PANGO_VERSION_MICRO = 6;
	public const int PANGO_VERSION_1_2 = (1 << 16) | (2 << 8);
	public const int PANGO_VERSION_1_4 = (1 << 16) | (4 << 8);
	public const int PANGO_VERSION_1_6 = (1 << 16) | (6 << 8);
	public const int PANGO_VERSION_1_8 = (1 << 16) | (8 << 8);
	public const int PANGO_VERSION_1_10 = (1 << 16) | (10 << 8);
	public const int PANGO_VERSION_1_12 = (1 << 16) | (12 << 8);
	public const int PANGO_VERSION_1_14 = (1 << 16) | (14 << 8);
	public const int PANGO_VERSION_1_16 = (1 << 16) | (16 << 8);
	public const int PANGO_VERSION_1_18 = (1 << 16) | (18 << 8);
	public const int PANGO_VERSION_1_20 = (1 << 16) | (20 << 8);
	public const int PANGO_VERSION_1_22 = (1 << 16) | (22 << 8);
	public const int PANGO_VERSION_1_24 = (1 << 16) | (24 << 8);
	public const int PANGO_VERSION_1_26 = (1 << 16) | (26 << 8);
	public const int PANGO_VERSION_1_28 = (1 << 16) | (28 << 8);
	public const int PANGO_VERSION_1_30 = (1 << 16) | (30 << 8);
	public const int PANGO_VERSION_1_32 = (1 << 16) | (32 << 8);
	public const int PANGO_VERSION_1_34 = (1 << 16) | (34 << 8);
	public const int PANGO_VERSION_1_36 = (1 << 16) | (36 << 8);
	public const int PANGO_VERSION_1_38 = (1 << 16) | (38 << 8);
	public const int PANGO_VERSION_1_40 = (1 << 16) | (40 << 8);
	public const int PANGO_VERSION_1_42 = (1 << 16) | (42 << 8);
	public const int PANGO_VERSION_1_44 = (1 << 16) | (44 << 8);
	public const int PANGO_VERSION_1_46 = (1 << 16) | (46 << 8);
	public const int PANGO_VERSION_1_48 = (1 << 16) | (48 << 8);
	public const int PANGO_VERSION_1_50 = (1 << 16) | (50 << 8);
	public const int PANGO_VERSION_1_52 = (1 << 16) | (52 << 8);
	public const int PANGO_VERSION_CUR_STABLE = (1 << 16) | (50 << 8);
	public const int PANGO_VERSION_PREV_STABLE = (1 << 16) | ((50 - 2) << 8);
	public const int PANGO_VERSION_MIN_REQUIRED = (1 << 16) | (50 << 8);
	public const int PANGO_VERSION_MAX_ALLOWED = (1 << 16) | (50 << 8);
	public const int PANGO_SCALE = 1024;
	public const double PANGO_SCALE_XX_SMALL = 0.5787037037037;
	public const double PANGO_SCALE_X_SMALL = 0.6944444444444;
	public const double PANGO_SCALE_SMALL = 0.8333333333333;
	public const double PANGO_SCALE_MEDIUM = 1.0;
	public const double PANGO_SCALE_LARGE = 1.2;
	public const double PANGO_SCALE_X_LARGE = 1.44;
	public const double PANGO_SCALE_XX_LARGE = 1.728;
	public const uint PANGO_GLYPH_EMPTY = 0x0FFFFFFF;
	public const uint PANGO_GLYPH_INVALID_INPUT = 0xFFFFFFFF;
	public const uint PANGO_GLYPH_UNKNOWN_FLAG = 0x10000000;
	public const int PANGO_UNKNOWN_GLYPH_WIDTH = 10;
	public const int PANGO_UNKNOWN_GLYPH_HEIGHT = 14;
	public const uint PANGO_ATTR_INDEX_FROM_TEXT_BEGINNING = 0;
	public const uint PANGO_ATTR_INDEX_TO_TEXT_END = 2147483647 * 2U + 1U + 0;
	public const int PANGO_ANALYSIS_FLAG_CENTERED_BASELINE = 1 << 0;
	public const int PANGO_ANALYSIS_FLAG_IS_ELLIPSIS = 1 << 1;
	public const int PANGO_ANALYSIS_FLAG_NEED_HYPHEN = 1 << 2;
	public const int PANGO_VERSION = 1 * 10000 + 50 * 100 + 6 * 1;
	public static ReadOnlySpan<byte> PANGO_VERSION_STRING => "1.50.6"u8;
	public static nuint PANGO_TYPE_MATRIX => Methods.pango_matrix_get_type();
	public static nuint PANGO_TYPE_LANGUAGE => Methods.pango_language_get_type();
	public static nuint PANGO_TYPE_FONT_DESCRIPTION => Methods.pango_font_description_get_type();
	public static nuint PANGO_TYPE_FONT_METRICS => Methods.pango_font_metrics_get_type();
	public static nuint PANGO_TYPE_FONT_FAMILY => Methods.pango_font_family_get_type();
	public static nuint PANGO_TYPE_FONT_FACE => Methods.pango_font_face_get_type();
	public static nuint PANGO_TYPE_FONT => Methods.pango_font_get_type();
	public static nuint PANGO_TYPE_COLOR => Methods.pango_color_get_type();
	public static nuint PANGO_TYPE_ATTR_LIST => Methods.pango_attr_list_get_type();
	public static nuint PANGO_TYPE_ITEM => Methods.pango_item_get_type();
	public static nuint PANGO_TYPE_FONTSET => Methods.pango_fontset_get_type();
	public static nuint PANGO_TYPE_FONT_MAP => Methods.pango_font_map_get_type();
	public static nuint PANGO_TYPE_CONTEXT => Methods.pango_context_get_type();
	public static nuint PANGO_TYPE_GLYPH_STRING => Methods.pango_glyph_string_get_type();
	public static ReadOnlySpan<byte> PANGO_RENDER_TYPE_NONE => "PangoRenderNone"u8;
	public static nuint PANGO_TYPE_ENGINE => Methods.pango_engine_get_type();
	public static ReadOnlySpan<byte> PANGO_ENGINE_TYPE_LANG => "PangoEngineLang"u8;
	public static nuint PANGO_TYPE_ENGINE_LANG => Methods.pango_engine_lang_get_type();
	public static ReadOnlySpan<byte> PANGO_ENGINE_TYPE_SHAPE => "PangoEngineShape"u8;
	public static nuint PANGO_TYPE_ENGINE_SHAPE => Methods.pango_engine_shape_get_type();
	public static nuint PANGO_TYPE_ATTR_TYPE => Methods.pango_attr_type_get_type();
	public static nuint PANGO_TYPE_UNDERLINE => Methods.pango_underline_get_type();
	public static nuint PANGO_TYPE_OVERLINE => Methods.pango_overline_get_type();
	public static nuint PANGO_TYPE_SHOW_FLAGS => Methods.pango_show_flags_get_type();
	public static nuint PANGO_TYPE_TEXT_TRANSFORM => Methods.pango_text_transform_get_type();
	public static nuint PANGO_TYPE_BASELINE_SHIFT => Methods.pango_baseline_shift_get_type();
	public static nuint PANGO_TYPE_FONT_SCALE => Methods.pango_font_scale_get_type();
	public static nuint PANGO_TYPE_BIDI_TYPE => Methods.pango_bidi_type_get_type();
	public static nuint PANGO_TYPE_COVERAGE_LEVEL => Methods.pango_coverage_level_get_type();
	public static nuint PANGO_TYPE_DIRECTION => Methods.pango_direction_get_type();
	public static nuint PANGO_TYPE_STYLE => Methods.pango_style_get_type();
	public static nuint PANGO_TYPE_VARIANT => Methods.pango_variant_get_type();
	public static nuint PANGO_TYPE_WEIGHT => Methods.pango_weight_get_type();
	public static nuint PANGO_TYPE_STRETCH => Methods.pango_stretch_get_type();
	public static nuint PANGO_TYPE_FONT_MASK => Methods.pango_font_mask_get_type();
	public static nuint PANGO_TYPE_SHAPE_FLAGS => Methods.pango_shape_flags_get_type();
	public static nuint PANGO_TYPE_GRAVITY => Methods.pango_gravity_get_type();
	public static nuint PANGO_TYPE_GRAVITY_HINT => Methods.pango_gravity_hint_get_type();
	public static nuint PANGO_TYPE_ALIGNMENT => Methods.pango_alignment_get_type();
	public static nuint PANGO_TYPE_WRAP_MODE => Methods.pango_wrap_mode_get_type();
	public static nuint PANGO_TYPE_ELLIPSIZE_MODE => Methods.pango_ellipsize_mode_get_type();
	public static nuint PANGO_TYPE_LAYOUT_SERIALIZE_FLAGS => Methods.pango_layout_serialize_flags_get_type();
	public static nuint PANGO_TYPE_LAYOUT_DESERIALIZE_ERROR => Methods.pango_layout_deserialize_error_get_type();
	public static nuint PANGO_TYPE_LAYOUT_DESERIALIZE_FLAGS => Methods.pango_layout_deserialize_flags_get_type();
	public static nuint PANGO_TYPE_RENDER_PART => Methods.pango_render_part_get_type();
	public static nuint PANGO_TYPE_SCRIPT => Methods.pango_script_get_type();
	public static nuint PANGO_TYPE_TAB_ALIGN => Methods.pango_tab_align_get_type();
	public static nuint PANGO_TYPE_FONTSET_SIMPLE => Methods.pango_fontset_simple_get_type();
	public static nuint PANGO_TYPE_GLYPH_ITEM => Methods.pango_glyph_item_get_type();
	public static nuint PANGO_TYPE_GLYPH_ITEM_ITER => Methods.pango_glyph_item_iter_get_type();
	public static nuint PANGO_TYPE_TAB_ARRAY => Methods.pango_tab_array_get_type();
	public static nuint PANGO_TYPE_LAYOUT => Methods.pango_layout_get_type();
	public static uint PANGO_LAYOUT_DESERIALIZE_ERROR => Methods.pango_layout_deserialize_error_quark();
	public static nuint PANGO_TYPE_LAYOUT_LINE => Methods.pango_layout_line_get_type();
	public static nuint PANGO_TYPE_LAYOUT_ITER => Methods.pango_layout_iter_get_type();
	public static nuint PANGO_TYPE_RENDERER => Methods.pango_renderer_get_type();
}