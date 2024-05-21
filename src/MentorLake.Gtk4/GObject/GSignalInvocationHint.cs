namespace MentorLake.Gtk4.GObject;

public class GSignalInvocationHintHandle : BaseSafeHandle
{
}


public static class GSignalInvocationHintHandleExtensions
{
}
internal class GSignalInvocationHintExterns
{
}

public struct GSignalInvocationHint
{
	public uint signal_id;
	public GQuark detail;
	public GSignalFlags run_type;
}
