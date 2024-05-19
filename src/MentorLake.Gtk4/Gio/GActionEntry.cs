namespace MentorLake.Gtk4.Gio;

public class GActionEntryHandle : BaseSafeHandle
{
}

internal class GActionEntryExterns
{
}

public struct GActionEntry
{
	public string name;
	public IntPtr activate;
	public string parameter_type;
	public string state;
	public IntPtr change_state;
}
