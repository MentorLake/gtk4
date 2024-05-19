namespace MentorLake.Gtk4.GLib;

public class GScannerHandle : BaseSafeHandle
{
}

internal class GScannerExterns
{
}

public struct GScanner
{
	public IntPtr user_data;
	public uint max_parse_errors;
	public uint parse_errors;
	public string input_name;
	public GDataHandle qdata;
	public GScannerConfigHandle config;
	public GTokenType token;
	public GTokenValue value;
	public uint line;
	public uint position;
	public GTokenType next_token;
	public GTokenValue next_value;
	public uint next_line;
	public uint next_position;
	public GScannerMsgFunc msg_handler;
}
