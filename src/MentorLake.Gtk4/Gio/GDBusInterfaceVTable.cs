namespace MentorLake.Gtk4.Gio;

public class GDBusInterfaceVTableHandle : BaseSafeHandle
{
}

internal class GDBusInterfaceVTableExterns
{
}

public struct GDBusInterfaceVTable
{
	public GDBusInterfaceMethodCallFunc method_call;
	public GDBusInterfaceGetPropertyFunc get_property;
	public GDBusInterfaceSetPropertyFunc set_property;
}
