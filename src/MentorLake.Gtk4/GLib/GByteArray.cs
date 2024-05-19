namespace MentorLake.Gtk4.GLib;

public class GByteArrayHandle : BaseSafeHandle
{
}

internal class GByteArrayExterns
{
}

public struct GByteArray
{
	public byte[] data;
	public uint len;
}
