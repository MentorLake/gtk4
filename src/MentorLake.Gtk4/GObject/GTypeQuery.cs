namespace MentorLake.Gtk4.GObject;

public class GTypeQueryHandle : BaseSafeHandle
{
}

internal class GTypeQueryExterns
{
}

public struct GTypeQuery
{
	public GType type;
	public string type_name;
	public uint class_size;
	public uint instance_size;
}
