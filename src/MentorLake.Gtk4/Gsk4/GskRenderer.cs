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

namespace MentorLake.Gtk4.Gsk4;

public class GskRendererHandle : GObjectHandle
{
	public static GskRendererHandle NewForSurface(GdkSurfaceHandle surface)
	{
		return GskRendererExterns.gsk_renderer_new_for_surface(surface);
	}

}

public static class GskRendererHandleExtensions
{
	public static GdkSurfaceHandle GetSurface(this GskRendererHandle renderer)
	{
		return GskRendererExterns.gsk_renderer_get_surface(renderer);
	}

	public static bool IsRealized(this GskRendererHandle renderer)
	{
		return GskRendererExterns.gsk_renderer_is_realized(renderer);
	}

	public static bool Realize(this GskRendererHandle renderer, GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GskRendererExterns.gsk_renderer_realize(renderer, surface, out error);
	}

	public static bool RealizeForDisplay(this GskRendererHandle renderer, GdkDisplayHandle display, out GErrorHandle error)
	{
		return GskRendererExterns.gsk_renderer_realize_for_display(renderer, display, out error);
	}

	public static GskRendererHandle Render(this GskRendererHandle renderer, GskRenderNodeHandle root, cairo_region_tHandle region)
	{
		GskRendererExterns.gsk_renderer_render(renderer, root, region);
		return renderer;
	}

	public static GdkTextureHandle RenderTexture(this GskRendererHandle renderer, GskRenderNodeHandle root, graphene_rect_tHandle viewport)
	{
		return GskRendererExterns.gsk_renderer_render_texture(renderer, root, viewport);
	}

	public static GskRendererHandle Unrealize(this GskRendererHandle renderer)
	{
		GskRendererExterns.gsk_renderer_unrealize(renderer);
		return renderer;
	}

}

internal class GskRendererExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRendererHandle gsk_renderer_new_for_surface(GdkSurfaceHandle surface);
	[DllImport(Libraries.Gsk4)]
	internal static extern GdkSurfaceHandle gsk_renderer_get_surface(GskRendererHandle renderer);
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_renderer_is_realized(GskRendererHandle renderer);
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_renderer_realize(GskRendererHandle renderer, GdkSurfaceHandle surface, out GErrorHandle error);
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_renderer_realize_for_display(GskRendererHandle renderer, GdkDisplayHandle display, out GErrorHandle error);
	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_renderer_render(GskRendererHandle renderer, GskRenderNodeHandle root, cairo_region_tHandle region);
	[DllImport(Libraries.Gsk4)]
	internal static extern GdkTextureHandle gsk_renderer_render_texture(GskRendererHandle renderer, GskRenderNodeHandle root, graphene_rect_tHandle viewport);
	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_renderer_unrealize(GskRendererHandle renderer);
}
