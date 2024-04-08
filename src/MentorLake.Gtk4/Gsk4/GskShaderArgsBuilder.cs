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

public class GskShaderArgsBuilderHandle : BaseSafeHandle
{
	public static GskShaderArgsBuilderHandle New(GskGLShaderHandle shader, GBytesHandle initial_values)
	{
		return GskShaderArgsBuilderExterns.gsk_shader_args_builder_new(shader, initial_values);
	}

}

internal class GskShaderArgsBuilderExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskShaderArgsBuilderHandle gsk_shader_args_builder_new(GskGLShaderHandle shader, GBytesHandle initial_values);
}

public struct GskShaderArgsBuilder
{
}
