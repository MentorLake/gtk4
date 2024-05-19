namespace MentorLake.Gtk4.Pango;

public class PangoItemHandle : BaseSafeHandle
{
	public static PangoItemHandle New()
	{
		return PangoItemExterns.pango_item_new();
	}

}

internal class PangoItemExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoItemHandle pango_item_new();

}

public struct PangoItem
{
	public int offset;
	public int length;
	public int num_chars;
	public PangoAnalysis analysis;
}
