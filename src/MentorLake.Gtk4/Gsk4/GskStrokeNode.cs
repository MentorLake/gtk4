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

public class GskStrokeNodeHandle : GskRenderNodeHandle
{
	public static GskStrokeNodeHandle New(GskRenderNodeHandle child, GskPathHandle path, GskStrokeHandle stroke)
	{
		return GskStrokeNodeExterns.gsk_stroke_node_new(child, path, stroke);
	}

}

public static class GskStrokeNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskStrokeNodeHandle node)
	{
		return GskStrokeNodeExterns.gsk_stroke_node_get_child(node);
	}

	public static GskPathHandle GetPath(this GskStrokeNodeHandle node)
	{
		return GskStrokeNodeExterns.gsk_stroke_node_get_path(node);
	}

	public static GskStrokeHandle GetStroke(this GskStrokeNodeHandle node)
	{
		return GskStrokeNodeExterns.gsk_stroke_node_get_stroke(node);
	}

}

internal class GskStrokeNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskStrokeNodeHandle gsk_stroke_node_new(GskRenderNodeHandle child, GskPathHandle path, GskStrokeHandle stroke);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_stroke_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathHandle gsk_stroke_node_get_path(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskStrokeHandle gsk_stroke_node_get_stroke(GskRenderNodeHandle node);

}
