using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public class GdkDrawContextHandle : GObjectHandle
{
}

public static class GdkDrawContextSignals
{
}

public static class GdkDrawContextHandleExtensions
{
	public static GdkDrawContextHandle BeginFrame(this GdkDrawContextHandle context, cairo_region_tHandle region)
	{
		GdkDrawContextExterns.gdk_draw_context_begin_frame(context, region);
		return context;
	}

	public static GdkDrawContextHandle EndFrame(this GdkDrawContextHandle context)
	{
		GdkDrawContextExterns.gdk_draw_context_end_frame(context);
		return context;
	}

	public static GdkDisplayHandle GetDisplay(this GdkDrawContextHandle context)
	{
		return GdkDrawContextExterns.gdk_draw_context_get_display(context);
	}

	public static cairo_region_tHandle GetFrameRegion(this GdkDrawContextHandle context)
	{
		return GdkDrawContextExterns.gdk_draw_context_get_frame_region(context);
	}

	public static GdkSurfaceHandle GetSurface(this GdkDrawContextHandle context)
	{
		return GdkDrawContextExterns.gdk_draw_context_get_surface(context);
	}

	public static bool IsInFrame(this GdkDrawContextHandle context)
	{
		return GdkDrawContextExterns.gdk_draw_context_is_in_frame(context);
	}

}

internal class GdkDrawContextExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_draw_context_begin_frame(GdkDrawContextHandle context, cairo_region_tHandle region);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_draw_context_end_frame(GdkDrawContextHandle context);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_draw_context_get_display(GdkDrawContextHandle context);
	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_region_tHandle gdk_draw_context_get_frame_region(GdkDrawContextHandle context);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_draw_context_get_surface(GdkDrawContextHandle context);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_draw_context_is_in_frame(GdkDrawContextHandle context);
}
