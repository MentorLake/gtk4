namespace MentorLake.Gtk4.Gio;

public class GDBusMethodInfoHandle : BaseSafeHandle
{
}

internal class GDBusMethodInfoExterns
{
}

public struct GDBusMethodInfo
{
	public int ref_count;
	public string name;
	public GDBusArgInfoHandle[] in_args;
	public GDBusArgInfoHandle[] out_args;
	public GDBusAnnotationInfoHandle[] annotations;
}
