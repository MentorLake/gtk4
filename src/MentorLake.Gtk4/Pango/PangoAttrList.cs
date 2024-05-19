namespace MentorLake.Gtk4.Pango;

public class PangoAttrListHandle : BaseSafeHandle
{
	public static PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}

}

internal class PangoAttrListExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_new();

}

public struct PangoAttrList
{
}
