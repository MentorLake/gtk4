namespace MentorLake.Gtk4.Gio;

public class GDBusSubtreeVTableHandle : BaseSafeHandle
{
}

internal class GDBusSubtreeVTableExterns
{
}

public struct GDBusSubtreeVTable
{
	public GDBusSubtreeEnumerateFunc enumerate;
	public GDBusSubtreeIntrospectFunc introspect;
	public GDBusSubtreeDispatchFunc dispatch;
}
