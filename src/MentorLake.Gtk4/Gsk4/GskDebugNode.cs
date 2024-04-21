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

public class GskDebugNodeHandle : GskRenderNodeHandle
{
	public static GskDebugNodeHandle New(GskRenderNodeHandle child, string message)
	{
		return GskDebugNodeExterns.gsk_debug_node_new(child, message);
	}

}

public static class GskDebugNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskDebugNodeHandle node)
	{
		return GskDebugNodeExterns.gsk_debug_node_get_child(node);
	}

	public static string GetMessage(this GskDebugNodeHandle node)
	{
		return GskDebugNodeExterns.gsk_debug_node_get_message(node);
	}

}

internal class GskDebugNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskDebugNodeHandle gsk_debug_node_new(GskRenderNodeHandle child, string message);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_debug_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gsk_debug_node_get_message(GskRenderNodeHandle node);

}
