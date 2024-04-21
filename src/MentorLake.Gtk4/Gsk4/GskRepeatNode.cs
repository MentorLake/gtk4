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

public class GskRepeatNodeHandle : GskRenderNodeHandle
{
	public static GskRepeatNodeHandle New(graphene_rect_tHandle bounds, GskRenderNodeHandle child, graphene_rect_tHandle child_bounds)
	{
		return GskRepeatNodeExterns.gsk_repeat_node_new(bounds, child, child_bounds);
	}

}

public static class GskRepeatNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRepeatNodeHandle node)
	{
		return GskRepeatNodeExterns.gsk_repeat_node_get_child(node);
	}

	public static graphene_rect_tHandle GetChildBounds(this GskRepeatNodeHandle node)
	{
		return GskRepeatNodeExterns.gsk_repeat_node_get_child_bounds(node);
	}

}

internal class GskRepeatNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRepeatNodeHandle gsk_repeat_node_new(graphene_rect_tHandle bounds, GskRenderNodeHandle child, graphene_rect_tHandle child_bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_repeat_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_rect_tHandle gsk_repeat_node_get_child_bounds(GskRenderNodeHandle node);

}
