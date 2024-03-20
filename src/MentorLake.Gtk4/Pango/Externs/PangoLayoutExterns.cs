using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class PangoLayoutExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_copy")]
	internal static extern PangoLayoutHandle pango_layout_copy(this PangoLayoutHandle src);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_context")]
	internal static extern PangoContextHandle pango_layout_get_context(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_attributes")]
	internal static extern void pango_layout_set_attributes(this PangoLayoutHandle layout, PangoAttrListHandle attrs);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_attributes")]
	internal static extern PangoAttrListHandle pango_layout_get_attributes(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_text")]
	internal static extern void pango_layout_set_text(this PangoLayoutHandle layout, string text, int length);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_text")]
	internal static extern string pango_layout_get_text(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_character_count")]
	internal static extern int pango_layout_get_character_count(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_markup")]
	internal static extern void pango_layout_set_markup(this PangoLayoutHandle layout, string markup, int length);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_markup_with_accel")]
	internal static extern void pango_layout_set_markup_with_accel(this PangoLayoutHandle layout, string markup, int length, uint accel_marker, out uint accel_char);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_font_description")]
	internal static extern void pango_layout_set_font_description(this PangoLayoutHandle layout, PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_font_description")]
	internal static extern PangoFontDescriptionHandle pango_layout_get_font_description(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_width")]
	internal static extern void pango_layout_set_width(this PangoLayoutHandle layout, int width);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_width")]
	internal static extern int pango_layout_get_width(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_height")]
	internal static extern void pango_layout_set_height(this PangoLayoutHandle layout, int height);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_height")]
	internal static extern int pango_layout_get_height(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_wrap")]
	internal static extern void pango_layout_set_wrap(this PangoLayoutHandle layout, PangoWrapMode wrap);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_wrap")]
	internal static extern PangoWrapMode pango_layout_get_wrap(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_is_wrapped")]
	internal static extern int pango_layout_is_wrapped(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_indent")]
	internal static extern void pango_layout_set_indent(this PangoLayoutHandle layout, int indent);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_indent")]
	internal static extern int pango_layout_get_indent(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_spacing")]
	internal static extern void pango_layout_set_spacing(this PangoLayoutHandle layout, int spacing);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_spacing")]
	internal static extern int pango_layout_get_spacing(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_line_spacing")]
	internal static extern void pango_layout_set_line_spacing(this PangoLayoutHandle layout, float factor);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_line_spacing")]
	internal static extern float pango_layout_get_line_spacing(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_justify")]
	internal static extern void pango_layout_set_justify(this PangoLayoutHandle layout, int justify);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_justify")]
	internal static extern int pango_layout_get_justify(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_justify_last_line")]
	internal static extern void pango_layout_set_justify_last_line(this PangoLayoutHandle layout, int justify);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_justify_last_line")]
	internal static extern int pango_layout_get_justify_last_line(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_auto_dir")]
	internal static extern void pango_layout_set_auto_dir(this PangoLayoutHandle layout, int auto_dir);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_auto_dir")]
	internal static extern int pango_layout_get_auto_dir(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_alignment")]
	internal static extern void pango_layout_set_alignment(this PangoLayoutHandle layout, PangoAlignment alignment);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_alignment")]
	internal static extern PangoAlignment pango_layout_get_alignment(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_tabs")]
	internal static extern void pango_layout_set_tabs(this PangoLayoutHandle layout, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_tabs")]
	internal static extern PangoTabArrayHandle pango_layout_get_tabs(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_single_paragraph_mode")]
	internal static extern void pango_layout_set_single_paragraph_mode(this PangoLayoutHandle layout, int setting);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_single_paragraph_mode")]
	internal static extern int pango_layout_get_single_paragraph_mode(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_set_ellipsize")]
	internal static extern void pango_layout_set_ellipsize(this PangoLayoutHandle layout, PangoEllipsizeMode ellipsize);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_ellipsize")]
	internal static extern PangoEllipsizeMode pango_layout_get_ellipsize(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_is_ellipsized")]
	internal static extern int pango_layout_is_ellipsized(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_unknown_glyphs_count")]
	internal static extern int pango_layout_get_unknown_glyphs_count(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_direction")]
	internal static extern PangoDirection pango_layout_get_direction(this PangoLayoutHandle layout, int index);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_context_changed")]
	internal static extern void pango_layout_context_changed(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_serial")]
	internal static extern uint pango_layout_get_serial(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_log_attrs")]
	internal static extern void pango_layout_get_log_attrs(this PangoLayoutHandle layout, out PangoLogAttrHandle attrs, out int n_attrs);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_log_attrs_readonly")]
	internal static extern PangoLogAttr[] pango_layout_get_log_attrs_readonly(this PangoLayoutHandle layout, out int n_attrs);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_index_to_pos")]
	internal static extern void pango_layout_index_to_pos(this PangoLayoutHandle layout, int index_, PangoRectangleHandle pos);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_index_to_line_x")]
	internal static extern void pango_layout_index_to_line_x(this PangoLayoutHandle layout, int index_, int trailing, out int line, out int x_pos);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_cursor_pos")]
	internal static extern void pango_layout_get_cursor_pos(this PangoLayoutHandle layout, int index_, PangoRectangleHandle strong_pos, PangoRectangleHandle weak_pos);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_caret_pos")]
	internal static extern void pango_layout_get_caret_pos(this PangoLayoutHandle layout, int index_, PangoRectangleHandle strong_pos, PangoRectangleHandle weak_pos);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_move_cursor_visually")]
	internal static extern void pango_layout_move_cursor_visually(this PangoLayoutHandle layout, int strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_xy_to_index")]
	internal static extern int pango_layout_xy_to_index(this PangoLayoutHandle layout, int x, int y, out int index_, out int trailing);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_extents")]
	internal static extern void pango_layout_get_extents(this PangoLayoutHandle layout, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_pixel_extents")]
	internal static extern void pango_layout_get_pixel_extents(this PangoLayoutHandle layout, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_size")]
	internal static extern void pango_layout_get_size(this PangoLayoutHandle layout, out int width, out int height);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_pixel_size")]
	internal static extern void pango_layout_get_pixel_size(this PangoLayoutHandle layout, out int width, out int height);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_baseline")]
	internal static extern int pango_layout_get_baseline(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_line_count")]
	internal static extern int pango_layout_get_line_count(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_line")]
	internal static extern PangoLayoutLineHandle pango_layout_get_line(this PangoLayoutHandle layout, int line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_line_readonly")]
	internal static extern PangoLayoutLineHandle pango_layout_get_line_readonly(this PangoLayoutHandle layout, int line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_lines")]
	internal static extern GSListHandle pango_layout_get_lines(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_lines_readonly")]
	internal static extern GSListHandle pango_layout_get_lines_readonly(this PangoLayoutHandle layout);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_serialize")]
	internal static extern GBytesHandle pango_layout_serialize(this PangoLayoutHandle layout, PangoLayoutSerializeFlags flags);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_write_to_file")]
	internal static extern int pango_layout_write_to_file(this PangoLayoutHandle layout, PangoLayoutSerializeFlags flags, string filename, out GErrorHandle error);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_get_iter")]
	internal static extern PangoLayoutIterHandle pango_layout_get_iter(this PangoLayoutHandle layout);
}
