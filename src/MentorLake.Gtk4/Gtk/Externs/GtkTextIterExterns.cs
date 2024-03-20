using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTextIterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_buffer")]
	internal static extern GtkTextBufferHandle gtk_text_iter_get_buffer(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_copy")]
	internal static extern GtkTextIterHandle gtk_text_iter_copy(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_free")]
	internal static extern void gtk_text_iter_free(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_assign")]
	internal static extern void gtk_text_iter_assign(this GtkTextIterHandle iter, GtkTextIterHandle other);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_offset")]
	internal static extern int gtk_text_iter_get_offset(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_line")]
	internal static extern int gtk_text_iter_get_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_line_offset")]
	internal static extern int gtk_text_iter_get_line_offset(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_line_index")]
	internal static extern int gtk_text_iter_get_line_index(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_visible_line_offset")]
	internal static extern int gtk_text_iter_get_visible_line_offset(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_visible_line_index")]
	internal static extern int gtk_text_iter_get_visible_line_index(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_char")]
	internal static extern uint gtk_text_iter_get_char(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_slice")]
	internal static extern string gtk_text_iter_get_slice(this GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_text")]
	internal static extern string gtk_text_iter_get_text(this GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_visible_slice")]
	internal static extern string gtk_text_iter_get_visible_slice(this GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_visible_text")]
	internal static extern string gtk_text_iter_get_visible_text(this GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_paintable")]
	internal static extern GdkPaintableHandle gtk_text_iter_get_paintable(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_marks")]
	internal static extern GSListHandle gtk_text_iter_get_marks(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_child_anchor")]
	internal static extern GtkTextChildAnchorHandle gtk_text_iter_get_child_anchor(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_toggled_tags")]
	internal static extern GSListHandle gtk_text_iter_get_toggled_tags(this GtkTextIterHandle iter, int toggled_on);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_starts_tag")]
	internal static extern int gtk_text_iter_starts_tag(this GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_ends_tag")]
	internal static extern int gtk_text_iter_ends_tag(this GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_toggles_tag")]
	internal static extern int gtk_text_iter_toggles_tag(this GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_has_tag")]
	internal static extern int gtk_text_iter_has_tag(this GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_tags")]
	internal static extern GSListHandle gtk_text_iter_get_tags(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_editable")]
	internal static extern int gtk_text_iter_editable(this GtkTextIterHandle iter, int default_setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_can_insert")]
	internal static extern int gtk_text_iter_can_insert(this GtkTextIterHandle iter, int default_editability);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_starts_word")]
	internal static extern int gtk_text_iter_starts_word(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_ends_word")]
	internal static extern int gtk_text_iter_ends_word(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_inside_word")]
	internal static extern int gtk_text_iter_inside_word(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_starts_sentence")]
	internal static extern int gtk_text_iter_starts_sentence(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_ends_sentence")]
	internal static extern int gtk_text_iter_ends_sentence(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_inside_sentence")]
	internal static extern int gtk_text_iter_inside_sentence(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_starts_line")]
	internal static extern int gtk_text_iter_starts_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_ends_line")]
	internal static extern int gtk_text_iter_ends_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_is_cursor_position")]
	internal static extern int gtk_text_iter_is_cursor_position(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_chars_in_line")]
	internal static extern int gtk_text_iter_get_chars_in_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_bytes_in_line")]
	internal static extern int gtk_text_iter_get_bytes_in_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_get_language")]
	internal static extern PangoLanguageHandle gtk_text_iter_get_language(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_is_end")]
	internal static extern int gtk_text_iter_is_end(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_is_start")]
	internal static extern int gtk_text_iter_is_start(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_char")]
	internal static extern int gtk_text_iter_forward_char(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_char")]
	internal static extern int gtk_text_iter_backward_char(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_chars")]
	internal static extern int gtk_text_iter_forward_chars(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_chars")]
	internal static extern int gtk_text_iter_backward_chars(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_line")]
	internal static extern int gtk_text_iter_forward_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_line")]
	internal static extern int gtk_text_iter_backward_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_lines")]
	internal static extern int gtk_text_iter_forward_lines(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_lines")]
	internal static extern int gtk_text_iter_backward_lines(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_word_end")]
	internal static extern int gtk_text_iter_forward_word_end(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_word_start")]
	internal static extern int gtk_text_iter_backward_word_start(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_word_ends")]
	internal static extern int gtk_text_iter_forward_word_ends(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_word_starts")]
	internal static extern int gtk_text_iter_backward_word_starts(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_visible_line")]
	internal static extern int gtk_text_iter_forward_visible_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_visible_line")]
	internal static extern int gtk_text_iter_backward_visible_line(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_visible_lines")]
	internal static extern int gtk_text_iter_forward_visible_lines(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_visible_lines")]
	internal static extern int gtk_text_iter_backward_visible_lines(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_visible_word_end")]
	internal static extern int gtk_text_iter_forward_visible_word_end(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_visible_word_start")]
	internal static extern int gtk_text_iter_backward_visible_word_start(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_visible_word_ends")]
	internal static extern int gtk_text_iter_forward_visible_word_ends(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_visible_word_starts")]
	internal static extern int gtk_text_iter_backward_visible_word_starts(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_sentence_end")]
	internal static extern int gtk_text_iter_forward_sentence_end(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_sentence_start")]
	internal static extern int gtk_text_iter_backward_sentence_start(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_sentence_ends")]
	internal static extern int gtk_text_iter_forward_sentence_ends(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_sentence_starts")]
	internal static extern int gtk_text_iter_backward_sentence_starts(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_cursor_position")]
	internal static extern int gtk_text_iter_forward_cursor_position(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_cursor_position")]
	internal static extern int gtk_text_iter_backward_cursor_position(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_cursor_positions")]
	internal static extern int gtk_text_iter_forward_cursor_positions(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_cursor_positions")]
	internal static extern int gtk_text_iter_backward_cursor_positions(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_visible_cursor_position")]
	internal static extern int gtk_text_iter_forward_visible_cursor_position(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_visible_cursor_position")]
	internal static extern int gtk_text_iter_backward_visible_cursor_position(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_visible_cursor_positions")]
	internal static extern int gtk_text_iter_forward_visible_cursor_positions(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_visible_cursor_positions")]
	internal static extern int gtk_text_iter_backward_visible_cursor_positions(this GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_set_offset")]
	internal static extern void gtk_text_iter_set_offset(this GtkTextIterHandle iter, int char_offset);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_set_line")]
	internal static extern void gtk_text_iter_set_line(this GtkTextIterHandle iter, int line_number);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_set_line_offset")]
	internal static extern void gtk_text_iter_set_line_offset(this GtkTextIterHandle iter, int char_on_line);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_set_line_index")]
	internal static extern void gtk_text_iter_set_line_index(this GtkTextIterHandle iter, int byte_on_line);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_to_end")]
	internal static extern void gtk_text_iter_forward_to_end(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_to_line_end")]
	internal static extern int gtk_text_iter_forward_to_line_end(this GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_set_visible_line_offset")]
	internal static extern void gtk_text_iter_set_visible_line_offset(this GtkTextIterHandle iter, int char_on_line);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_set_visible_line_index")]
	internal static extern void gtk_text_iter_set_visible_line_index(this GtkTextIterHandle iter, int byte_on_line);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_to_tag_toggle")]
	internal static extern int gtk_text_iter_forward_to_tag_toggle(this GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_to_tag_toggle")]
	internal static extern int gtk_text_iter_backward_to_tag_toggle(this GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_find_char")]
	internal static extern int gtk_text_iter_forward_find_char(this GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_find_char")]
	internal static extern int gtk_text_iter_backward_find_char(this GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_forward_search")]
	internal static extern int gtk_text_iter_forward_search(this GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, GtkTextIterHandle match_start, GtkTextIterHandle match_end, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_backward_search")]
	internal static extern int gtk_text_iter_backward_search(this GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, GtkTextIterHandle match_start, GtkTextIterHandle match_end, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_equal")]
	internal static extern int gtk_text_iter_equal(this GtkTextIterHandle lhs, GtkTextIterHandle rhs);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_compare")]
	internal static extern int gtk_text_iter_compare(this GtkTextIterHandle lhs, GtkTextIterHandle rhs);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_in_range")]
	internal static extern int gtk_text_iter_in_range(this GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_iter_order")]
	internal static extern void gtk_text_iter_order(this GtkTextIterHandle first, GtkTextIterHandle second);
}
