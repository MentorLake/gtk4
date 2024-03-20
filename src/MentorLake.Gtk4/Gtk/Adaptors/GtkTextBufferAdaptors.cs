using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextBufferAdaptors
{
    public static int GetLineCount(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_line_count(buffer);
    }

    public static int GetCharCount(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_char_count(buffer);
    }

    public static GtkTextTagTableHandle GetTagTable(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_tag_table(buffer);
    }

    public static GtkTextBufferHandle SetText(this GtkTextBufferHandle buffer, string text, int len)
    {
        GtkTextBufferExterns.gtk_text_buffer_set_text(buffer, text, len);
        return buffer;
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

    public static int InsertInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, int default_editable)
    {
        return GtkTextBufferExterns.gtk_text_buffer_insert_interactive(buffer, iter, text, len, default_editable);
    }

    public static int InsertInteractiveAtCursor(this GtkTextBufferHandle buffer, string text, int len, int default_editable)
    {
        return GtkTextBufferExterns.gtk_text_buffer_insert_interactive_at_cursor(buffer, text, len, default_editable);
    }

    public static GtkTextBufferHandle InsertRange(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_insert_range(buffer, iter, start, end);
        return buffer;
    }

    public static int InsertRangeInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end, int default_editable)
    {
        return GtkTextBufferExterns.gtk_text_buffer_insert_range_interactive(buffer, iter, start, end, default_editable);
    }

    public static GtkTextBufferHandle InsertWithTags(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, GtkTextTagHandle first_tag, IntPtr @__argList)
    {
        GtkTextBufferExterns.gtk_text_buffer_insert_with_tags(buffer, iter, text, len, first_tag, @__argList);
        return buffer;
    }

    public static GtkTextBufferHandle InsertWithTagsByName(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__argList)
    {
        GtkTextBufferExterns.gtk_text_buffer_insert_with_tags_by_name(buffer, iter, text, len, first_tag_name, @__argList);
        return buffer;
    }

    public static GtkTextBufferHandle InsertMarkup(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string markup, int len)
    {
        GtkTextBufferExterns.gtk_text_buffer_insert_markup(buffer, iter, markup, len);
        return buffer;
    }

    public static GtkTextBufferHandle Delete(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_delete(buffer, start, end);
        return buffer;
    }

    public static int DeleteInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle start_iter, GtkTextIterHandle end_iter, int default_editable)
    {
        return GtkTextBufferExterns.gtk_text_buffer_delete_interactive(buffer, start_iter, end_iter, default_editable);
    }

    public static int Backspace(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int interactive, int default_editable)
    {
        return GtkTextBufferExterns.gtk_text_buffer_backspace(buffer, iter, interactive, default_editable);
    }

    public static string GetText(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, int include_hidden_chars)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_text(buffer, start, end, include_hidden_chars);
    }

    public static string GetSlice(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, int include_hidden_chars)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_slice(buffer, start, end, include_hidden_chars);
    }

    public static GtkTextBufferHandle InsertPaintable(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GdkPaintableHandle paintable)
    {
        GtkTextBufferExterns.gtk_text_buffer_insert_paintable(buffer, iter, paintable);
        return buffer;
    }

    public static GtkTextBufferHandle InsertChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor)
    {
        GtkTextBufferExterns.gtk_text_buffer_insert_child_anchor(buffer, iter, anchor);
        return buffer;
    }

    public static GtkTextChildAnchorHandle CreateChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter)
    {
        return GtkTextBufferExterns.gtk_text_buffer_create_child_anchor(buffer, iter);
    }

    public static GtkTextBufferHandle AddMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where)
    {
        GtkTextBufferExterns.gtk_text_buffer_add_mark(buffer, mark, where);
        return buffer;
    }

    public static GtkTextMarkHandle CreateMark(this GtkTextBufferHandle buffer, string mark_name, GtkTextIterHandle where, int left_gravity)
    {
        return GtkTextBufferExterns.gtk_text_buffer_create_mark(buffer, mark_name, where, left_gravity);
    }

    public static GtkTextBufferHandle MoveMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where)
    {
        GtkTextBufferExterns.gtk_text_buffer_move_mark(buffer, mark, where);
        return buffer;
    }

    public static GtkTextBufferHandle DeleteMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark)
    {
        GtkTextBufferExterns.gtk_text_buffer_delete_mark(buffer, mark);
        return buffer;
    }

    public static GtkTextMarkHandle GetMark(this GtkTextBufferHandle buffer, string name)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_mark(buffer, name);
    }

    public static GtkTextBufferHandle MoveMarkByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle where)
    {
        GtkTextBufferExterns.gtk_text_buffer_move_mark_by_name(buffer, name, where);
        return buffer;
    }

    public static GtkTextBufferHandle DeleteMarkByName(this GtkTextBufferHandle buffer, string name)
    {
        GtkTextBufferExterns.gtk_text_buffer_delete_mark_by_name(buffer, name);
        return buffer;
    }

    public static GtkTextMarkHandle GetInsert(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_insert(buffer);
    }

    public static GtkTextMarkHandle GetSelectionBound(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_selection_bound(buffer);
    }

    public static GtkTextBufferHandle PlaceCursor(this GtkTextBufferHandle buffer, GtkTextIterHandle where)
    {
        GtkTextBufferExterns.gtk_text_buffer_place_cursor(buffer, where);
        return buffer;
    }

    public static GtkTextBufferHandle SelectRange(this GtkTextBufferHandle buffer, GtkTextIterHandle ins, GtkTextIterHandle bound)
    {
        GtkTextBufferExterns.gtk_text_buffer_select_range(buffer, ins, bound);
        return buffer;
    }

    public static GtkTextBufferHandle ApplyTag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_apply_tag(buffer, tag, start, end);
        return buffer;
    }

    public static GtkTextBufferHandle RemoveTag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_remove_tag(buffer, tag, start, end);
        return buffer;
    }

    public static GtkTextBufferHandle ApplyTagByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_apply_tag_by_name(buffer, name, start, end);
        return buffer;
    }

    public static GtkTextBufferHandle RemoveTagByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_remove_tag_by_name(buffer, name, start, end);
        return buffer;
    }

    public static GtkTextBufferHandle RemoveAllTags(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_remove_all_tags(buffer, start, end);
        return buffer;
    }

    public static GtkTextTagHandle CreateTag(this GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__argList)
    {
        return GtkTextBufferExterns.gtk_text_buffer_create_tag(buffer, tag_name, first_property_name, @__argList);
    }

    public static int GetIterAtLineOffset(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int line_number, int char_offset)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line_offset(buffer, iter, line_number, char_offset);
    }

    public static int GetIterAtLineIndex(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int line_number, int byte_index)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line_index(buffer, iter, line_number, byte_index);
    }

    public static GtkTextBufferHandle GetIterAtOffset(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int char_offset)
    {
        GtkTextBufferExterns.gtk_text_buffer_get_iter_at_offset(buffer, iter, char_offset);
        return buffer;
    }

    public static int GetIterAtLine(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, int line_number)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line(buffer, iter, line_number);
    }

    public static GtkTextBufferHandle GetStartIter(this GtkTextBufferHandle buffer, GtkTextIterHandle iter)
    {
        GtkTextBufferExterns.gtk_text_buffer_get_start_iter(buffer, iter);
        return buffer;
    }

    public static GtkTextBufferHandle GetEndIter(this GtkTextBufferHandle buffer, GtkTextIterHandle iter)
    {
        GtkTextBufferExterns.gtk_text_buffer_get_end_iter(buffer, iter);
        return buffer;
    }

    public static GtkTextBufferHandle GetBounds(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        GtkTextBufferExterns.gtk_text_buffer_get_bounds(buffer, start, end);
        return buffer;
    }

    public static GtkTextBufferHandle GetIterAtMark(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextMarkHandle mark)
    {
        GtkTextBufferExterns.gtk_text_buffer_get_iter_at_mark(buffer, iter, mark);
        return buffer;
    }

    public static GtkTextBufferHandle GetIterAtChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor)
    {
        GtkTextBufferExterns.gtk_text_buffer_get_iter_at_child_anchor(buffer, iter, anchor);
        return buffer;
    }

    public static int GetModified(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_modified(buffer);
    }

    public static GtkTextBufferHandle SetModified(this GtkTextBufferHandle buffer, int setting)
    {
        GtkTextBufferExterns.gtk_text_buffer_set_modified(buffer, setting);
        return buffer;
    }

    public static int GetHasSelection(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_has_selection(buffer);
    }

    public static GtkTextBufferHandle AddSelectionClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard)
    {
        GtkTextBufferExterns.gtk_text_buffer_add_selection_clipboard(buffer, clipboard);
        return buffer;
    }

    public static GtkTextBufferHandle RemoveSelectionClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard)
    {
        GtkTextBufferExterns.gtk_text_buffer_remove_selection_clipboard(buffer, clipboard);
        return buffer;
    }

    public static GtkTextBufferHandle CutClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, int default_editable)
    {
        GtkTextBufferExterns.gtk_text_buffer_cut_clipboard(buffer, clipboard, default_editable);
        return buffer;
    }

    public static GtkTextBufferHandle CopyClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard)
    {
        GtkTextBufferExterns.gtk_text_buffer_copy_clipboard(buffer, clipboard);
        return buffer;
    }

    public static GtkTextBufferHandle PasteClipboard(this GtkTextBufferHandle buffer, GdkClipboardHandle clipboard, GtkTextIterHandle override_location, int default_editable)
    {
        GtkTextBufferExterns.gtk_text_buffer_paste_clipboard(buffer, clipboard, override_location, default_editable);
        return buffer;
    }

    public static int GetSelectionBounds(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_selection_bounds(buffer, start, end);
    }

    public static int DeleteSelection(this GtkTextBufferHandle buffer, int interactive, int default_editable)
    {
        return GtkTextBufferExterns.gtk_text_buffer_delete_selection(buffer, interactive, default_editable);
    }

    public static GdkContentProviderHandle GetSelectionContent(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_selection_content(buffer);
    }

    public static int GetCanUndo(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_can_undo(buffer);
    }

    public static int GetCanRedo(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_can_redo(buffer);
    }

    public static int GetEnableUndo(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_enable_undo(buffer);
    }

    public static GtkTextBufferHandle SetEnableUndo(this GtkTextBufferHandle buffer, int enable_undo)
    {
        GtkTextBufferExterns.gtk_text_buffer_set_enable_undo(buffer, enable_undo);
        return buffer;
    }

    public static uint GetMaxUndoLevels(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_buffer_get_max_undo_levels(buffer);
    }

    public static GtkTextBufferHandle SetMaxUndoLevels(this GtkTextBufferHandle buffer, uint max_undo_levels)
    {
        GtkTextBufferExterns.gtk_text_buffer_set_max_undo_levels(buffer, max_undo_levels);
        return buffer;
    }

    public static GtkTextBufferHandle Undo(this GtkTextBufferHandle buffer)
    {
        GtkTextBufferExterns.gtk_text_buffer_undo(buffer);
        return buffer;
    }

    public static GtkTextBufferHandle Redo(this GtkTextBufferHandle buffer)
    {
        GtkTextBufferExterns.gtk_text_buffer_redo(buffer);
        return buffer;
    }

    public static GtkTextBufferHandle BeginIrreversibleAction(this GtkTextBufferHandle buffer)
    {
        GtkTextBufferExterns.gtk_text_buffer_begin_irreversible_action(buffer);
        return buffer;
    }

    public static GtkTextBufferHandle EndIrreversibleAction(this GtkTextBufferHandle buffer)
    {
        GtkTextBufferExterns.gtk_text_buffer_end_irreversible_action(buffer);
        return buffer;
    }

    public static GtkTextBufferHandle BeginUserAction(this GtkTextBufferHandle buffer)
    {
        GtkTextBufferExterns.gtk_text_buffer_begin_user_action(buffer);
        return buffer;
    }

    public static GtkTextBufferHandle EndUserAction(this GtkTextBufferHandle buffer)
    {
        GtkTextBufferExterns.gtk_text_buffer_end_user_action(buffer);
        return buffer;
    }

    public static GtkTextViewHandle GtkTextViewNewWithBuffer(this GtkTextBufferHandle buffer)
    {
        return GtkTextBufferExterns.gtk_text_view_new_with_buffer(buffer);
    }
}
