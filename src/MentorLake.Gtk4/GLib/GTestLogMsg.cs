namespace MentorLake.Gtk4.GLib;

public class GTestLogMsgHandle : BaseSafeHandle
{
}

internal class GTestLogMsgExterns
{
}

public struct GTestLogMsg
{
	public GTestLogType log_type;
	public uint n_strings;
	public string[] strings;
	public uint n_nums;
	public decimal[] nums;
}
