using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDrawContextExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_draw_context_get_display")]
	internal static extern GdkDisplayHandle gdk_draw_context_get_display(this GdkDrawContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_draw_context_get_surface")]
	internal static extern GdkSurfaceHandle gdk_draw_context_get_surface(this GdkDrawContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_draw_context_begin_frame")]
	internal static extern void gdk_draw_context_begin_frame(this GdkDrawContextHandle context, cairo_regionHandle region);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_draw_context_end_frame")]
	internal static extern void gdk_draw_context_end_frame(this GdkDrawContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_draw_context_is_in_frame")]
	internal static extern int gdk_draw_context_is_in_frame(this GdkDrawContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_draw_context_get_frame_region")]
	internal static extern cairo_regionHandle gdk_draw_context_get_frame_region(this GdkDrawContextHandle context);
}
