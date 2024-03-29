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

public class GskRoundedClipNodeHandle : GskRenderNodeHandle
{
	public static GskRoundedClipNodeHandle New(GskRenderNodeHandle child, GskRoundedRectHandle clip)
	{
		return GskRoundedClipNodeExterns.gsk_rounded_clip_node_new(child, clip);
	}

}

public static class GskRoundedClipNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRoundedClipNodeHandle node)
	{
		return GskRoundedClipNodeExterns.gsk_rounded_clip_node_get_child(node);
	}

	public static GskRoundedRectHandle GetClip(this GskRoundedClipNodeHandle node)
	{
		return GskRoundedClipNodeExterns.gsk_rounded_clip_node_get_clip(node);
	}

}

internal class GskRoundedClipNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedClipNodeHandle gsk_rounded_clip_node_new(GskRenderNodeHandle child, GskRoundedRectHandle clip);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_rounded_clip_node_get_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_clip_node_get_clip(GskRenderNodeHandle node);
}
