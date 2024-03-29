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

public class GdkGrabBrokenEventHandle : GdkEventHandle
{
}

public static class GdkGrabBrokenEventHandleExtensions
{
	public static GdkSurfaceHandle GetGrabSurface(this GdkGrabBrokenEventHandle @event)
	{
		return GdkGrabBrokenEventExterns.gdk_grab_broken_event_get_grab_surface(@event);
	}

	public static bool GetImplicit(this GdkGrabBrokenEventHandle @event)
	{
		return GdkGrabBrokenEventExterns.gdk_grab_broken_event_get_implicit(@event);
	}

}

internal class GdkGrabBrokenEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_grab_broken_event_get_grab_surface(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_grab_broken_event_get_implicit(GdkEventHandle @event);
}
