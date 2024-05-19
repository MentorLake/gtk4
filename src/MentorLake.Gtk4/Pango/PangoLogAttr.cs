namespace MentorLake.Gtk4.Pango;

public class PangoLogAttrHandle : BaseSafeHandle
{
}

internal class PangoLogAttrExterns
{
}

public struct PangoLogAttr
{
	public uint is_line_break;
	public uint is_mandatory_break;
	public uint is_char_break;
	public uint is_white;
	public uint is_cursor_position;
	public uint is_word_start;
	public uint is_word_end;
	public uint is_sentence_boundary;
	public uint is_sentence_start;
	public uint is_sentence_end;
	public uint backspace_deletes_character;
	public uint is_expandable_space;
	public uint is_word_boundary;
	public uint break_inserts_hyphen;
	public uint break_removes_preceding;
	public uint reserved;
}
