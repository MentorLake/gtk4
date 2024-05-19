namespace MentorLake.Gtk4.Gdk4;

public class GdkPopupLayoutHandle : BaseSafeHandle
{
	public static GdkPopupLayoutHandle New(GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_new(anchor_rect, rect_anchor, surface_anchor);
	}

}

internal class GdkPopupLayoutExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_new(GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor);

}

public struct GdkPopupLayout
{
}
