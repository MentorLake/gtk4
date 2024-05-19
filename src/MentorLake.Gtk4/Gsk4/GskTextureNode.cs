using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gsk4;

public class GskTextureNodeHandle : GskRenderNodeHandle
{
	public static GskTextureNodeHandle New(GdkTextureHandle texture, graphene_rect_tHandle bounds)
	{
		return GskTextureNodeExterns.gsk_texture_node_new(texture, bounds);
	}

}

public static class GskTextureNodeHandleExtensions
{
	public static GdkTextureHandle GetTexture(this GskTextureNodeHandle node)
	{
		return GskTextureNodeExterns.gsk_texture_node_get_texture(node);
	}

}

internal class GskTextureNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTextureNodeHandle gsk_texture_node_new(GdkTextureHandle texture, graphene_rect_tHandle bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern GdkTextureHandle gsk_texture_node_get_texture(GskRenderNodeHandle node);

}
