namespace MentorLake.Gtk4.Gio;

public class GOutputMessageHandle : BaseSafeHandle
{
}


public static class GOutputMessageHandleExtensions
{
}
internal class GOutputMessageExterns
{
}

public struct GOutputMessage
{
	public GSocketAddressHandle address;
	public GOutputVectorHandle vectors;
	public uint num_vectors;
	public uint bytes_sent;
	public IntPtr control_messages;
	public uint num_control_messages;
}
