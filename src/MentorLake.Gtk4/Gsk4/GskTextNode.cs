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

public class GskTextNodeHandle : GskRenderNodeHandle
{
	public static GskTextNodeHandle New(PangoFontHandle font, PangoGlyphStringHandle glyphs, GdkRGBAHandle color, graphene_point_tHandle offset)
	{
		return GskTextNodeExterns.gsk_text_node_new(font, glyphs, color, offset);
	}

}

public static class GskTextNodeHandleExtensions
{
	public static GdkRGBAHandle GetColor(this GskTextNodeHandle node)
	{
		return GskTextNodeExterns.gsk_text_node_get_color(node);
	}

	public static PangoFontHandle GetFont(this GskTextNodeHandle node)
	{
		return GskTextNodeExterns.gsk_text_node_get_font(node);
	}

	public static PangoGlyphInfo[] GetGlyphs(this GskTextNodeHandle node, out uint n_glyphs)
	{
		return GskTextNodeExterns.gsk_text_node_get_glyphs(node, out n_glyphs);
	}

	public static uint GetNumGlyphs(this GskTextNodeHandle node)
	{
		return GskTextNodeExterns.gsk_text_node_get_num_glyphs(node);
	}

	public static graphene_point_tHandle GetOffset(this GskTextNodeHandle node)
	{
		return GskTextNodeExterns.gsk_text_node_get_offset(node);
	}

	public static bool HasColorGlyphs(this GskTextNodeHandle node)
	{
		return GskTextNodeExterns.gsk_text_node_has_color_glyphs(node);
	}

}

internal class GskTextNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTextNodeHandle gsk_text_node_new(PangoFontHandle font, PangoGlyphStringHandle glyphs, GdkRGBAHandle color, graphene_point_tHandle offset);
	[DllImport(Libraries.Gsk4)]
	internal static extern GdkRGBAHandle gsk_text_node_get_color(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern PangoFontHandle gsk_text_node_get_font(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern PangoGlyphInfo[] gsk_text_node_get_glyphs(GskRenderNodeHandle node, out uint n_glyphs);
	[DllImport(Libraries.Gsk4)]
	internal static extern uint gsk_text_node_get_num_glyphs(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_text_node_get_offset(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_text_node_has_color_glyphs(GskRenderNodeHandle node);
}
