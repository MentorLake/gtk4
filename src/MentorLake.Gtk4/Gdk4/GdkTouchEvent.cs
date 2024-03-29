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

public class GdkTouchEventHandle : GdkEventHandle
{
}

public static class GdkTouchEventHandleExtensions
{
	public static bool GetEmulatingPointer(this GdkTouchEventHandle @event)
	{
		return GdkTouchEventExterns.gdk_touch_event_get_emulating_pointer(@event);
	}

}

internal class GdkTouchEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_touch_event_get_emulating_pointer(GdkEventHandle @event);
}
