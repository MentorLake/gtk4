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

public class GdkCrossingEventHandle : GdkEventHandle
{
}

public static class GdkCrossingEventSignals
{
}

public static class GdkCrossingEventHandleExtensions
{
	public static GdkNotifyType GetDetail(this GdkEventHandle @event)
	{
		return GdkCrossingEventExterns.gdk_crossing_event_get_detail(@event);
	}

	public static bool GetFocus(this GdkEventHandle @event)
	{
		return GdkCrossingEventExterns.gdk_crossing_event_get_focus(@event);
	}

	public static GdkCrossingMode GetMode(this GdkEventHandle @event)
	{
		return GdkCrossingEventExterns.gdk_crossing_event_get_mode(@event);
	}

}

internal class GdkCrossingEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkNotifyType gdk_crossing_event_get_detail(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_crossing_event_get_focus(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCrossingMode gdk_crossing_event_get_mode(GdkEventHandle @event);
}
