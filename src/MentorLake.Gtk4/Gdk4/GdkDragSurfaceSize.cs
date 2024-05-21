namespace MentorLake.Gtk4.Gdk4;

public class GdkDragSurfaceSizeHandle : BaseSafeHandle
{
}


public static class GdkDragSurfaceSizeHandleExtensions
{
	public static GdkDragSurfaceSizeHandle SetSize(this GdkDragSurfaceSizeHandle size, int width, int height)
	{
		GdkDragSurfaceSizeExterns.gdk_drag_surface_size_set_size(size, width, height);
		return size;
	}

}
internal class GdkDragSurfaceSizeExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drag_surface_size_set_size(GdkDragSurfaceSizeHandle size, int width, int height);

}

public struct GdkDragSurfaceSize
{
}
