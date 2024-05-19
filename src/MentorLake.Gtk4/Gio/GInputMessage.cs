namespace MentorLake.Gtk4.Gio;

public class GInputMessageHandle : BaseSafeHandle
{
}

internal class GInputMessageExterns
{
}

public struct GInputMessage
{
	public IntPtr address;
	public GInputVectorHandle vectors;
	public uint num_vectors;
	public int bytes_received;
	public int flags;
	public IntPtr control_messages;
	public uint[] num_control_messages;
}
