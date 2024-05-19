namespace MentorLake.Gtk4.Gio;

public class GDBusPropertyInfoHandle : BaseSafeHandle
{
}

internal class GDBusPropertyInfoExterns
{
}

public struct GDBusPropertyInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusPropertyInfoFlags flags;
	public GDBusAnnotationInfoHandle[] annotations;
}
