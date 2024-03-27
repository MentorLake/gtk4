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

public class GskSubsurfaceNodeHandle : GskRenderNodeHandle
{
	public static GskSubsurfaceNodeHandle New(GskRenderNodeHandle child, IntPtr subsurface)
	{
		return GskSubsurfaceNodeExterns.gsk_subsurface_node_new(child, subsurface);
	}
}

public static class GskSubsurfaceNodeSignals
{
}

public static class GskSubsurfaceNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRenderNodeHandle node)
	{
		return GskSubsurfaceNodeExterns.gsk_subsurface_node_get_child(node);
	}

}

internal class GskSubsurfaceNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_subsurface_node_get_child(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskSubsurfaceNodeHandle gsk_subsurface_node_new(GskRenderNodeHandle child, IntPtr subsurface);
}
