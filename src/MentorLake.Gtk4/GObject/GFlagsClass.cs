namespace MentorLake.Gtk4.GObject;

public class GFlagsClassHandle : BaseSafeHandle
{
}

internal class GFlagsClassExterns
{
}

public struct GFlagsClass
{
	public GTypeClass g_type_class;
	public uint mask;
	public uint n_values;
	public GFlagsValueHandle values;
}
