namespace MentorLake.Gtk4.Pango;

public class PangoAttributeHandle : BaseSafeHandle
{
}

internal class PangoAttributeExterns
{
}

public struct PangoAttribute
{
	public PangoAttrClass[] klass;
	public uint start_index;
	public uint end_index;
}
