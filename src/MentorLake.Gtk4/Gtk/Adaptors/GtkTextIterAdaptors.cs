using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextIterAdaptors
{
    public static GtkTextBufferHandle GetBuffer(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_buffer(iter);
    }

    public static GtkTextIterHandle Copy(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_copy(iter);
    }

    public static GtkTextIterHandle Free(this GtkTextIterHandle iter)
    {
        GtkTextIterExterns.gtk_text_iter_free(iter);
        return iter;
    }

    public static GtkTextIterHandle Assign(this GtkTextIterHandle iter, GtkTextIterHandle other)
    {
        GtkTextIterExterns.gtk_text_iter_assign(iter, other);
        return iter;
    }

    public static int GetOffset(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_offset(iter);
    }

    public static int GetLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_line(iter);
    }

    public static int GetLineOffset(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_line_offset(iter);
    }

    public static int GetLineIndex(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_line_index(iter);
    }

    public static int GetVisibleLineOffset(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_visible_line_offset(iter);
    }

    public static int GetVisibleLineIndex(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_visible_line_index(iter);
    }

    public static uint GetChar(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_char(iter);
    }

    public static string GetSlice(this GtkTextIterHandle start, GtkTextIterHandle end)
    {
        return GtkTextIterExterns.gtk_text_iter_get_slice(start, end);
    }

    public static string GetText(this GtkTextIterHandle start, GtkTextIterHandle end)
    {
        return GtkTextIterExterns.gtk_text_iter_get_text(start, end);
    }

    public static string GetVisibleSlice(this GtkTextIterHandle start, GtkTextIterHandle end)
    {
        return GtkTextIterExterns.gtk_text_iter_get_visible_slice(start, end);
    }

    public static string GetVisibleText(this GtkTextIterHandle start, GtkTextIterHandle end)
    {
        return GtkTextIterExterns.gtk_text_iter_get_visible_text(start, end);
    }

    public static GdkPaintableHandle GetPaintable(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_paintable(iter);
    }

    public static GSListHandle GetMarks(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_marks(iter);
    }

    public static GtkTextChildAnchorHandle GetChildAnchor(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_child_anchor(iter);
    }

    public static GSListHandle GetToggledTags(this GtkTextIterHandle iter, int toggled_on)
    {
        return GtkTextIterExterns.gtk_text_iter_get_toggled_tags(iter, toggled_on);
    }

    public static int StartsTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
    {
        return GtkTextIterExterns.gtk_text_iter_starts_tag(iter, tag);
    }

    public static int EndsTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
    {
        return GtkTextIterExterns.gtk_text_iter_ends_tag(iter, tag);
    }

    public static int TogglesTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
    {
        return GtkTextIterExterns.gtk_text_iter_toggles_tag(iter, tag);
    }

    public static int HasTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
    {
        return GtkTextIterExterns.gtk_text_iter_has_tag(iter, tag);
    }

    public static GSListHandle GetTags(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_tags(iter);
    }

    public static int Editable(this GtkTextIterHandle iter, int default_setting)
    {
        return GtkTextIterExterns.gtk_text_iter_editable(iter, default_setting);
    }

    public static int CanInsert(this GtkTextIterHandle iter, int default_editability)
    {
        return GtkTextIterExterns.gtk_text_iter_can_insert(iter, default_editability);
    }

    public static int StartsWord(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_starts_word(iter);
    }

    public static int EndsWord(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_ends_word(iter);
    }

    public static int InsideWord(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_inside_word(iter);
    }

    public static int StartsSentence(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_starts_sentence(iter);
    }

    public static int EndsSentence(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_ends_sentence(iter);
    }

    public static int InsideSentence(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_inside_sentence(iter);
    }

    public static int StartsLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_starts_line(iter);
    }

    public static int EndsLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_ends_line(iter);
    }

    public static int IsCursorPosition(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_is_cursor_position(iter);
    }

    public static int GetCharsInLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_chars_in_line(iter);
    }

    public static int GetBytesInLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_bytes_in_line(iter);
    }

    public static PangoLanguageHandle GetLanguage(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_get_language(iter);
    }

    public static int IsEnd(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_is_end(iter);
    }

    public static int IsStart(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_is_start(iter);
    }

    public static int ForwardChar(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_char(iter);
    }

    public static int BackwardChar(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_char(iter);
    }

    public static int ForwardChars(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_chars(iter, count);
    }

    public static int BackwardChars(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_chars(iter, count);
    }

    public static int ForwardLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_line(iter);
    }

    public static int BackwardLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_line(iter);
    }

    public static int ForwardLines(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_lines(iter, count);
    }

    public static int BackwardLines(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_lines(iter, count);
    }

    public static int ForwardWordEnd(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_word_end(iter);
    }

    public static int BackwardWordStart(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_word_start(iter);
    }

    public static int ForwardWordEnds(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_word_ends(iter, count);
    }

    public static int BackwardWordStarts(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_word_starts(iter, count);
    }

    public static int ForwardVisibleLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_visible_line(iter);
    }

    public static int BackwardVisibleLine(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_visible_line(iter);
    }

    public static int ForwardVisibleLines(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_visible_lines(iter, count);
    }

    public static int BackwardVisibleLines(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_visible_lines(iter, count);
    }

    public static int ForwardVisibleWordEnd(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_visible_word_end(iter);
    }

    public static int BackwardVisibleWordStart(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_visible_word_start(iter);
    }

    public static int ForwardVisibleWordEnds(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_visible_word_ends(iter, count);
    }

    public static int BackwardVisibleWordStarts(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_visible_word_starts(iter, count);
    }

    public static int ForwardSentenceEnd(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_sentence_end(iter);
    }

    public static int BackwardSentenceStart(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_sentence_start(iter);
    }

    public static int ForwardSentenceEnds(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_sentence_ends(iter, count);
    }

    public static int BackwardSentenceStarts(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_sentence_starts(iter, count);
    }

    public static int ForwardCursorPosition(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_cursor_position(iter);
    }

    public static int BackwardCursorPosition(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_cursor_position(iter);
    }

    public static int ForwardCursorPositions(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_cursor_positions(iter, count);
    }

    public static int BackwardCursorPositions(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_cursor_positions(iter, count);
    }

    public static int ForwardVisibleCursorPosition(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_position(iter);
    }

    public static int BackwardVisibleCursorPosition(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_position(iter);
    }

    public static int ForwardVisibleCursorPositions(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_positions(iter, count);
    }

    public static int BackwardVisibleCursorPositions(this GtkTextIterHandle iter, int count)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_positions(iter, count);
    }

    public static GtkTextIterHandle SetOffset(this GtkTextIterHandle iter, int char_offset)
    {
        GtkTextIterExterns.gtk_text_iter_set_offset(iter, char_offset);
        return iter;
    }

    public static GtkTextIterHandle SetLine(this GtkTextIterHandle iter, int line_number)
    {
        GtkTextIterExterns.gtk_text_iter_set_line(iter, line_number);
        return iter;
    }

    public static GtkTextIterHandle SetLineOffset(this GtkTextIterHandle iter, int char_on_line)
    {
        GtkTextIterExterns.gtk_text_iter_set_line_offset(iter, char_on_line);
        return iter;
    }

    public static GtkTextIterHandle SetLineIndex(this GtkTextIterHandle iter, int byte_on_line)
    {
        GtkTextIterExterns.gtk_text_iter_set_line_index(iter, byte_on_line);
        return iter;
    }

    public static GtkTextIterHandle ForwardToEnd(this GtkTextIterHandle iter)
    {
        GtkTextIterExterns.gtk_text_iter_forward_to_end(iter);
        return iter;
    }

    public static int ForwardToLineEnd(this GtkTextIterHandle iter)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_to_line_end(iter);
    }

    public static GtkTextIterHandle SetVisibleLineOffset(this GtkTextIterHandle iter, int char_on_line)
    {
        GtkTextIterExterns.gtk_text_iter_set_visible_line_offset(iter, char_on_line);
        return iter;
    }

    public static GtkTextIterHandle SetVisibleLineIndex(this GtkTextIterHandle iter, int byte_on_line)
    {
        GtkTextIterExterns.gtk_text_iter_set_visible_line_index(iter, byte_on_line);
        return iter;
    }

    public static int ForwardToTagToggle(this GtkTextIterHandle iter, GtkTextTagHandle tag)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_to_tag_toggle(iter, tag);
    }

    public static int BackwardToTagToggle(this GtkTextIterHandle iter, GtkTextTagHandle tag)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_to_tag_toggle(iter, tag);
    }

    public static int ForwardFindChar(this GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_find_char(iter, pred, user_data, limit);
    }

    public static int BackwardFindChar(this GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_find_char(iter, pred, user_data, limit);
    }

    public static int ForwardSearch(this GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, GtkTextIterHandle match_start, GtkTextIterHandle match_end, GtkTextIterHandle limit)
    {
        return GtkTextIterExterns.gtk_text_iter_forward_search(iter, str, flags, match_start, match_end, limit);
    }

    public static int BackwardSearch(this GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, GtkTextIterHandle match_start, GtkTextIterHandle match_end, GtkTextIterHandle limit)
    {
        return GtkTextIterExterns.gtk_text_iter_backward_search(iter, str, flags, match_start, match_end, limit);
    }

    public static int Equal(this GtkTextIterHandle lhs, GtkTextIterHandle rhs)
    {
        return GtkTextIterExterns.gtk_text_iter_equal(lhs, rhs);
    }

    public static int Compare(this GtkTextIterHandle lhs, GtkTextIterHandle rhs)
    {
        return GtkTextIterExterns.gtk_text_iter_compare(lhs, rhs);
    }

    public static int InRange(this GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end)
    {
        return GtkTextIterExterns.gtk_text_iter_in_range(iter, start, end);
    }

    public static GtkTextIterHandle Order(this GtkTextIterHandle first, GtkTextIterHandle second)
    {
        GtkTextIterExterns.gtk_text_iter_order(first, second);
        return first;
    }
}
