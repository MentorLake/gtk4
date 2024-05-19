namespace MentorLake.Gtk4.Gio;

public class GDBusSignalInfoHandle : BaseSafeHandle
{
}

internal class GDBusSignalInfoExterns
{
}

public struct GDBusSignalInfo
{
	public int ref_count;
	public string name;
	public GDBusArgInfoHandle[] args;
	public GDBusAnnotationInfoHandle[] annotations;
}
