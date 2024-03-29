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

public class GdkTouchpadEventHandle : GdkEventHandle
{
}

public static class GdkTouchpadEventHandleExtensions
{
	public static GdkTouchpadEventHandle GetDeltas(this GdkTouchpadEventHandle @event, out double dx, out double dy)
	{
		GdkTouchpadEventExterns.gdk_touchpad_event_get_deltas(@event, out dx, out dy);
		return @event;
	}

	public static GdkTouchpadGesturePhase GetGesturePhase(this GdkTouchpadEventHandle @event)
	{
		return GdkTouchpadEventExterns.gdk_touchpad_event_get_gesture_phase(@event);
	}

	public static uint GetNFingers(this GdkTouchpadEventHandle @event)
	{
		return GdkTouchpadEventExterns.gdk_touchpad_event_get_n_fingers(@event);
	}

	public static double GetPinchAngleDelta(this GdkTouchpadEventHandle @event)
	{
		return GdkTouchpadEventExterns.gdk_touchpad_event_get_pinch_angle_delta(@event);
	}

	public static double GetPinchScale(this GdkTouchpadEventHandle @event)
	{
		return GdkTouchpadEventExterns.gdk_touchpad_event_get_pinch_scale(@event);
	}

}

internal class GdkTouchpadEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_touchpad_event_get_deltas(GdkEventHandle @event, out double dx, out double dy);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTouchpadGesturePhase gdk_touchpad_event_get_gesture_phase(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_touchpad_event_get_n_fingers(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_touchpad_event_get_pinch_angle_delta(GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_touchpad_event_get_pinch_scale(GdkEventHandle @event);
}
