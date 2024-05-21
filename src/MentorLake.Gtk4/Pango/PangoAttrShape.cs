namespace MentorLake.Gtk4.Pango;

public class PangoAttrShapeHandle : BaseSafeHandle
{
}


public static class PangoAttrShapeHandleExtensions
{
}
internal class PangoAttrShapeExterns
{
}

public struct PangoAttrShape
{
	public PangoAttribute attr;
	public PangoRectangle ink_rect;
	public PangoRectangle logical_rect;
	public IntPtr data;
	public PangoAttrDataCopyFunc copy_func;
	public GDestroyNotify destroy_func;
}
