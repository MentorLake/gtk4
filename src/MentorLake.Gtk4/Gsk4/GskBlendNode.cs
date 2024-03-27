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

public class GskBlendNodeHandle : GskRenderNodeHandle
{
	public static GskBlendNodeHandle New(GskRenderNodeHandle bottom, GskRenderNodeHandle top, GskBlendMode blend_mode)
	{
		return GskBlendNodeExterns.gsk_blend_node_new(bottom, top, blend_mode);
	}
}

public static class GskBlendNodeSignals
{
}

public static class GskBlendNodeHandleExtensions
{
	public static GskBlendMode GetBlendMode(this GskRenderNodeHandle node)
	{
		return GskBlendNodeExterns.gsk_blend_node_get_blend_mode(node);
	}

	public static GskRenderNodeHandle GetBottomChild(this GskRenderNodeHandle node)
	{
		return GskBlendNodeExterns.gsk_blend_node_get_bottom_child(node);
	}

	public static GskRenderNodeHandle GetTopChild(this GskRenderNodeHandle node)
	{
		return GskBlendNodeExterns.gsk_blend_node_get_top_child(node);
	}

}

internal class GskBlendNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskBlendMode gsk_blend_node_get_blend_mode(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_blend_node_get_bottom_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_blend_node_get_top_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskBlendNodeHandle gsk_blend_node_new(GskRenderNodeHandle bottom, GskRenderNodeHandle top, GskBlendMode blend_mode);
}
