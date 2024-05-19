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

public class GskGLShaderNodeHandle : GskRenderNodeHandle
{
	public static GskGLShaderNodeHandle GskGlShaderNodeNew(GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle args, GskRenderNodeHandle[] children, uint n_children)
	{
		return GskGLShaderNodeExterns.gsk_gl_shader_node_new(shader, bounds, args, children, n_children);
	}

}

public static class GskGLShaderNodeHandleExtensions
{
	public static GBytesHandle GskGlShaderNodeGetArgs(this GskGLShaderNodeHandle node)
	{
		return GskGLShaderNodeExterns.gsk_gl_shader_node_get_args(node);
	}

	public static GskRenderNodeHandle GskGlShaderNodeGetChild(this GskGLShaderNodeHandle node, uint idx)
	{
		return GskGLShaderNodeExterns.gsk_gl_shader_node_get_child(node, idx);
	}

	public static uint GskGlShaderNodeGetNChildren(this GskGLShaderNodeHandle node)
	{
		return GskGLShaderNodeExterns.gsk_gl_shader_node_get_n_children(node);
	}

	public static GskGLShaderHandle GskGlShaderNodeGetShader(this GskGLShaderNodeHandle node)
	{
		return GskGLShaderNodeExterns.gsk_gl_shader_node_get_shader(node);
	}

}

internal class GskGLShaderNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskGLShaderNodeHandle gsk_gl_shader_node_new(GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle args, GskRenderNodeHandle[] children, uint n_children);

	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_gl_shader_node_get_args(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_gl_shader_node_get_child(GskRenderNodeHandle node, uint idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern uint gsk_gl_shader_node_get_n_children(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskGLShaderHandle gsk_gl_shader_node_get_shader(GskRenderNodeHandle node);

}
