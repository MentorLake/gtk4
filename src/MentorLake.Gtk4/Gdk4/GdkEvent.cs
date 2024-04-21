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

public class GdkEventHandle : GTypeInstanceHandle
{
}

public static class GdkEventHandleExtensions
{
	public static bool sGetAngle(this GdkEventHandle event1, GdkEventHandle event2, out double angle)
	{
		return GdkEventExterns.gdk_events_get_angle(event1, event2, out angle);
	}

	public static bool sGetCenter(this GdkEventHandle event1, GdkEventHandle event2, out double x, out double y)
	{
		return GdkEventExterns.gdk_events_get_center(event1, event2, out x, out y);
	}

	public static bool sGetDistance(this GdkEventHandle event1, GdkEventHandle event2, out double distance)
	{
		return GdkEventExterns.gdk_events_get_distance(event1, event2, out distance);
	}

	public static bool GetAxes(this GdkEventHandle @event, out double[] axes, out uint n_axes)
	{
		return GdkEventExterns.gdk_event_get_axes(@event, out axes, out n_axes);
	}

	public static bool GetAxis(this GdkEventHandle @event, GdkAxisUse axis_use, out double value)
	{
		return GdkEventExterns.gdk_event_get_axis(@event, axis_use, out value);
	}

	public static GdkDeviceHandle GetDevice(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_device(@event);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_device_tool(@event);
	}

	public static GdkDisplayHandle GetDisplay(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_display(@event);
	}

	public static GdkEventSequenceHandle GetEventSequence(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_event_sequence(@event);
	}

	public static GdkEventType GetEventType(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_event_type(@event);
	}

	public static GdkTimeCoord[] GetHistory(this GdkEventHandle @event, out uint out_n_coords)
	{
		return GdkEventExterns.gdk_event_get_history(@event, out out_n_coords);
	}

	public static GdkModifierType GetModifierState(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_modifier_state(@event);
	}

	public static bool GetPointerEmulated(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_pointer_emulated(@event);
	}

	public static bool GetPosition(this GdkEventHandle @event, out double x, out double y)
	{
		return GdkEventExterns.gdk_event_get_position(@event, out x, out y);
	}

	public static GdkSeatHandle GetSeat(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_seat(@event);
	}

	public static GdkSurfaceHandle GetSurface(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_surface(@event);
	}

	public static uint GetTime(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_time(@event);
	}

	public static GdkEventHandle Ref(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_ref(@event);
	}

	public static bool TriggersContextMenu(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_triggers_context_menu(@event);
	}

	public static GdkEventHandle Unref(this GdkEventHandle @event)
	{
		GdkEventExterns.gdk_event_unref(@event);
		return @event;
	}

}

internal class GdkEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_events_get_angle(GdkEventHandle event1, GdkEventHandle event2, out double angle);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_events_get_center(GdkEventHandle event1, GdkEventHandle event2, out double x, out double y);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_events_get_distance(GdkEventHandle event1, GdkEventHandle event2, out double distance);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_event_get_axes(GdkEventHandle @event, out double[] axes, out uint n_axes);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_event_get_axis(GdkEventHandle @event, GdkAxisUse axis_use, out double value);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_event_get_device(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceToolHandle gdk_event_get_device_tool(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_event_get_display(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkEventSequenceHandle gdk_event_get_event_sequence(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkEventType gdk_event_get_event_type(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTimeCoord[] gdk_event_get_history(GdkEventHandle @event, out uint out_n_coords);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkModifierType gdk_event_get_modifier_state(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_event_get_pointer_emulated(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_event_get_position(GdkEventHandle @event, out double x, out double y);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSeatHandle gdk_event_get_seat(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_event_get_surface(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_event_get_time(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkEventHandle gdk_event_ref(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_event_triggers_context_menu(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_event_unref(GdkEventHandle @event);

}
