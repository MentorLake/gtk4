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

namespace MentorLake.Gtk4.Gdk4;

public class GdkFocusEventHandle : GdkEventHandle
{
}

public static class GdkFocusEventHandleExtensions
{
	public static bool GetIn(this GdkFocusEventHandle @event)
	{
		return GdkFocusEventExterns.gdk_focus_event_get_in(@event);
	}

}

internal class GdkFocusEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_focus_event_get_in(GdkEventHandle @event);

}
