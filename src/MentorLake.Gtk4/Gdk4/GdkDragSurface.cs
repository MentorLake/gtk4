namespace MentorLake.Gtk4.Gdk4;

public interface GdkDragSurfaceHandle
{
}

internal class GdkDragSurfaceHandleImpl : BaseSafeHandle, GdkDragSurfaceHandle
{
}

public static class GdkDragSurfaceHandleExtensions
{
	public static bool Present(this GdkDragSurfaceHandle drag_surface, int width, int height)
	{
		return GdkDragSurfaceExterns.gdk_drag_surface_present(drag_surface, width, height);
	}

}

internal class GdkDragSurfaceExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_drag_surface_present(GdkDragSurfaceHandle drag_surface, int width, int height);

}
