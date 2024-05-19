namespace MentorLake.Gtk4.Gio;

public class GDBusAnnotationInfoHandle : BaseSafeHandle
{
}

internal class GDBusAnnotationInfoExterns
{
}

public struct GDBusAnnotationInfo
{
	public int ref_count;
	public string key;
	public string value;
	public GDBusAnnotationInfoHandle[] annotations;
}
