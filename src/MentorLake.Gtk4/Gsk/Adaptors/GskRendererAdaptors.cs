using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskRendererAdaptors
{
	public static GdkSurfaceHandle GetSurface(this GskRendererHandle renderer)
	{
		return GskRendererExterns.gsk_renderer_get_surface(renderer);
	}

	public static int Realize(this GskRendererHandle renderer, GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GskRendererExterns.gsk_renderer_realize(renderer, surface, out error);
	}

	public static GskRendererHandle Unrealize(this GskRendererHandle renderer)
	{
		GskRendererExterns.gsk_renderer_unrealize(renderer);
		return renderer;
	}

	public static int IsRealized(this GskRendererHandle renderer)
	{
		return GskRendererExterns.gsk_renderer_is_realized(renderer);
	}

	public static GdkTextureHandle RenderTexture(this GskRendererHandle renderer, GskRenderNodeHandle root, graphene_rect_tHandle viewport)
	{
		return GskRendererExterns.gsk_renderer_render_texture(renderer, root, viewport);
	}

	public static GskRendererHandle Render(this GskRendererHandle renderer, GskRenderNodeHandle root, cairo_regionHandle region)
	{
		GskRendererExterns.gsk_renderer_render(renderer, root, region);
		return renderer;
	}

	public static GskRendererHandle GskCairoRendererNew()
	{
		return GskRendererExterns.gsk_cairo_renderer_new();
	}
}
