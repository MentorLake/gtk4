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

namespace MentorLake.Gtk4.Gdk4;

public class GdkScrollEventHandle : GdkEventHandle
{
}

public static class GdkScrollEventHandleExtensions
{
	public static GdkScrollEventHandle GetDeltas(this GdkScrollEventHandle @event, out double delta_x, out double delta_y)
	{
		GdkScrollEventExterns.gdk_scroll_event_get_deltas(@event, out delta_x, out delta_y);
		return @event;
	}

	public static GdkScrollDirection GetDirection(this GdkScrollEventHandle @event)
	{
		return GdkScrollEventExterns.gdk_scroll_event_get_direction(@event);
	}

	public static GdkScrollUnit GetUnit(this GdkScrollEventHandle @event)
	{
		return GdkScrollEventExterns.gdk_scroll_event_get_unit(@event);
	}

	public static bool IsStop(this GdkScrollEventHandle @event)
	{
		return GdkScrollEventExterns.gdk_scroll_event_is_stop(@event);
	}

}

internal class GdkScrollEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_scroll_event_get_deltas(GdkEventHandle @event, out double delta_x, out double delta_y);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkScrollDirection gdk_scroll_event_get_direction(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkScrollUnit gdk_scroll_event_get_unit(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_scroll_event_is_stop(GdkEventHandle @event);
}
