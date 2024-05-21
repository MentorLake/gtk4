namespace MentorLake.Gtk4.Gtk4;

public class GtkTextIterHandle : BaseSafeHandle
{
}


public static class GtkTextIterHandleExtensions
{
	public static GtkTextIterHandle Assign(this GtkTextIterHandle iter, GtkTextIterHandle other)
	{
		GtkTextIterExterns.gtk_text_iter_assign(iter, other);
		return iter;
	}

	public static bool BackwardChar(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_char(iter);
	}

	public static bool BackwardChars(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_chars(iter, count);
	}

	public static bool BackwardCursorPosition(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_cursor_position(iter);
	}

	public static bool BackwardCursorPositions(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_cursor_positions(iter, count);
	}

	public static bool BackwardFindChar(this GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_find_char(iter, pred, user_data, limit);
	}

	public static bool BackwardLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_line(iter);
	}

	public static bool BackwardLines(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_lines(iter, count);
	}

	public static bool BackwardSearch(this GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, out GtkTextIter match_start, out GtkTextIter match_end, GtkTextIterHandle limit)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_search(iter, str, flags, out match_start, out match_end, limit);
	}

	public static bool BackwardSentenceStart(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_sentence_start(iter);
	}

	public static bool BackwardSentenceStarts(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_sentence_starts(iter, count);
	}

	public static bool BackwardToTagToggle(this GtkTextIterHandle iter, GtkTextTagHandle tag)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_to_tag_toggle(iter, tag);
	}

	public static bool BackwardVisibleCursorPosition(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_position(iter);
	}

	public static bool BackwardVisibleCursorPositions(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_positions(iter, count);
	}

	public static bool BackwardVisibleLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_visible_line(iter);
	}

	public static bool BackwardVisibleLines(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_visible_lines(iter, count);
	}

	public static bool BackwardVisibleWordStart(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_visible_word_start(iter);
	}

	public static bool BackwardVisibleWordStarts(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_visible_word_starts(iter, count);
	}

	public static bool BackwardWordStart(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_word_start(iter);
	}

	public static bool BackwardWordStarts(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_backward_word_starts(iter, count);
	}

	public static bool CanInsert(this GtkTextIterHandle iter, bool default_editability)
	{
		return GtkTextIterExterns.gtk_text_iter_can_insert(iter, default_editability);
	}

	public static int Compare(this GtkTextIterHandle lhs, GtkTextIterHandle rhs)
	{
		return GtkTextIterExterns.gtk_text_iter_compare(lhs, rhs);
	}

	public static GtkTextIterHandle Copy(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_copy(iter);
	}

	public static bool Editable(this GtkTextIterHandle iter, bool default_setting)
	{
		return GtkTextIterExterns.gtk_text_iter_editable(iter, default_setting);
	}

	public static bool EndsLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_ends_line(iter);
	}

	public static bool EndsSentence(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_ends_sentence(iter);
	}

	public static bool EndsTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
	{
		return GtkTextIterExterns.gtk_text_iter_ends_tag(iter, tag);
	}

	public static bool EndsWord(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_ends_word(iter);
	}

	public static bool Equal(this GtkTextIterHandle lhs, GtkTextIterHandle rhs)
	{
		return GtkTextIterExterns.gtk_text_iter_equal(lhs, rhs);
	}

	public static bool ForwardChar(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_char(iter);
	}

	public static bool ForwardChars(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_chars(iter, count);
	}

	public static bool ForwardCursorPosition(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_cursor_position(iter);
	}

	public static bool ForwardCursorPositions(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_cursor_positions(iter, count);
	}

	public static bool ForwardFindChar(this GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_find_char(iter, pred, user_data, limit);
	}

	public static bool ForwardLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_line(iter);
	}

	public static bool ForwardLines(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_lines(iter, count);
	}

	public static bool ForwardSearch(this GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, out GtkTextIter match_start, out GtkTextIter match_end, GtkTextIterHandle limit)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_search(iter, str, flags, out match_start, out match_end, limit);
	}

	public static bool ForwardSentenceEnd(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_sentence_end(iter);
	}

	public static bool ForwardSentenceEnds(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_sentence_ends(iter, count);
	}

	public static GtkTextIterHandle ForwardToEnd(this GtkTextIterHandle iter)
	{
		GtkTextIterExterns.gtk_text_iter_forward_to_end(iter);
		return iter;
	}

	public static bool ForwardToLineEnd(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_to_line_end(iter);
	}

	public static bool ForwardToTagToggle(this GtkTextIterHandle iter, GtkTextTagHandle tag)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_to_tag_toggle(iter, tag);
	}

	public static bool ForwardVisibleCursorPosition(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_position(iter);
	}

	public static bool ForwardVisibleCursorPositions(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_positions(iter, count);
	}

	public static bool ForwardVisibleLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_visible_line(iter);
	}

	public static bool ForwardVisibleLines(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_visible_lines(iter, count);
	}

	public static bool ForwardVisibleWordEnd(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_visible_word_end(iter);
	}

	public static bool ForwardVisibleWordEnds(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_visible_word_ends(iter, count);
	}

	public static bool ForwardWordEnd(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_word_end(iter);
	}

	public static bool ForwardWordEnds(this GtkTextIterHandle iter, int count)
	{
		return GtkTextIterExterns.gtk_text_iter_forward_word_ends(iter, count);
	}

	public static GtkTextIterHandle Free(this GtkTextIterHandle iter)
	{
		GtkTextIterExterns.gtk_text_iter_free(iter);
		return iter;
	}

	public static GtkTextBufferHandle GetBuffer(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_buffer(iter);
	}

	public static int GetBytesInLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_bytes_in_line(iter);
	}

	public static char GetChar(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_char(iter);
	}

	public static int GetCharsInLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_chars_in_line(iter);
	}

	public static GtkTextChildAnchorHandle GetChildAnchor(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_child_anchor(iter);
	}

	public static PangoLanguageHandle GetLanguage(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_language(iter);
	}

	public static int GetLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_line(iter);
	}

	public static int GetLineIndex(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_line_index(iter);
	}

	public static int GetLineOffset(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_line_offset(iter);
	}

	public static GSListHandle GetMarks(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_marks(iter);
	}

	public static int GetOffset(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_offset(iter);
	}

	public static GdkPaintableHandle GetPaintable(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_paintable(iter);
	}

	public static string GetSlice(this GtkTextIterHandle start, GtkTextIterHandle end)
	{
		return GtkTextIterExterns.gtk_text_iter_get_slice(start, end);
	}

	public static GSListHandle GetTags(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_tags(iter);
	}

	public static string GetText(this GtkTextIterHandle start, GtkTextIterHandle end)
	{
		return GtkTextIterExterns.gtk_text_iter_get_text(start, end);
	}

	public static GSListHandle GetToggledTags(this GtkTextIterHandle iter, bool toggled_on)
	{
		return GtkTextIterExterns.gtk_text_iter_get_toggled_tags(iter, toggled_on);
	}

	public static int GetVisibleLineIndex(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_visible_line_index(iter);
	}

	public static int GetVisibleLineOffset(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_get_visible_line_offset(iter);
	}

	public static string GetVisibleSlice(this GtkTextIterHandle start, GtkTextIterHandle end)
	{
		return GtkTextIterExterns.gtk_text_iter_get_visible_slice(start, end);
	}

	public static string GetVisibleText(this GtkTextIterHandle start, GtkTextIterHandle end)
	{
		return GtkTextIterExterns.gtk_text_iter_get_visible_text(start, end);
	}

	public static bool HasTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
	{
		return GtkTextIterExterns.gtk_text_iter_has_tag(iter, tag);
	}

	public static bool InRange(this GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		return GtkTextIterExterns.gtk_text_iter_in_range(iter, start, end);
	}

	public static bool InsideSentence(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_inside_sentence(iter);
	}

	public static bool InsideWord(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_inside_word(iter);
	}

	public static bool IsCursorPosition(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_is_cursor_position(iter);
	}

	public static bool IsEnd(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_is_end(iter);
	}

	public static bool IsStart(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_is_start(iter);
	}

	public static GtkTextIterHandle Order(this GtkTextIterHandle first, GtkTextIterHandle second)
	{
		GtkTextIterExterns.gtk_text_iter_order(first, second);
		return first;
	}

	public static GtkTextIterHandle SetLine(this GtkTextIterHandle iter, int line_number)
	{
		GtkTextIterExterns.gtk_text_iter_set_line(iter, line_number);
		return iter;
	}

	public static GtkTextIterHandle SetLineIndex(this GtkTextIterHandle iter, int byte_on_line)
	{
		GtkTextIterExterns.gtk_text_iter_set_line_index(iter, byte_on_line);
		return iter;
	}

	public static GtkTextIterHandle SetLineOffset(this GtkTextIterHandle iter, int char_on_line)
	{
		GtkTextIterExterns.gtk_text_iter_set_line_offset(iter, char_on_line);
		return iter;
	}

	public static GtkTextIterHandle SetOffset(this GtkTextIterHandle iter, int char_offset)
	{
		GtkTextIterExterns.gtk_text_iter_set_offset(iter, char_offset);
		return iter;
	}

	public static GtkTextIterHandle SetVisibleLineIndex(this GtkTextIterHandle iter, int byte_on_line)
	{
		GtkTextIterExterns.gtk_text_iter_set_visible_line_index(iter, byte_on_line);
		return iter;
	}

	public static GtkTextIterHandle SetVisibleLineOffset(this GtkTextIterHandle iter, int char_on_line)
	{
		GtkTextIterExterns.gtk_text_iter_set_visible_line_offset(iter, char_on_line);
		return iter;
	}

	public static bool StartsLine(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_starts_line(iter);
	}

	public static bool StartsSentence(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_starts_sentence(iter);
	}

	public static bool StartsTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
	{
		return GtkTextIterExterns.gtk_text_iter_starts_tag(iter, tag);
	}

	public static bool StartsWord(this GtkTextIterHandle iter)
	{
		return GtkTextIterExterns.gtk_text_iter_starts_word(iter);
	}

	public static bool TogglesTag(this GtkTextIterHandle iter, GtkTextTagHandle tag)
	{
		return GtkTextIterExterns.gtk_text_iter_toggles_tag(iter, tag);
	}

}
internal class GtkTextIterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_assign(GtkTextIterHandle iter, GtkTextIterHandle other);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_char(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_chars(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_cursor_position(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_cursor_positions(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_find_char(GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_lines(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_search(GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, out GtkTextIter match_start, out GtkTextIter match_end, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_sentence_start(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_sentence_starts(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_to_tag_toggle(GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_visible_cursor_position(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_visible_cursor_positions(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_visible_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_visible_lines(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_visible_word_start(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_visible_word_starts(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_word_start(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_backward_word_starts(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_can_insert(GtkTextIterHandle iter, bool default_editability);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_compare(GtkTextIterHandle lhs, GtkTextIterHandle rhs);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextIterHandle gtk_text_iter_copy(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_editable(GtkTextIterHandle iter, bool default_setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_ends_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_ends_sentence(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_ends_tag(GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_ends_word(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_equal(GtkTextIterHandle lhs, GtkTextIterHandle rhs);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_char(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_chars(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_cursor_position(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_cursor_positions(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_find_char(GtkTextIterHandle iter, GtkTextCharPredicate pred, IntPtr user_data, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_lines(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_search(GtkTextIterHandle iter, string str, GtkTextSearchFlags flags, out GtkTextIter match_start, out GtkTextIter match_end, GtkTextIterHandle limit);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_sentence_end(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_sentence_ends(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_forward_to_end(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_to_line_end(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_to_tag_toggle(GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_visible_cursor_position(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_visible_cursor_positions(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_visible_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_visible_lines(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_visible_word_end(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_visible_word_ends(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_word_end(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_forward_word_ends(GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_free(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextBufferHandle gtk_text_iter_get_buffer(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_bytes_in_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern char gtk_text_iter_get_char(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_chars_in_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextChildAnchorHandle gtk_text_iter_get_child_anchor(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLanguageHandle gtk_text_iter_get_language(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_line_index(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_line_offset(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GSListHandle gtk_text_iter_get_marks(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_offset(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_text_iter_get_paintable(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_text_iter_get_slice(GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk4)]
	internal static extern GSListHandle gtk_text_iter_get_tags(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_text_iter_get_text(GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk4)]
	internal static extern GSListHandle gtk_text_iter_get_toggled_tags(GtkTextIterHandle iter, bool toggled_on);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_visible_line_index(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_iter_get_visible_line_offset(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_text_iter_get_visible_slice(GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_text_iter_get_visible_text(GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_has_tag(GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_in_range(GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_inside_sentence(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_inside_word(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_is_cursor_position(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_is_end(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_is_start(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_order(GtkTextIterHandle first, GtkTextIterHandle second);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_set_line(GtkTextIterHandle iter, int line_number);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_set_line_index(GtkTextIterHandle iter, int byte_on_line);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_set_line_offset(GtkTextIterHandle iter, int char_on_line);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_set_offset(GtkTextIterHandle iter, int char_offset);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_set_visible_line_index(GtkTextIterHandle iter, int byte_on_line);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_iter_set_visible_line_offset(GtkTextIterHandle iter, int char_on_line);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_starts_line(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_starts_sentence(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_starts_tag(GtkTextIterHandle iter, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_starts_word(GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_iter_toggles_tag(GtkTextIterHandle iter, GtkTextTagHandle tag);

}

public struct GtkTextIter
{
}
