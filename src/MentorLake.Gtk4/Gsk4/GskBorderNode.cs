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

public class GskBorderNodeHandle : GskRenderNodeHandle
{
	public static GskBorderNodeHandle New(GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color)
	{
		return GskBorderNodeExterns.gsk_border_node_new(outline, border_width, border_color);
	}

}

public static class GskBorderNodeHandleExtensions
{
	public static GdkRGBA[] GetColors(this GskBorderNodeHandle node)
	{
		return GskBorderNodeExterns.gsk_border_node_get_colors(node);
	}

	public static GskRoundedRectHandle GetOutline(this GskBorderNodeHandle node)
	{
		return GskBorderNodeExterns.gsk_border_node_get_outline(node);
	}

	public static float[] GetWidths(this GskBorderNodeHandle node)
	{
		return GskBorderNodeExterns.gsk_border_node_get_widths(node);
	}

}

internal class GskBorderNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskBorderNodeHandle gsk_border_node_new(GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color);

	[DllImport(Libraries.Gsk4)]
	internal static extern GdkRGBA[] gsk_border_node_get_colors(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_border_node_get_outline(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float[] gsk_border_node_get_widths(GskRenderNodeHandle node);

}
