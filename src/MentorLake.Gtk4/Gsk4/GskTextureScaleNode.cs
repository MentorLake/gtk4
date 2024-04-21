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

public class GskTextureScaleNodeHandle : GskRenderNodeHandle
{
	public static GskTextureScaleNodeHandle New(GdkTextureHandle texture, graphene_rect_tHandle bounds, GskScalingFilter filter)
	{
		return GskTextureScaleNodeExterns.gsk_texture_scale_node_new(texture, bounds, filter);
	}

}

public static class GskTextureScaleNodeHandleExtensions
{
	public static GskScalingFilter GetFilter(this GskTextureScaleNodeHandle node)
	{
		return GskTextureScaleNodeExterns.gsk_texture_scale_node_get_filter(node);
	}

	public static GdkTextureHandle GetTexture(this GskTextureScaleNodeHandle node)
	{
		return GskTextureScaleNodeExterns.gsk_texture_scale_node_get_texture(node);
	}

}

internal class GskTextureScaleNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTextureScaleNodeHandle gsk_texture_scale_node_new(GdkTextureHandle texture, graphene_rect_tHandle bounds, GskScalingFilter filter);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskScalingFilter gsk_texture_scale_node_get_filter(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GdkTextureHandle gsk_texture_scale_node_get_texture(GskRenderNodeHandle node);

}
