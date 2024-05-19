namespace MentorLake.Gtk4.Pango;

public class PangoAttrClassHandle : BaseSafeHandle
{
}

internal class PangoAttrClassExterns
{
}

public struct PangoAttrClass
{
	public PangoAttrType type;
	public IntPtr copy;
	public IntPtr destroy;
	public IntPtr equal;
}
