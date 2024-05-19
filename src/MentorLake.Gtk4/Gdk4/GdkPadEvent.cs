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

public class GdkPadEventHandle : GdkEventHandle
{
}

public static class GdkPadEventHandleExtensions
{
	public static GdkPadEventHandle GetAxisValue(this GdkPadEventHandle @event, out uint index, out double value)
	{
		GdkPadEventExterns.gdk_pad_event_get_axis_value(@event, out index, out value);
		return @event;
	}

	public static uint GetButton(this GdkPadEventHandle @event)
	{
		return GdkPadEventExterns.gdk_pad_event_get_button(@event);
	}

	public static GdkPadEventHandle GetGroupMode(this GdkPadEventHandle @event, out uint group, out uint mode)
	{
		GdkPadEventExterns.gdk_pad_event_get_group_mode(@event, out group, out mode);
		return @event;
	}

}

internal class GdkPadEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_pad_event_get_axis_value(GdkEventHandle @event, out uint index, out double value);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_pad_event_get_button(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_pad_event_get_group_mode(GdkEventHandle @event, out uint group, out uint mode);

}
