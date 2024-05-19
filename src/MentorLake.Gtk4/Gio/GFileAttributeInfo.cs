namespace MentorLake.Gtk4.Gio;

public class GFileAttributeInfoHandle : BaseSafeHandle
{
}

internal class GFileAttributeInfoExterns
{
}

public struct GFileAttributeInfo
{
	public string name;
	public GFileAttributeType type;
	public GFileAttributeInfoFlags flags;
}
