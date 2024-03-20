using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDragSurfaceExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_surface_present")]
	internal static extern int gdk_drag_surface_present(this GdkDragSurfaceHandle drag_surface, int width, int height);
}
