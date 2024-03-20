using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextViewAdaptors
{
	public static GtkTextViewHandle SetBuffer(this GtkTextViewHandle text_view, GtkTextBufferHandle buffer)
	{
		GtkTextViewExterns.gtk_text_view_set_buffer(text_view, buffer);
		return text_view;
	}

	public static GtkTextBufferHandle GetBuffer(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_buffer(text_view);
	}

	public static int ScrollToIter(this GtkTextViewHandle text_view, GtkTextIterHandle iter, double within_margin, int use_align, double xalign, double yalign)
	{
		return GtkTextViewExterns.gtk_text_view_scroll_to_iter(text_view, iter, within_margin, use_align, xalign, yalign);
	}

	public static GtkTextViewHandle ScrollToMark(this GtkTextViewHandle text_view, GtkTextMarkHandle mark, double within_margin, int use_align, double xalign, double yalign)
	{
		GtkTextViewExterns.gtk_text_view_scroll_to_mark(text_view, mark, within_margin, use_align, xalign, yalign);
		return text_view;
	}

	public static GtkTextViewHandle ScrollMarkOnscreen(this GtkTextViewHandle text_view, GtkTextMarkHandle mark)
	{
		GtkTextViewExterns.gtk_text_view_scroll_mark_onscreen(text_view, mark);
		return text_view;
	}

	public static int MoveMarkOnscreen(this GtkTextViewHandle text_view, GtkTextMarkHandle mark)
	{
		return GtkTextViewExterns.gtk_text_view_move_mark_onscreen(text_view, mark);
	}

	public static int PlaceCursorOnscreen(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_place_cursor_onscreen(text_view);
	}

	public static GtkTextViewHandle GetVisibleRect(this GtkTextViewHandle text_view, GdkRectangleHandle visible_rect)
	{
		GtkTextViewExterns.gtk_text_view_get_visible_rect(text_view, visible_rect);
		return text_view;
	}

	public static GtkTextViewHandle SetCursorVisible(this GtkTextViewHandle text_view, int setting)
	{
		GtkTextViewExterns.gtk_text_view_set_cursor_visible(text_view, setting);
		return text_view;
	}

	public static int GetCursorVisible(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_cursor_visible(text_view);
	}

	public static GtkTextViewHandle ResetCursorBlink(this GtkTextViewHandle text_view)
	{
		GtkTextViewExterns.gtk_text_view_reset_cursor_blink(text_view);
		return text_view;
	}

	public static GtkTextViewHandle GetCursorLocations(this GtkTextViewHandle text_view, GtkTextIterHandle iter, GdkRectangleHandle strong, GdkRectangleHandle weak)
	{
		GtkTextViewExterns.gtk_text_view_get_cursor_locations(text_view, iter, strong, weak);
		return text_view;
	}

	public static GtkTextViewHandle GetIterLocation(this GtkTextViewHandle text_view, GtkTextIterHandle iter, GdkRectangleHandle location)
	{
		GtkTextViewExterns.gtk_text_view_get_iter_location(text_view, iter, location);
		return text_view;
	}

	public static int GetIterAtLocation(this GtkTextViewHandle text_view, GtkTextIterHandle iter, int x, int y)
	{
		return GtkTextViewExterns.gtk_text_view_get_iter_at_location(text_view, iter, x, y);
	}

	public static int GetIterAtPosition(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out int trailing, int x, int y)
	{
		return GtkTextViewExterns.gtk_text_view_get_iter_at_position(text_view, iter, out trailing, x, y);
	}

	public static GtkTextViewHandle GetLineYrange(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out int y, out int height)
	{
		GtkTextViewExterns.gtk_text_view_get_line_yrange(text_view, iter, out y, out height);
		return text_view;
	}

	public static GtkTextViewHandle GetLineAtY(this GtkTextViewHandle text_view, GtkTextIterHandle target_iter, int y, out int line_top)
	{
		GtkTextViewExterns.gtk_text_view_get_line_at_y(text_view, target_iter, y, out line_top);
		return text_view;
	}

	public static GtkTextViewHandle BufferToWindowCoords(this GtkTextViewHandle text_view, GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y)
	{
		GtkTextViewExterns.gtk_text_view_buffer_to_window_coords(text_view, win, buffer_x, buffer_y, out window_x, out window_y);
		return text_view;
	}

	public static GtkTextViewHandle WindowToBufferCoords(this GtkTextViewHandle text_view, GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y)
	{
		GtkTextViewExterns.gtk_text_view_window_to_buffer_coords(text_view, win, window_x, window_y, out buffer_x, out buffer_y);
		return text_view;
	}

	public static int ForwardDisplayLine(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_forward_display_line(text_view, iter);
	}

	public static int BackwardDisplayLine(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_backward_display_line(text_view, iter);
	}

	public static int ForwardDisplayLineEnd(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_forward_display_line_end(text_view, iter);
	}

	public static int BackwardDisplayLineStart(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_backward_display_line_start(text_view, iter);
	}

	public static int StartsDisplayLine(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_starts_display_line(text_view, iter);
	}

	public static int MoveVisually(this GtkTextViewHandle text_view, GtkTextIterHandle iter, int count)
	{
		return GtkTextViewExterns.gtk_text_view_move_visually(text_view, iter, count);
	}

	public static int ImContextFilterKeypress(this GtkTextViewHandle text_view, GdkEventHandle @event)
	{
		return GtkTextViewExterns.gtk_text_view_im_context_filter_keypress(text_view, @event);
	}

	public static GtkTextViewHandle ResetImContext(this GtkTextViewHandle text_view)
	{
		GtkTextViewExterns.gtk_text_view_reset_im_context(text_view);
		return text_view;
	}

	public static GtkWidgetHandle GetGutter(this GtkTextViewHandle text_view, GtkTextWindowType win)
	{
		return GtkTextViewExterns.gtk_text_view_get_gutter(text_view, win);
	}

	public static GtkTextViewHandle SetGutter(this GtkTextViewHandle text_view, GtkTextWindowType win, GtkWidgetHandle widget)
	{
		GtkTextViewExterns.gtk_text_view_set_gutter(text_view, win, widget);
		return text_view;
	}

	public static GtkTextViewHandle AddChildAtAnchor(this GtkTextViewHandle text_view, GtkWidgetHandle child, GtkTextChildAnchorHandle anchor)
	{
		GtkTextViewExterns.gtk_text_view_add_child_at_anchor(text_view, child, anchor);
		return text_view;
	}

	public static GtkTextViewHandle AddOverlay(this GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos)
	{
		GtkTextViewExterns.gtk_text_view_add_overlay(text_view, child, xpos, ypos);
		return text_view;
	}

	public static GtkTextViewHandle MoveOverlay(this GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos)
	{
		GtkTextViewExterns.gtk_text_view_move_overlay(text_view, child, xpos, ypos);
		return text_view;
	}

	public static GtkTextViewHandle Remove(this GtkTextViewHandle text_view, GtkWidgetHandle child)
	{
		GtkTextViewExterns.gtk_text_view_remove(text_view, child);
		return text_view;
	}

	public static GtkTextViewHandle SetWrapMode(this GtkTextViewHandle text_view, GtkWrapMode wrap_mode)
	{
		GtkTextViewExterns.gtk_text_view_set_wrap_mode(text_view, wrap_mode);
		return text_view;
	}

	public static GtkWrapMode GetWrapMode(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_wrap_mode(text_view);
	}

	public static GtkTextViewHandle SetEditable(this GtkTextViewHandle text_view, int setting)
	{
		GtkTextViewExterns.gtk_text_view_set_editable(text_view, setting);
		return text_view;
	}

	public static int GetEditable(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_editable(text_view);
	}

	public static GtkTextViewHandle SetOverwrite(this GtkTextViewHandle text_view, int overwrite)
	{
		GtkTextViewExterns.gtk_text_view_set_overwrite(text_view, overwrite);
		return text_view;
	}

	public static int GetOverwrite(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_overwrite(text_view);
	}

	public static GtkTextViewHandle SetAcceptsTab(this GtkTextViewHandle text_view, int accepts_tab)
	{
		GtkTextViewExterns.gtk_text_view_set_accepts_tab(text_view, accepts_tab);
		return text_view;
	}

	public static int GetAcceptsTab(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_accepts_tab(text_view);
	}

	public static GtkTextViewHandle SetPixelsAboveLines(this GtkTextViewHandle text_view, int pixels_above_lines)
	{
		GtkTextViewExterns.gtk_text_view_set_pixels_above_lines(text_view, pixels_above_lines);
		return text_view;
	}

	public static int GetPixelsAboveLines(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_pixels_above_lines(text_view);
	}

	public static GtkTextViewHandle SetPixelsBelowLines(this GtkTextViewHandle text_view, int pixels_below_lines)
	{
		GtkTextViewExterns.gtk_text_view_set_pixels_below_lines(text_view, pixels_below_lines);
		return text_view;
	}

	public static int GetPixelsBelowLines(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_pixels_below_lines(text_view);
	}

	public static GtkTextViewHandle SetPixelsInsideWrap(this GtkTextViewHandle text_view, int pixels_inside_wrap)
	{
		GtkTextViewExterns.gtk_text_view_set_pixels_inside_wrap(text_view, pixels_inside_wrap);
		return text_view;
	}

	public static int GetPixelsInsideWrap(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_pixels_inside_wrap(text_view);
	}

	public static GtkTextViewHandle SetJustification(this GtkTextViewHandle text_view, GtkJustification justification)
	{
		GtkTextViewExterns.gtk_text_view_set_justification(text_view, justification);
		return text_view;
	}

	public static GtkJustification GetJustification(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_justification(text_view);
	}

	public static GtkTextViewHandle SetLeftMargin(this GtkTextViewHandle text_view, int left_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_left_margin(text_view, left_margin);
		return text_view;
	}

	public static int GetLeftMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_left_margin(text_view);
	}

	public static GtkTextViewHandle SetRightMargin(this GtkTextViewHandle text_view, int right_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_right_margin(text_view, right_margin);
		return text_view;
	}

	public static int GetRightMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_right_margin(text_view);
	}

	public static GtkTextViewHandle SetTopMargin(this GtkTextViewHandle text_view, int top_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_top_margin(text_view, top_margin);
		return text_view;
	}

	public static int GetTopMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_top_margin(text_view);
	}

	public static GtkTextViewHandle SetBottomMargin(this GtkTextViewHandle text_view, int bottom_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_bottom_margin(text_view, bottom_margin);
		return text_view;
	}

	public static int GetBottomMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_bottom_margin(text_view);
	}

	public static GtkTextViewHandle SetIndent(this GtkTextViewHandle text_view, int indent)
	{
		GtkTextViewExterns.gtk_text_view_set_indent(text_view, indent);
		return text_view;
	}

	public static int GetIndent(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_indent(text_view);
	}

	public static GtkTextViewHandle SetTabs(this GtkTextViewHandle text_view, PangoTabArrayHandle tabs)
	{
		GtkTextViewExterns.gtk_text_view_set_tabs(text_view, tabs);
		return text_view;
	}

	public static PangoTabArrayHandle GetTabs(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_tabs(text_view);
	}

	public static GtkTextViewHandle SetInputPurpose(this GtkTextViewHandle text_view, GtkInputPurpose purpose)
	{
		GtkTextViewExterns.gtk_text_view_set_input_purpose(text_view, purpose);
		return text_view;
	}

	public static GtkInputPurpose GetInputPurpose(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_input_purpose(text_view);
	}

	public static GtkTextViewHandle SetInputHints(this GtkTextViewHandle text_view, GtkInputHints hints)
	{
		GtkTextViewExterns.gtk_text_view_set_input_hints(text_view, hints);
		return text_view;
	}

	public static GtkInputHints GetInputHints(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_input_hints(text_view);
	}

	public static GtkTextViewHandle SetMonospace(this GtkTextViewHandle text_view, int monospace)
	{
		GtkTextViewExterns.gtk_text_view_set_monospace(text_view, monospace);
		return text_view;
	}

	public static int GetMonospace(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_monospace(text_view);
	}

	public static GtkTextViewHandle SetExtraMenu(this GtkTextViewHandle text_view, GMenuModelHandle model)
	{
		GtkTextViewExterns.gtk_text_view_set_extra_menu(text_view, model);
		return text_view;
	}

	public static GMenuModelHandle GetExtraMenu(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_extra_menu(text_view);
	}

	public static PangoContextHandle GetRtlContext(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_rtl_context(text_view);
	}

	public static PangoContextHandle GetLtrContext(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_ltr_context(text_view);
	}
}
