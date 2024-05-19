namespace MentorLake.Gtk4.GLib;

public class GLogFieldHandle : BaseSafeHandle
{
}

internal class GLogFieldExterns
{
}

public struct GLogField
{
	public string key;
	public IntPtr value;
	public int length;
}
