using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoLayoutAdaptors
{
    public static PangoLayoutHandle Copy(this PangoLayoutHandle src)
    {
        return PangoLayoutExterns.pango_layout_copy(src);
    }

    public static PangoContextHandle GetContext(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_context(layout);
    }

    public static PangoLayoutHandle SetAttributes(this PangoLayoutHandle layout, PangoAttrListHandle attrs)
    {
        PangoLayoutExterns.pango_layout_set_attributes(layout, attrs);
        return layout;
    }

    public static PangoAttrListHandle GetAttributes(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_attributes(layout);
    }

    public static PangoLayoutHandle SetText(this PangoLayoutHandle layout, string text, int length)
    {
        PangoLayoutExterns.pango_layout_set_text(layout, text, length);
        return layout;
    }

    public static string GetText(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_text(layout);
    }

    public static int GetCharacterCount(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_character_count(layout);
    }

    public static PangoLayoutHandle SetMarkup(this PangoLayoutHandle layout, string markup, int length)
    {
        PangoLayoutExterns.pango_layout_set_markup(layout, markup, length);
        return layout;
    }

    public static PangoLayoutHandle SetMarkupWithAccel(this PangoLayoutHandle layout, string markup, int length, uint accel_marker, out uint accel_char)
    {
        PangoLayoutExterns.pango_layout_set_markup_with_accel(layout, markup, length, accel_marker, out accel_char);
        return layout;
    }

    public static PangoLayoutHandle SetFontDescription(this PangoLayoutHandle layout, PangoFontDescriptionHandle desc)
    {
        PangoLayoutExterns.pango_layout_set_font_description(layout, desc);
        return layout;
    }

    public static PangoFontDescriptionHandle GetFontDescription(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_font_description(layout);
    }

    public static PangoLayoutHandle SetWidth(this PangoLayoutHandle layout, int width)
    {
        PangoLayoutExterns.pango_layout_set_width(layout, width);
        return layout;
    }

    public static int GetWidth(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_width(layout);
    }

    public static PangoLayoutHandle SetHeight(this PangoLayoutHandle layout, int height)
    {
        PangoLayoutExterns.pango_layout_set_height(layout, height);
        return layout;
    }

    public static int GetHeight(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_height(layout);
    }

    public static PangoLayoutHandle SetWrap(this PangoLayoutHandle layout, PangoWrapMode wrap)
    {
        PangoLayoutExterns.pango_layout_set_wrap(layout, wrap);
        return layout;
    }

    public static PangoWrapMode GetWrap(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_wrap(layout);
    }

    public static int IsWrapped(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_is_wrapped(layout);
    }

    public static PangoLayoutHandle SetIndent(this PangoLayoutHandle layout, int indent)
    {
        PangoLayoutExterns.pango_layout_set_indent(layout, indent);
        return layout;
    }

    public static int GetIndent(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_indent(layout);
    }

    public static PangoLayoutHandle SetSpacing(this PangoLayoutHandle layout, int spacing)
    {
        PangoLayoutExterns.pango_layout_set_spacing(layout, spacing);
        return layout;
    }

    public static int GetSpacing(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_spacing(layout);
    }

    public static PangoLayoutHandle SetLineSpacing(this PangoLayoutHandle layout, float factor)
    {
        PangoLayoutExterns.pango_layout_set_line_spacing(layout, factor);
        return layout;
    }

    public static float GetLineSpacing(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_line_spacing(layout);
    }

    public static PangoLayoutHandle SetJustify(this PangoLayoutHandle layout, int justify)
    {
        PangoLayoutExterns.pango_layout_set_justify(layout, justify);
        return layout;
    }

    public static int GetJustify(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_justify(layout);
    }

    public static PangoLayoutHandle SetJustifyLastLine(this PangoLayoutHandle layout, int justify)
    {
        PangoLayoutExterns.pango_layout_set_justify_last_line(layout, justify);
        return layout;
    }

    public static int GetJustifyLastLine(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_justify_last_line(layout);
    }

    public static PangoLayoutHandle SetAutoDir(this PangoLayoutHandle layout, int auto_dir)
    {
        PangoLayoutExterns.pango_layout_set_auto_dir(layout, auto_dir);
        return layout;
    }

    public static int GetAutoDir(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_auto_dir(layout);
    }

    public static PangoLayoutHandle SetAlignment(this PangoLayoutHandle layout, PangoAlignment alignment)
    {
        PangoLayoutExterns.pango_layout_set_alignment(layout, alignment);
        return layout;
    }

    public static PangoAlignment GetAlignment(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_alignment(layout);
    }

    public static PangoLayoutHandle SetTabs(this PangoLayoutHandle layout, PangoTabArrayHandle tabs)
    {
        PangoLayoutExterns.pango_layout_set_tabs(layout, tabs);
        return layout;
    }

    public static PangoTabArrayHandle GetTabs(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_tabs(layout);
    }

    public static PangoLayoutHandle SetSingleParagraphMode(this PangoLayoutHandle layout, int setting)
    {
        PangoLayoutExterns.pango_layout_set_single_paragraph_mode(layout, setting);
        return layout;
    }

    public static int GetSingleParagraphMode(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_single_paragraph_mode(layout);
    }

    public static PangoLayoutHandle SetEllipsize(this PangoLayoutHandle layout, PangoEllipsizeMode ellipsize)
    {
        PangoLayoutExterns.pango_layout_set_ellipsize(layout, ellipsize);
        return layout;
    }

    public static PangoEllipsizeMode GetEllipsize(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_ellipsize(layout);
    }

    public static int IsEllipsized(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_is_ellipsized(layout);
    }

    public static int GetUnknownGlyphsCount(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_unknown_glyphs_count(layout);
    }

    public static PangoDirection GetDirection(this PangoLayoutHandle layout, int index)
    {
        return PangoLayoutExterns.pango_layout_get_direction(layout, index);
    }

    public static PangoLayoutHandle ContextChanged(this PangoLayoutHandle layout)
    {
        PangoLayoutExterns.pango_layout_context_changed(layout);
        return layout;
    }

    public static uint GetSerial(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_serial(layout);
    }

    public static PangoLayoutHandle GetLogAttrs(this PangoLayoutHandle layout, out PangoLogAttrHandle attrs, out int n_attrs)
    {
        PangoLayoutExterns.pango_layout_get_log_attrs(layout, out attrs, out n_attrs);
        return layout;
    }

    public static PangoLogAttr[] GetLogAttrsReadonly(this PangoLayoutHandle layout, out int n_attrs)
    {
        return PangoLayoutExterns.pango_layout_get_log_attrs_readonly(layout, out n_attrs);
    }

    public static PangoLayoutHandle IndexToPos(this PangoLayoutHandle layout, int index_, PangoRectangleHandle pos)
    {
        PangoLayoutExterns.pango_layout_index_to_pos(layout, index_, pos);
        return layout;
    }

    public static PangoLayoutHandle IndexToLineX(this PangoLayoutHandle layout, int index_, int trailing, out int line, out int x_pos)
    {
        PangoLayoutExterns.pango_layout_index_to_line_x(layout, index_, trailing, out line, out x_pos);
        return layout;
    }

    public static PangoLayoutHandle GetCursorPos(this PangoLayoutHandle layout, int index_, PangoRectangleHandle strong_pos, PangoRectangleHandle weak_pos)
    {
        PangoLayoutExterns.pango_layout_get_cursor_pos(layout, index_, strong_pos, weak_pos);
        return layout;
    }

    public static PangoLayoutHandle GetCaretPos(this PangoLayoutHandle layout, int index_, PangoRectangleHandle strong_pos, PangoRectangleHandle weak_pos)
    {
        PangoLayoutExterns.pango_layout_get_caret_pos(layout, index_, strong_pos, weak_pos);
        return layout;
    }

    public static PangoLayoutHandle MoveCursorVisually(this PangoLayoutHandle layout, int strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing)
    {
        PangoLayoutExterns.pango_layout_move_cursor_visually(layout, strong, old_index, old_trailing, direction, out new_index, out new_trailing);
        return layout;
    }

    public static int XyToIndex(this PangoLayoutHandle layout, int x, int y, out int index_, out int trailing)
    {
        return PangoLayoutExterns.pango_layout_xy_to_index(layout, x, y, out index_, out trailing);
    }

    public static PangoLayoutHandle GetExtents(this PangoLayoutHandle layout, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutExterns.pango_layout_get_extents(layout, ink_rect, logical_rect);
        return layout;
    }

    public static PangoLayoutHandle GetPixelExtents(this PangoLayoutHandle layout, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        PangoLayoutExterns.pango_layout_get_pixel_extents(layout, ink_rect, logical_rect);
        return layout;
    }

    public static PangoLayoutHandle GetSize(this PangoLayoutHandle layout, out int width, out int height)
    {
        PangoLayoutExterns.pango_layout_get_size(layout, out width, out height);
        return layout;
    }

    public static PangoLayoutHandle GetPixelSize(this PangoLayoutHandle layout, out int width, out int height)
    {
        PangoLayoutExterns.pango_layout_get_pixel_size(layout, out width, out height);
        return layout;
    }

    public static int GetBaseline(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_baseline(layout);
    }

    public static int GetLineCount(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_line_count(layout);
    }

    public static PangoLayoutLineHandle GetLine(this PangoLayoutHandle layout, int line)
    {
        return PangoLayoutExterns.pango_layout_get_line(layout, line);
    }

    public static PangoLayoutLineHandle GetLineReadonly(this PangoLayoutHandle layout, int line)
    {
        return PangoLayoutExterns.pango_layout_get_line_readonly(layout, line);
    }

    public static GSListHandle GetLines(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_lines(layout);
    }

    public static GSListHandle GetLinesReadonly(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_lines_readonly(layout);
    }

    public static GBytesHandle Serialize(this PangoLayoutHandle layout, PangoLayoutSerializeFlags flags)
    {
        return PangoLayoutExterns.pango_layout_serialize(layout, flags);
    }

    public static int WriteToFile(this PangoLayoutHandle layout, PangoLayoutSerializeFlags flags, string filename, out GErrorHandle error)
    {
        return PangoLayoutExterns.pango_layout_write_to_file(layout, flags, filename, out error);
    }

    public static PangoLayoutIterHandle GetIter(this PangoLayoutHandle layout)
    {
        return PangoLayoutExterns.pango_layout_get_iter(layout);
    }
}
