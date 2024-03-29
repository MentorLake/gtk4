using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkTextBufferHandle : GObjectHandle
{
	public static GtkTextBufferHandle New(GtkTextTagTableHandle table)
	{
		return GtkTextBufferExterns.gtk_text_buffer_new(table);
	}

}

public class GtkTextBufferSignal
{
	public string Value { get; set; }
	public GtkTextBufferSignal(string value) => Value = value;
}

public static class GtkTextBufferSignals
{
	public static GtkTextBufferSignal ApplyTag = new("apply-tag");
	public static GtkTextBufferSignal BeginUserAction = new("begin-user-action");
	public static GtkTextBufferSignal Changed = new("changed");
	public static GtkTextBufferSignal DeleteRange = new("delete-range");
	public static GtkTextBufferSignal EndUserAction = new("end-user-action");
	public static GtkTextBufferSignal InsertChildAnchor = new("insert-child-anchor");
	public static GtkTextBufferSignal InsertPaintable = new("insert-paintable");
	public static GtkTextBufferSignal InsertText = new("insert-text");
	public static GtkTextBufferSignal MarkDeleted = new("mark-deleted");
	public static GtkTextBufferSignal MarkSet = new("mark-set");
	public static GtkTextBufferSignal ModifiedChanged = new("modified-changed");
	public static GtkTextBufferSignal PasteDone = new("paste-done");
	public static GtkTextBufferSignal Redo = new("redo");
	public static GtkTextBufferSignal RemoveTag = new("remove-tag");
	public static GtkTextBufferSignal Undo = new("undo");
}

public static class GtkTextBufferHandleExtensions
{
	public static GtkTextBufferHandle AddMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_add_mark(buffer, mark, where);
		return buffer;
	}

	public static GtkTextBufferHandle AddSelectionClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard)
	{
		GtkTextBufferExterns.gtk_text_buffer_add_selection_clipboard(buffer, clipboard);
		return buffer;
	}

	public static GtkTextBufferHandle ApplyTag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_apply_tag(buffer, tag, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle ApplyTagByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_apply_tag_by_name(buffer, name, start, end);
		return buffer;
	}

	public static bool Backspace(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, bool interactive, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_backspace(buffer, iter, interactive, default_editable);
	}

	public static GtkTextBufferHandle BeginIrreversibleAction(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_begin_irreversible_action(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle BeginUserAction(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_begin_user_action(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle CopyClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard)
	{
		GtkTextBufferExterns.gtk_text_buffer_copy_clipboard(buffer, clipboard);
		return buffer;
	}

	public static GtkTextChildAnchorHandle CreateChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter)
	{
		return GtkTextBufferExterns.gtk_text_buffer_create_child_anchor(buffer, iter);
	}

	public static GtkTextMarkHandle CreateMark(this GtkTextBufferHandle buffer, string mark_name, GtkTextIterHandle where, bool left_gravity)
	{
		return GtkTextBufferExterns.gtk_text_buffer_create_mark(buffer, mark_name, where, left_gravity);
	}

	public static GtkTextTagHandle CreateTag(this GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist)
	{
		return GtkTextBufferExterns.gtk_text_buffer_create_tag(buffer, tag_name, first_property_name, @__arglist);
	}

	public static GtkTextBufferHandle CutClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, bool default_editable)
	{
		GtkTextBufferExterns.gtk_text_buffer_cut_clipboard(buffer, clipboard, default_editable);
		return buffer;
	}

	public static GtkTextBufferHandle Delete(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_delete(buffer, start, end);
		return buffer;
	}

	public static bool DeleteInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle start_iter, GtkTextIterHandle end_iter, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_delete_interactive(buffer, start_iter, end_iter, default_editable);
	}

	public static GtkTextBufferHandle DeleteMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark)
	{
		GtkTextBufferExterns.gtk_text_buffer_delete_mark(buffer, mark);
		return buffer;
	}

	public static GtkTextBufferHandle DeleteMarkByName(this GtkTextBufferHandle buffer, string name)
	{
		GtkTextBufferExterns.gtk_text_buffer_delete_mark_by_name(buffer, name);
		return buffer;
	}

	public static bool DeleteSelection(this GtkTextBufferHandle buffer, bool interactive, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_delete_selection(buffer, interactive, default_editable);
	}

	public static GtkTextBufferHandle EndIrreversibleAction(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_end_irreversible_action(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle EndUserAction(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_end_user_action(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle GetBounds(this GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_bounds(buffer, out start, out end);
		return buffer;
	}

	public static bool GetCanRedo(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_can_redo(buffer);
	}

	public static bool GetCanUndo(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_can_undo(buffer);
	}

	public static int GetCharCount(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_char_count(buffer);
	}

	public static bool GetEnableUndo(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_enable_undo(buffer);
	}

	public static GtkTextBufferHandle GetEndIter(this GtkTextBufferHandle buffer, out GtkTextIter iter)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_end_iter(buffer, out iter);
		return buffer;
	}

	public static bool GetHasSelection(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_has_selection(buffer);
	}

	public static GtkTextMarkHandle GetInsert(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_insert(buffer);
	}

	public static GtkTextBufferHandle GetIterAtChildAnchor(this GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextChildAnchorHandle anchor)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_child_anchor(buffer, out iter, anchor);
		return buffer;
	}

	public static bool GetIterAtLine(this GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line(buffer, out iter, line_number);
	}

	public static bool GetIterAtLineIndex(this GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int byte_index)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line_index(buffer, out iter, line_number, byte_index);
	}

	public static bool GetIterAtLineOffset(this GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int char_offset)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line_offset(buffer, out iter, line_number, char_offset);
	}

	public static GtkTextBufferHandle GetIterAtMark(this GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextMarkHandle mark)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_mark(buffer, out iter, mark);
		return buffer;
	}

	public static GtkTextBufferHandle GetIterAtOffset(this GtkTextBufferHandle buffer, out GtkTextIter iter, int char_offset)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_offset(buffer, out iter, char_offset);
		return buffer;
	}

	public static int GetLineCount(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_line_count(buffer);
	}

	public static GtkTextMarkHandle GetMark(this GtkTextBufferHandle buffer, string name)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_mark(buffer, name);
	}

	public static uint GetMaxUndoLevels(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_max_undo_levels(buffer);
	}

	public static bool GetModified(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_modified(buffer);
	}

	public static GtkTextMarkHandle GetSelectionBound(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_selection_bound(buffer);
	}

	public static bool GetSelectionBounds(this GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_selection_bounds(buffer, out start, out end);
	}

	public static GdkContentProviderHandle GetSelectionContent(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_selection_content(buffer);
	}

	public static string GetSlice(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_slice(buffer, start, end, include_hidden_chars);
	}

	public static GtkTextBufferHandle GetStartIter(this GtkTextBufferHandle buffer, out GtkTextIter iter)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_start_iter(buffer, out iter);
		return buffer;
	}

	public static GtkTextTagTableHandle GetTagTable(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_tag_table(buffer);
	}

	public static string GetText(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_text(buffer, start, end, include_hidden_chars);
	}

	public static GtkTextBufferHandle Insert(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert(buffer, iter, text, len);
		return buffer;
	}

	public static GtkTextBufferHandle InsertAtCursor(this GtkTextBufferHandle buffer, string text, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_at_cursor(buffer, text, len);
		return buffer;
	}

	public static GtkTextBufferHandle InsertChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_child_anchor(buffer, iter, anchor);
		return buffer;
	}

	public static bool InsertInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_insert_interactive(buffer, iter, text, len, default_editable);
	}

	public static bool InsertInteractiveAtCursor(this GtkTextBufferHandle buffer, string text, int len, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_insert_interactive_at_cursor(buffer, text, len, default_editable);
	}

	public static GtkTextBufferHandle InsertMarkup(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string markup, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_markup(buffer, iter, markup, len);
		return buffer;
	}

	public static GtkTextBufferHandle InsertPaintable(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GdkPaintableHandle paintable)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_paintable(buffer, iter, paintable);
		return buffer;
	}

	public static GtkTextBufferHandle InsertRange(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_range(buffer, iter, start, end);
		return buffer;
	}

	public static bool InsertRangeInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_insert_range_interactive(buffer, iter, start, end, default_editable);
	}

	public static GtkTextBufferHandle InsertWithTags(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, GtkTextTagHandle first_tag, IntPtr @__arglist)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_with_tags(buffer, iter, text, len, first_tag, @__arglist);
		return buffer;
	}

	public static GtkTextBufferHandle InsertWithTagsByName(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_with_tags_by_name(buffer, iter, text, len, first_tag_name, @__arglist);
		return buffer;
	}

	public static GtkTextBufferHandle MoveMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_move_mark(buffer, mark, where);
		return buffer;
	}

	public static GtkTextBufferHandle MoveMarkByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_move_mark_by_name(buffer, name, where);
		return buffer;
	}

	public static GtkTextBufferHandle PasteClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, GtkTextIterHandle override_location, bool default_editable)
	{
		GtkTextBufferExterns.gtk_text_buffer_paste_clipboard(buffer, clipboard, override_location, default_editable);
		return buffer;
	}

	public static GtkTextBufferHandle PlaceCursor(this GtkTextBufferHandle buffer, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_place_cursor(buffer, where);
		return buffer;
	}

	public static GtkTextBufferHandle Redo(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_redo(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveAllTags(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_all_tags(buffer, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveSelectionClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_selection_clipboard(buffer, clipboard);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveTag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_tag(buffer, tag, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveTagByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_tag_by_name(buffer, name, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle SelectRange(this GtkTextBufferHandle buffer, GtkTextIterHandle ins, GtkTextIterHandle bound)
	{
		GtkTextBufferExterns.gtk_text_buffer_select_range(buffer, ins, bound);
		return buffer;
	}

	public static GtkTextBufferHandle SetEnableUndo(this GtkTextBufferHandle buffer, bool enable_undo)
	{
		GtkTextBufferExterns.gtk_text_buffer_set_enable_undo(buffer, enable_undo);
		return buffer;
	}

	public static GtkTextBufferHandle SetMaxUndoLevels(this GtkTextBufferHandle buffer, uint max_undo_levels)
	{
		GtkTextBufferExterns.gtk_text_buffer_set_max_undo_levels(buffer, max_undo_levels);
		return buffer;
	}

	public static GtkTextBufferHandle SetModified(this GtkTextBufferHandle buffer, bool setting)
	{
		GtkTextBufferExterns.gtk_text_buffer_set_modified(buffer, setting);
		return buffer;
	}

	public static GtkTextBufferHandle SetText(this GtkTextBufferHandle buffer, string text, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_set_text(buffer, text, len);
		return buffer;
	}

	public static GtkTextBufferHandle Undo(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_undo(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle Connect(this GtkTextBufferHandle instance, GtkTextBufferSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkTextBufferExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextBufferHandle gtk_text_buffer_new(GtkTextTagTableHandle table);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_add_mark(GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_add_selection_clipboard(GtkTextBufferHandle buffer, GdkClipboardHandle clipboard);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_apply_tag(GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_apply_tag_by_name(GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_backspace(GtkTextBufferHandle buffer, GtkTextIterHandle iter, bool interactive, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_begin_irreversible_action(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_begin_user_action(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_copy_clipboard(GtkTextBufferHandle buffer, GdkClipboardHandle clipboard);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextChildAnchorHandle gtk_text_buffer_create_child_anchor(GtkTextBufferHandle buffer, GtkTextIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_create_mark(GtkTextBufferHandle buffer, string mark_name, GtkTextIterHandle where, bool left_gravity);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagHandle gtk_text_buffer_create_tag(GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_cut_clipboard(GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_delete(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_delete_interactive(GtkTextBufferHandle buffer, GtkTextIterHandle start_iter, GtkTextIterHandle end_iter, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_delete_mark(GtkTextBufferHandle buffer, GtkTextMarkHandle mark);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_delete_mark_by_name(GtkTextBufferHandle buffer, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_delete_selection(GtkTextBufferHandle buffer, bool interactive, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_end_irreversible_action(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_end_user_action(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_get_bounds(GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_can_redo(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_can_undo(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_buffer_get_char_count(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_enable_undo(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_get_end_iter(GtkTextBufferHandle buffer, out GtkTextIter iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_has_selection(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_insert(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_get_iter_at_child_anchor(GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextChildAnchorHandle anchor);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_iter_at_line(GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_iter_at_line_index(GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int byte_index);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_iter_at_line_offset(GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int char_offset);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_get_iter_at_mark(GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextMarkHandle mark);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_get_iter_at_offset(GtkTextBufferHandle buffer, out GtkTextIter iter, int char_offset);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_buffer_get_line_count(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_mark(GtkTextBufferHandle buffer, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_text_buffer_get_max_undo_levels(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_modified(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_selection_bound(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_get_selection_bounds(GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentProviderHandle gtk_text_buffer_get_selection_content(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_text_buffer_get_slice(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_get_start_iter(GtkTextBufferHandle buffer, out GtkTextIter iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagTableHandle gtk_text_buffer_get_tag_table(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_text_buffer_get_text(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_at_cursor(GtkTextBufferHandle buffer, string text, int len);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_child_anchor(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_insert_interactive(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_insert_interactive_at_cursor(GtkTextBufferHandle buffer, string text, int len, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_markup(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string markup, int len);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_paintable(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GdkPaintableHandle paintable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_range(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_buffer_insert_range_interactive(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_with_tags(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, GtkTextTagHandle first_tag, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_insert_with_tags_by_name(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_move_mark(GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_move_mark_by_name(GtkTextBufferHandle buffer, string name, GtkTextIterHandle where);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_paste_clipboard(GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, GtkTextIterHandle override_location, bool default_editable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_place_cursor(GtkTextBufferHandle buffer, GtkTextIterHandle where);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_redo(GtkTextBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_remove_all_tags(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_remove_selection_clipboard(GtkTextBufferHandle buffer, GdkClipboardHandle clipboard);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_remove_tag(GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_remove_tag_by_name(GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_select_range(GtkTextBufferHandle buffer, GtkTextIterHandle ins, GtkTextIterHandle bound);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_set_enable_undo(GtkTextBufferHandle buffer, bool enable_undo);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_set_max_undo_levels(GtkTextBufferHandle buffer, uint max_undo_levels);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_set_modified(GtkTextBufferHandle buffer, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_set_text(GtkTextBufferHandle buffer, string text, int len);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_buffer_undo(GtkTextBufferHandle buffer);
}
