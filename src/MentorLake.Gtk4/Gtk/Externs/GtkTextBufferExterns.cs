using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTextBufferExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_line_count")]
	internal static extern int gtk_text_buffer_get_line_count(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_char_count")]
	internal static extern int gtk_text_buffer_get_char_count(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_tag_table")]
	internal static extern GtkTextTagTableHandle gtk_text_buffer_get_tag_table(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_set_text")]
	internal static extern void gtk_text_buffer_set_text(this GtkTextBufferHandle buffer, string text, int len);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert")]
	internal static extern void gtk_text_buffer_insert(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_at_cursor")]
	internal static extern void gtk_text_buffer_insert_at_cursor(this GtkTextBufferHandle buffer, string text, int len);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_interactive")]
	internal static extern int gtk_text_buffer_insert_interactive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_interactive_at_cursor")]
	internal static extern int gtk_text_buffer_insert_interactive_at_cursor(this GtkTextBufferHandle buffer, string text, int len, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_range")]
	internal static extern void gtk_text_buffer_insert_range(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_range_interactive")]
	internal static extern int gtk_text_buffer_insert_range_interactive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_with_tags")]
	internal static extern void gtk_text_buffer_insert_with_tags(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, GtkTextTagHandle first_tag, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_with_tags_by_name")]
	internal static extern void gtk_text_buffer_insert_with_tags_by_name(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_markup")]
	internal static extern void gtk_text_buffer_insert_markup(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string markup, int len);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_delete")]
	internal static extern void gtk_text_buffer_delete(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_delete_interactive")]
	internal static extern int gtk_text_buffer_delete_interactive(this GtkTextBufferHandle buffer, GtkTextIterHandle start_iter, GtkTextIterHandle end_iter, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_backspace")]
	internal static extern int gtk_text_buffer_backspace(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int interactive, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_text")]
	internal static extern string gtk_text_buffer_get_text(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, int include_hidden_chars);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_slice")]
	internal static extern string gtk_text_buffer_get_slice(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, int include_hidden_chars);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_paintable")]
	internal static extern void gtk_text_buffer_insert_paintable(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_insert_child_anchor")]
	internal static extern void gtk_text_buffer_insert_child_anchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_create_child_anchor")]
	internal static extern GtkTextChildAnchorHandle gtk_text_buffer_create_child_anchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_add_mark")]
	internal static extern void gtk_text_buffer_add_mark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_create_mark")]
	internal static extern GtkTextMarkHandle gtk_text_buffer_create_mark(this GtkTextBufferHandle buffer, string mark_name, GtkTextIterHandle where, int left_gravity);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_move_mark")]
	internal static extern void gtk_text_buffer_move_mark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_delete_mark")]
	internal static extern void gtk_text_buffer_delete_mark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_mark")]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_mark(this GtkTextBufferHandle buffer, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_move_mark_by_name")]
	internal static extern void gtk_text_buffer_move_mark_by_name(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_delete_mark_by_name")]
	internal static extern void gtk_text_buffer_delete_mark_by_name(this GtkTextBufferHandle buffer, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_insert")]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_insert(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_selection_bound")]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_selection_bound(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_place_cursor")]
	internal static extern void gtk_text_buffer_place_cursor(this GtkTextBufferHandle buffer, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_select_range")]
	internal static extern void gtk_text_buffer_select_range(this GtkTextBufferHandle buffer, GtkTextIterHandle ins, GtkTextIterHandle bound);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_apply_tag")]
	internal static extern void gtk_text_buffer_apply_tag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_remove_tag")]
	internal static extern void gtk_text_buffer_remove_tag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_apply_tag_by_name")]
	internal static extern void gtk_text_buffer_apply_tag_by_name(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_remove_tag_by_name")]
	internal static extern void gtk_text_buffer_remove_tag_by_name(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_remove_all_tags")]
	internal static extern void gtk_text_buffer_remove_all_tags(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_create_tag")]
	internal static extern GtkTextTagHandle gtk_text_buffer_create_tag(this GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_iter_at_line_offset")]
	internal static extern int gtk_text_buffer_get_iter_at_line_offset(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int line_number, int char_offset);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_iter_at_line_index")]
	internal static extern int gtk_text_buffer_get_iter_at_line_index(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int line_number, int byte_index);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_iter_at_offset")]
	internal static extern void gtk_text_buffer_get_iter_at_offset(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int char_offset);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_iter_at_line")]
	internal static extern int gtk_text_buffer_get_iter_at_line(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int line_number);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_start_iter")]
	internal static extern void gtk_text_buffer_get_start_iter(this GtkTextBufferHandle buffer, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_end_iter")]
	internal static extern void gtk_text_buffer_get_end_iter(this GtkTextBufferHandle buffer, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_bounds")]
	internal static extern void gtk_text_buffer_get_bounds(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_iter_at_mark")]
	internal static extern void gtk_text_buffer_get_iter_at_mark(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_iter_at_child_anchor")]
	internal static extern void gtk_text_buffer_get_iter_at_child_anchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_modified")]
	internal static extern int gtk_text_buffer_get_modified(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_set_modified")]
	internal static extern void gtk_text_buffer_set_modified(this GtkTextBufferHandle buffer, int setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_has_selection")]
	internal static extern int gtk_text_buffer_get_has_selection(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_add_selection_clipboard")]
	internal static extern void gtk_text_buffer_add_selection_clipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_remove_selection_clipboard")]
	internal static extern void gtk_text_buffer_remove_selection_clipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_cut_clipboard")]
	internal static extern void gtk_text_buffer_cut_clipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_copy_clipboard")]
	internal static extern void gtk_text_buffer_copy_clipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_paste_clipboard")]
	internal static extern void gtk_text_buffer_paste_clipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, GtkTextIterHandle override_location, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_selection_bounds")]
	internal static extern int gtk_text_buffer_get_selection_bounds(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_delete_selection")]
	internal static extern int gtk_text_buffer_delete_selection(this GtkTextBufferHandle buffer, int interactive, int default_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_selection_content")]
	internal static extern GdkContentProviderHandle gtk_text_buffer_get_selection_content(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_can_undo")]
	internal static extern int gtk_text_buffer_get_can_undo(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_can_redo")]
	internal static extern int gtk_text_buffer_get_can_redo(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_enable_undo")]
	internal static extern int gtk_text_buffer_get_enable_undo(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_set_enable_undo")]
	internal static extern void gtk_text_buffer_set_enable_undo(this GtkTextBufferHandle buffer, int enable_undo);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_get_max_undo_levels")]
	internal static extern uint gtk_text_buffer_get_max_undo_levels(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_set_max_undo_levels")]
	internal static extern void gtk_text_buffer_set_max_undo_levels(this GtkTextBufferHandle buffer, uint max_undo_levels);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_undo")]
	internal static extern void gtk_text_buffer_undo(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_redo")]
	internal static extern void gtk_text_buffer_redo(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_begin_irreversible_action")]
	internal static extern void gtk_text_buffer_begin_irreversible_action(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_end_irreversible_action")]
	internal static extern void gtk_text_buffer_end_irreversible_action(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_begin_user_action")]
	internal static extern void gtk_text_buffer_begin_user_action(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_end_user_action")]
	internal static extern void gtk_text_buffer_end_user_action(this GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_text_view_new_with_buffer")]
	internal static extern GtkTextViewHandle gtk_text_view_new_with_buffer(this GtkTextBufferHandle buffer);
}
