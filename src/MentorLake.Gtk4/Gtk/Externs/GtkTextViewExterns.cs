using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextViewExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_buffer")]
    internal static extern void gtk_text_view_set_buffer(this GtkTextViewHandle text_view, GtkTextBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_buffer")]
    internal static extern GtkTextBufferHandle gtk_text_view_get_buffer(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_scroll_to_iter")]
    internal static extern int gtk_text_view_scroll_to_iter(this GtkTextViewHandle text_view, GtkTextIterHandle iter, double within_margin, int use_align, double xalign, double yalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_scroll_to_mark")]
    internal static extern void gtk_text_view_scroll_to_mark(this GtkTextViewHandle text_view, GtkTextMarkHandle mark, double within_margin, int use_align, double xalign, double yalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_scroll_mark_onscreen")]
    internal static extern void gtk_text_view_scroll_mark_onscreen(this GtkTextViewHandle text_view, GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_move_mark_onscreen")]
    internal static extern int gtk_text_view_move_mark_onscreen(this GtkTextViewHandle text_view, GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_place_cursor_onscreen")]
    internal static extern int gtk_text_view_place_cursor_onscreen(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_visible_rect")]
    internal static extern void gtk_text_view_get_visible_rect(this GtkTextViewHandle text_view, GdkRectangleHandle visible_rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_cursor_visible")]
    internal static extern void gtk_text_view_set_cursor_visible(this GtkTextViewHandle text_view, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_cursor_visible")]
    internal static extern int gtk_text_view_get_cursor_visible(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_reset_cursor_blink")]
    internal static extern void gtk_text_view_reset_cursor_blink(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_cursor_locations")]
    internal static extern void gtk_text_view_get_cursor_locations(this GtkTextViewHandle text_view, GtkTextIterHandle iter, GdkRectangleHandle strong, GdkRectangleHandle weak);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_iter_location")]
    internal static extern void gtk_text_view_get_iter_location(this GtkTextViewHandle text_view, GtkTextIterHandle iter, GdkRectangleHandle location);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_iter_at_location")]
    internal static extern int gtk_text_view_get_iter_at_location(this GtkTextViewHandle text_view, GtkTextIterHandle iter, int x, int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_iter_at_position")]
    internal static extern int gtk_text_view_get_iter_at_position(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out int trailing, int x, int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_line_yrange")]
    internal static extern void gtk_text_view_get_line_yrange(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out int y, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_line_at_y")]
    internal static extern void gtk_text_view_get_line_at_y(this GtkTextViewHandle text_view, GtkTextIterHandle target_iter, int y, out int line_top);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_buffer_to_window_coords")]
    internal static extern void gtk_text_view_buffer_to_window_coords(this GtkTextViewHandle text_view, GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_window_to_buffer_coords")]
    internal static extern void gtk_text_view_window_to_buffer_coords(this GtkTextViewHandle text_view, GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_forward_display_line")]
    internal static extern int gtk_text_view_forward_display_line(this GtkTextViewHandle text_view, GtkTextIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_backward_display_line")]
    internal static extern int gtk_text_view_backward_display_line(this GtkTextViewHandle text_view, GtkTextIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_forward_display_line_end")]
    internal static extern int gtk_text_view_forward_display_line_end(this GtkTextViewHandle text_view, GtkTextIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_backward_display_line_start")]
    internal static extern int gtk_text_view_backward_display_line_start(this GtkTextViewHandle text_view, GtkTextIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_starts_display_line")]
    internal static extern int gtk_text_view_starts_display_line(this GtkTextViewHandle text_view, GtkTextIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_move_visually")]
    internal static extern int gtk_text_view_move_visually(this GtkTextViewHandle text_view, GtkTextIterHandle iter, int count);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_im_context_filter_keypress")]
    internal static extern int gtk_text_view_im_context_filter_keypress(this GtkTextViewHandle text_view, GdkEventHandle @event);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_reset_im_context")]
    internal static extern void gtk_text_view_reset_im_context(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_gutter")]
    internal static extern GtkWidgetHandle gtk_text_view_get_gutter(this GtkTextViewHandle text_view, GtkTextWindowType win);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_gutter")]
    internal static extern void gtk_text_view_set_gutter(this GtkTextViewHandle text_view, GtkTextWindowType win, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_add_child_at_anchor")]
    internal static extern void gtk_text_view_add_child_at_anchor(this GtkTextViewHandle text_view, GtkWidgetHandle child, GtkTextChildAnchorHandle anchor);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_add_overlay")]
    internal static extern void gtk_text_view_add_overlay(this GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_move_overlay")]
    internal static extern void gtk_text_view_move_overlay(this GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_remove")]
    internal static extern void gtk_text_view_remove(this GtkTextViewHandle text_view, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_wrap_mode")]
    internal static extern void gtk_text_view_set_wrap_mode(this GtkTextViewHandle text_view, GtkWrapMode wrap_mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_wrap_mode")]
    internal static extern GtkWrapMode gtk_text_view_get_wrap_mode(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_editable")]
    internal static extern void gtk_text_view_set_editable(this GtkTextViewHandle text_view, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_editable")]
    internal static extern int gtk_text_view_get_editable(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_overwrite")]
    internal static extern void gtk_text_view_set_overwrite(this GtkTextViewHandle text_view, int overwrite);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_overwrite")]
    internal static extern int gtk_text_view_get_overwrite(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_accepts_tab")]
    internal static extern void gtk_text_view_set_accepts_tab(this GtkTextViewHandle text_view, int accepts_tab);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_accepts_tab")]
    internal static extern int gtk_text_view_get_accepts_tab(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_pixels_above_lines")]
    internal static extern void gtk_text_view_set_pixels_above_lines(this GtkTextViewHandle text_view, int pixels_above_lines);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_pixels_above_lines")]
    internal static extern int gtk_text_view_get_pixels_above_lines(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_pixels_below_lines")]
    internal static extern void gtk_text_view_set_pixels_below_lines(this GtkTextViewHandle text_view, int pixels_below_lines);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_pixels_below_lines")]
    internal static extern int gtk_text_view_get_pixels_below_lines(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_pixels_inside_wrap")]
    internal static extern void gtk_text_view_set_pixels_inside_wrap(this GtkTextViewHandle text_view, int pixels_inside_wrap);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_pixels_inside_wrap")]
    internal static extern int gtk_text_view_get_pixels_inside_wrap(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_justification")]
    internal static extern void gtk_text_view_set_justification(this GtkTextViewHandle text_view, GtkJustification justification);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_justification")]
    internal static extern GtkJustification gtk_text_view_get_justification(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_left_margin")]
    internal static extern void gtk_text_view_set_left_margin(this GtkTextViewHandle text_view, int left_margin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_left_margin")]
    internal static extern int gtk_text_view_get_left_margin(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_right_margin")]
    internal static extern void gtk_text_view_set_right_margin(this GtkTextViewHandle text_view, int right_margin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_right_margin")]
    internal static extern int gtk_text_view_get_right_margin(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_top_margin")]
    internal static extern void gtk_text_view_set_top_margin(this GtkTextViewHandle text_view, int top_margin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_top_margin")]
    internal static extern int gtk_text_view_get_top_margin(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_bottom_margin")]
    internal static extern void gtk_text_view_set_bottom_margin(this GtkTextViewHandle text_view, int bottom_margin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_bottom_margin")]
    internal static extern int gtk_text_view_get_bottom_margin(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_indent")]
    internal static extern void gtk_text_view_set_indent(this GtkTextViewHandle text_view, int indent);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_indent")]
    internal static extern int gtk_text_view_get_indent(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_tabs")]
    internal static extern void gtk_text_view_set_tabs(this GtkTextViewHandle text_view, PangoTabArrayHandle tabs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_tabs")]
    internal static extern PangoTabArrayHandle gtk_text_view_get_tabs(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_input_purpose")]
    internal static extern void gtk_text_view_set_input_purpose(this GtkTextViewHandle text_view, GtkInputPurpose purpose);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_input_purpose")]
    internal static extern GtkInputPurpose gtk_text_view_get_input_purpose(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_input_hints")]
    internal static extern void gtk_text_view_set_input_hints(this GtkTextViewHandle text_view, GtkInputHints hints);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_input_hints")]
    internal static extern GtkInputHints gtk_text_view_get_input_hints(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_monospace")]
    internal static extern void gtk_text_view_set_monospace(this GtkTextViewHandle text_view, int monospace);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_monospace")]
    internal static extern int gtk_text_view_get_monospace(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_set_extra_menu")]
    internal static extern void gtk_text_view_set_extra_menu(this GtkTextViewHandle text_view, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_extra_menu")]
    internal static extern GMenuModelHandle gtk_text_view_get_extra_menu(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_rtl_context")]
    internal static extern PangoContextHandle gtk_text_view_get_rtl_context(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_get_ltr_context")]
    internal static extern PangoContextHandle gtk_text_view_get_ltr_context(this GtkTextViewHandle text_view);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextViewHandle gtk_text_view_new();
}
