using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskRendererExterns
{
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_renderer_get_surface")]
    internal static extern GdkSurfaceHandle gsk_renderer_get_surface(this GskRendererHandle renderer);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_renderer_realize")]
    internal static extern int gsk_renderer_realize(this GskRendererHandle renderer, GdkSurfaceHandle surface, out GErrorHandle error);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_renderer_unrealize")]
    internal static extern void gsk_renderer_unrealize(this GskRendererHandle renderer);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_renderer_is_realized")]
    internal static extern int gsk_renderer_is_realized(this GskRendererHandle renderer);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_renderer_render_texture")]
    internal static extern GdkTextureHandle gsk_renderer_render_texture(this GskRendererHandle renderer, GskRenderNodeHandle root, graphene_rect_tHandle viewport);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_renderer_render")]
    internal static extern void gsk_renderer_render(this GskRendererHandle renderer, GskRenderNodeHandle root, cairo_regionHandle region);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRendererHandle gsk_renderer_new_for_surface(GdkSurfaceHandle surface);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRendererHandle gsk_cairo_renderer_new();
}
