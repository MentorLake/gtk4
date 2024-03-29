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

public class GskRenderNodeHandle : GTypeInstanceHandle
{
	public static GskRenderNodeHandle Deserialize(GBytesHandle bytes, GskParseErrorFunc error_func, IntPtr user_data)
	{
		return GskRenderNodeExterns.gsk_render_node_deserialize(bytes, error_func, user_data);
	}

}

public static class GskRenderNodeHandleExtensions
{
	public static GskRenderNodeHandle Draw(this GskRenderNodeHandle node, cairo_tHandle cr)
	{
		GskRenderNodeExterns.gsk_render_node_draw(node, cr);
		return node;
	}

	public static GskRenderNodeHandle GetBounds(this GskRenderNodeHandle node, out graphene_rect_t bounds)
	{
		GskRenderNodeExterns.gsk_render_node_get_bounds(node, out bounds);
		return node;
	}

	public static GskRenderNodeType GetNodeType(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_render_node_get_node_type(node);
	}

	public static GskRenderNodeHandle Ref(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_render_node_ref(node);
	}

	public static GBytesHandle Serialize(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_render_node_serialize(node);
	}

	public static GskRenderNodeHandle Unref(this GskRenderNodeHandle node)
	{
		GskRenderNodeExterns.gsk_render_node_unref(node);
		return node;
	}

	public static bool WriteToFile(this GskRenderNodeHandle node, string filename, out GErrorHandle error)
	{
		return GskRenderNodeExterns.gsk_render_node_write_to_file(node, filename, out error);
	}

}

internal class GskRenderNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_render_node_draw(GskRenderNodeHandle node, cairo_tHandle cr);
	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_render_node_get_bounds(GskRenderNodeHandle node, out graphene_rect_t bounds);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeType gsk_render_node_get_node_type(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_render_node_ref(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_render_node_serialize(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_render_node_unref(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_render_node_write_to_file(GskRenderNodeHandle node, string filename, out GErrorHandle error);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_render_node_deserialize(GBytesHandle bytes, GskParseErrorFunc error_func, IntPtr user_data);
}
