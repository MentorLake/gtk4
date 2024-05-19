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

public class GskCrossFadeNodeHandle : GskRenderNodeHandle
{
	public static GskCrossFadeNodeHandle New(GskRenderNodeHandle start, GskRenderNodeHandle end, float progress)
	{
		return GskCrossFadeNodeExterns.gsk_cross_fade_node_new(start, end, progress);
	}

}

public static class GskCrossFadeNodeHandleExtensions
{
	public static GskRenderNodeHandle GetEndChild(this GskCrossFadeNodeHandle node)
	{
		return GskCrossFadeNodeExterns.gsk_cross_fade_node_get_end_child(node);
	}

	public static float GetProgress(this GskCrossFadeNodeHandle node)
	{
		return GskCrossFadeNodeExterns.gsk_cross_fade_node_get_progress(node);
	}

	public static GskRenderNodeHandle GetStartChild(this GskCrossFadeNodeHandle node)
	{
		return GskCrossFadeNodeExterns.gsk_cross_fade_node_get_start_child(node);
	}

}

internal class GskCrossFadeNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskCrossFadeNodeHandle gsk_cross_fade_node_new(GskRenderNodeHandle start, GskRenderNodeHandle end, float progress);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_cross_fade_node_get_end_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_cross_fade_node_get_progress(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_cross_fade_node_get_start_child(GskRenderNodeHandle node);

}
