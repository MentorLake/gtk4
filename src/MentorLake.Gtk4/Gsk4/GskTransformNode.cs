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

public class GskTransformNodeHandle : GskRenderNodeHandle
{
	public static GskTransformNodeHandle New(GskRenderNodeHandle child, GskTransformHandle transform)
	{
		return GskTransformNodeExterns.gsk_transform_node_new(child, transform);
	}
}

public static class GskTransformNodeSignals
{
}

public static class GskTransformNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRenderNodeHandle node)
	{
		return GskTransformNodeExterns.gsk_transform_node_get_child(node);
	}

	public static GskTransformHandle GetTransform(this GskRenderNodeHandle node)
	{
		return GskTransformNodeExterns.gsk_transform_node_get_transform(node);
	}

}

internal class GskTransformNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_transform_node_get_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTransformHandle gsk_transform_node_get_transform(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTransformNodeHandle gsk_transform_node_new(GskRenderNodeHandle child, GskTransformHandle transform);
}
