namespace MentorLake.Gtk4.GLib;

public class GPtrArrayHandle : BaseSafeHandle
{
}

internal class GPtrArrayExterns
{
}

public struct GPtrArray
{
	public IntPtr[] pdata;
	public uint len;
}
