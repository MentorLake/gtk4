namespace MentorLake.Gtk4.GObject;

public class GEnumClassHandle : BaseSafeHandle
{
}

internal class GEnumClassExterns
{
}

public struct GEnumClass
{
	public GTypeClass g_type_class;
	public int minimum;
	public int maximum;
	public uint n_values;
	public GEnumValueHandle values;
}
