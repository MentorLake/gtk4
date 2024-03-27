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

public class GdkPadEventHandle : GdkEventHandle
{
}

public static class GdkPadEventSignals
{
}

public static class GdkPadEventHandleExtensions
{
	public static GdkPadEventHandle GetAxisValue(this GdkPadEventHandle @handle, GdkEventHandle @event, out uint index, out double value)
	{
		GdkPadEventExterns.gdk_pad_event_get_axis_value(@event, out index, out value);
		return @handle;
	}

	public static uint GetButton(this GdkEventHandle @event)
	{
		return GdkPadEventExterns.gdk_pad_event_get_button(@event);
	}

	public static GdkPadEventHandle GetGroupMode(this GdkPadEventHandle @handle, GdkEventHandle @event, out uint group, out uint mode)
	{
		GdkPadEventExterns.gdk_pad_event_get_group_mode(@event, out group, out mode);
		return @handle;
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