namespace MentorLake.Gtk4.Gio;

public class GDBusArgInfoHandle : BaseSafeHandle
{
}

internal class GDBusArgInfoExterns
{
}

public struct GDBusArgInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusAnnotationInfoHandle[] annotations;
}
