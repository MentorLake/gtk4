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

public class GskConicGradientNodeHandle : GskRenderNodeHandle
{
	public static GskConicGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStop[] color_stops, int n_color_stops)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_new(bounds, center, rotation, color_stops, n_color_stops);
	}
}

public static class GskConicGradientNodeSignals
{
}

public static class GskConicGradientNodeHandleExtensions
{
	public static float GetAngle(this GskRenderNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_angle(node);
	}

	public static graphene_point_tHandle GetCenter(this GskRenderNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_center(node);
	}

	public static GskColorStop[] GetColorStops(this GskRenderNodeHandle node, out int n_stops)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_color_stops(node, out n_stops);
	}

	public static int GetNColorStops(this GskRenderNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_n_color_stops(node);
	}

	public static float GetRotation(this GskRenderNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_rotation(node);
	}

}

internal class GskConicGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_conic_gradient_node_get_angle(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_conic_gradient_node_get_center(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskColorStop[] gsk_conic_gradient_node_get_color_stops(GskRenderNodeHandle node, out int n_stops);
	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_conic_gradient_node_get_n_color_stops(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_conic_gradient_node_get_rotation(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskConicGradientNodeHandle gsk_conic_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStop[] color_stops, int n_color_stops);
}
