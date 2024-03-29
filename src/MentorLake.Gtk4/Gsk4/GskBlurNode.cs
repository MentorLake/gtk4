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

public class GskBlurNodeHandle : GskRenderNodeHandle
{
	public static GskBlurNodeHandle New(GskRenderNodeHandle child, float radius)
	{
		return GskBlurNodeExterns.gsk_blur_node_new(child, radius);
	}

}

public static class GskBlurNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskBlurNodeHandle node)
	{
		return GskBlurNodeExterns.gsk_blur_node_get_child(node);
	}

	public static float GetRadius(this GskBlurNodeHandle node)
	{
		return GskBlurNodeExterns.gsk_blur_node_get_radius(node);
	}

}

internal class GskBlurNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskBlurNodeHandle gsk_blur_node_new(GskRenderNodeHandle child, float radius);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_blur_node_get_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_blur_node_get_radius(GskRenderNodeHandle node);
}
