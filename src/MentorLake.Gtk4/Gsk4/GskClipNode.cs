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

public class GskClipNodeHandle : GskRenderNodeHandle
{
	public static GskClipNodeHandle New(GskRenderNodeHandle child, graphene_rect_tHandle clip)
	{
		return GskClipNodeExterns.gsk_clip_node_new(child, clip);
	}
}

public static class GskClipNodeSignals
{
}

public static class GskClipNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRenderNodeHandle node)
	{
		return GskClipNodeExterns.gsk_clip_node_get_child(node);
	}

	public static graphene_rect_tHandle GetClip(this GskRenderNodeHandle node)
	{
		return GskClipNodeExterns.gsk_clip_node_get_clip(node);
	}

}

internal class GskClipNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_clip_node_get_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_rect_tHandle gsk_clip_node_get_clip(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskClipNodeHandle gsk_clip_node_new(GskRenderNodeHandle child, graphene_rect_tHandle clip);
}
