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

public class GdkDNDEventHandle : GdkEventHandle
{
}

public static class GdkDNDEventHandleExtensions
{
	public static GdkDropHandle GdkDndEventGetDrop(this GdkDNDEventHandle @event)
	{
		return GdkDNDEventExterns.gdk_dnd_event_get_drop(@event);
	}

}

internal class GdkDNDEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDropHandle gdk_dnd_event_get_drop(GdkEventHandle @event);

}
