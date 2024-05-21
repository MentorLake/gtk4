namespace MentorLake.Gtk4.GLib;

public class GTokenValueHandle : BaseSafeHandle
{
}


public static class GTokenValueHandleExtensions
{
}
internal class GTokenValueExterns
{
}

public struct GTokenValue
{
	public IntPtr v_symbol;
	public string v_identifier;
	public ulong v_binary;
	public ulong v_octal;
	public ulong v_int;
	public ulong v_int64;
	public double v_float;
	public ulong v_hex;
	public string v_string;
	public string v_comment;
	public char v_char;
	public uint v_error;
}
