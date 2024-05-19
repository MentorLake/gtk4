namespace MentorLake.Gtk4.GLib;

public class GOptionEntryHandle : BaseSafeHandle
{
}

internal class GOptionEntryExterns
{
}

public struct GOptionEntry
{
	public string long_name;
	public char short_name;
	public int flags;
	public GOptionArg arg;
	public IntPtr arg_data;
	public string description;
	public string arg_description;
}
