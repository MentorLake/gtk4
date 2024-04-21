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

public class GskMaskNodeHandle : GskRenderNodeHandle
{
	public static GskMaskNodeHandle New(GskRenderNodeHandle source, GskRenderNodeHandle mask, GskMaskMode mask_mode)
	{
		return GskMaskNodeExterns.gsk_mask_node_new(source, mask, mask_mode);
	}

}

public static class GskMaskNodeHandleExtensions
{
	public static GskRenderNodeHandle GetMask(this GskMaskNodeHandle node)
	{
		return GskMaskNodeExterns.gsk_mask_node_get_mask(node);
	}

	public static GskMaskMode GetMaskMode(this GskMaskNodeHandle node)
	{
		return GskMaskNodeExterns.gsk_mask_node_get_mask_mode(node);
	}

	public static GskRenderNodeHandle GetSource(this GskMaskNodeHandle node)
	{
		return GskMaskNodeExterns.gsk_mask_node_get_source(node);
	}

}

internal class GskMaskNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskMaskNodeHandle gsk_mask_node_new(GskRenderNodeHandle source, GskRenderNodeHandle mask, GskMaskMode mask_mode);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_mask_node_get_mask(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskMaskMode gsk_mask_node_get_mask_mode(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_mask_node_get_source(GskRenderNodeHandle node);

}
