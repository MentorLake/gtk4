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

public class GskCairoNodeHandle : GskRenderNodeHandle
{
	public static GskCairoNodeHandle New(graphene_rect_tHandle bounds)
	{
		return GskCairoNodeExterns.gsk_cairo_node_new(bounds);
	}
}

public static class GskCairoNodeSignals
{
}

public static class GskCairoNodeHandleExtensions
{
	public static cairo_tHandle GetDrawContext(this GskRenderNodeHandle node)
	{
		return GskCairoNodeExterns.gsk_cairo_node_get_draw_context(node);
	}

	public static cairo_surface_tHandle GetSurface(this GskRenderNodeHandle node)
	{
		return GskCairoNodeExterns.gsk_cairo_node_get_surface(node);
	}

}

internal class GskCairoNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern cairo_tHandle gsk_cairo_node_get_draw_context(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern cairo_surface_tHandle gsk_cairo_node_get_surface(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskCairoNodeHandle gsk_cairo_node_new(graphene_rect_tHandle bounds);
}
