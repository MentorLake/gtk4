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

public class GskColorNodeHandle : GskRenderNodeHandle
{
	public static GskColorNodeHandle New(GdkRGBAHandle rgba, graphene_rect_tHandle bounds)
	{
		return GskColorNodeExterns.gsk_color_node_new(rgba, bounds);
	}
}

public static class GskColorNodeSignals
{
}

public static class GskColorNodeHandleExtensions
{
	public static GdkRGBAHandle GetColor(this GskRenderNodeHandle node)
	{
		return GskColorNodeExterns.gsk_color_node_get_color(node);
	}

}

internal class GskColorNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GdkRGBAHandle gsk_color_node_get_color(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskColorNodeHandle gsk_color_node_new(GdkRGBAHandle rgba, graphene_rect_tHandle bounds);
}
