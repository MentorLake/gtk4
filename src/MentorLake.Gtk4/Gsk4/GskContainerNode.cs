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

public class GskContainerNodeHandle : GskRenderNodeHandle
{
	public static GskContainerNodeHandle New(GskRenderNodeHandle[] children, uint n_children)
	{
		return GskContainerNodeExterns.gsk_container_node_new(children, n_children);
	}
}

public static class GskContainerNodeSignals
{
}

public static class GskContainerNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRenderNodeHandle node, uint idx)
	{
		return GskContainerNodeExterns.gsk_container_node_get_child(node, idx);
	}

	public static uint GetNChildren(this GskRenderNodeHandle node)
	{
		return GskContainerNodeExterns.gsk_container_node_get_n_children(node);
	}

}

internal class GskContainerNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_container_node_get_child(GskRenderNodeHandle node, uint idx);
	[DllImport(Libraries.Gsk4)]
	internal static extern uint gsk_container_node_get_n_children(GskRenderNodeHandle node);
	[DllImport(Libraries.Gsk4)]
	internal static extern GskContainerNodeHandle gsk_container_node_new(GskRenderNodeHandle[] children, uint n_children);
}
