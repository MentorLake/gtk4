namespace MentorLake.Gtk4.Gio;

public class GDBusInterfaceInfoHandle : BaseSafeHandle
{
}

internal class GDBusInterfaceInfoExterns
{
}

public struct GDBusInterfaceInfo
{
	public int ref_count;
	public string name;
	public GDBusMethodInfoHandle[] methods;
	public GDBusSignalInfoHandle[] signals;
	public GDBusPropertyInfoHandle[] properties;
	public GDBusAnnotationInfoHandle[] annotations;
}
