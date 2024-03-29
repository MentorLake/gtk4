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

public class GskLinearGradientNodeHandle : GskRenderNodeHandle
{
	public static GskLinearGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStop[] color_stops, int n_color_stops)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_new(bounds, start, end, color_stops, n_color_stops);
	}

}

public static class GskLinearGradientNodeHandleExtensions
{
	public static GskColorStop[] GetColorStops(this GskLinearGradientNodeHandle node, out int n_stops)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_color_stops(node, out n_stops);
	}

	public static graphene_point_tHandle GetEnd(this GskLinearGradientNodeHandle node)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_end(node);
	}

	public static int GetNColorStops(this GskLinearGradientNodeHandle node)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_n_color_stops(node);
	}

	public static graphene_point_tHandle GetStart(this GskLinearGradientNodeHandle node)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_start(node);
	}

}

internal class GskLinearGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskLinearGradientNodeHandle gsk_linear_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStop[] color_stops, int n_color_stops);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskColorStop[] gsk_linear_gradient_node_get_color_stops(GskRenderNodeHandle node, out int n_stops);
	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_linear_gradient_node_get_end(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_linear_gradient_node_get_n_color_stops(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_linear_gradient_node_get_start(GskRenderNodeHandle node);
}
