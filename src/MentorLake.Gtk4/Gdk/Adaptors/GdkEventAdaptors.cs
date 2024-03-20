using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkEventAdaptors
{
    public static GdkEventHandle Ref(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_ref(@event);
    }

    public static GdkEventHandle Unref(this GdkEventHandle @event)
    {
        GdkEventExterns.gdk_event_unref(@event);
        return @event;
    }

    public static GdkEventType GetEventType(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_event_type(@event);
    }

    public static GdkSurfaceHandle GetSurface(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_surface(@event);
    }

    public static GdkSeatHandle GetSeat(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_seat(@event);
    }

    public static GdkDeviceHandle GetDevice(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_device(@event);
    }

    public static GdkDeviceToolHandle GetDeviceTool(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_device_tool(@event);
    }

    public static uint GetTime(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_time(@event);
    }

    public static GdkDisplayHandle GetDisplay(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_display(@event);
    }

    public static GdkEventSequenceHandle GetEventSequence(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_event_sequence(@event);
    }

    public static GdkModifierType GetModifierState(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_modifier_state(@event);
    }

    public static int GetPosition(this GdkEventHandle @event, out double x, out double y)
    {
        return GdkEventExterns.gdk_event_get_position(@event, out x, out y);
    }

    public static int GetAxes(this GdkEventHandle @event, out double[] axes, out uint n_axes)
    {
        return GdkEventExterns.gdk_event_get_axes(@event, out axes, out n_axes);
    }

    public static int GetAxis(this GdkEventHandle @event, GdkAxisUse axis_use, out double value)
    {
        return GdkEventExterns.gdk_event_get_axis(@event, axis_use, out value);
    }

    public static GdkTimeCoordHandle GetHistory(this GdkEventHandle @event, out uint out_n_coords)
    {
        return GdkEventExterns.gdk_event_get_history(@event, out out_n_coords);
    }

    public static int GetPointerEmulated(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_get_pointer_emulated(@event);
    }

    public static uint GdkButtonEventGetButton(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_button_event_get_button(@event);
    }

    public static GdkScrollDirection GdkScrollEventGetDirection(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_scroll_event_get_direction(@event);
    }

    public static GdkEventHandle GdkScrollEventGetDeltas(this GdkEventHandle @event, out double delta_x, out double delta_y)
    {
        GdkEventExterns.gdk_scroll_event_get_deltas(@event, out delta_x, out delta_y);
        return @event;
    }

    public static int GdkScrollEventIsStop(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_scroll_event_is_stop(@event);
    }

    public static uint GdkKeyEventGetKeyval(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_key_event_get_keyval(@event);
    }

    public static uint GdkKeyEventGetKeycode(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_key_event_get_keycode(@event);
    }

    public static GdkModifierType GdkKeyEventGetConsumedModifiers(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_key_event_get_consumed_modifiers(@event);
    }

    public static uint GdkKeyEventGetLayout(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_key_event_get_layout(@event);
    }

    public static uint GdkKeyEventGetLevel(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_key_event_get_level(@event);
    }

    public static int GdkKeyEventIsModifier(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_key_event_is_modifier(@event);
    }

    public static int GdkFocusEventGetIn(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_focus_event_get_in(@event);
    }

    public static int GdkTouchEventGetEmulatingPointer(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_touch_event_get_emulating_pointer(@event);
    }

    public static GdkCrossingMode GdkCrossingEventGetMode(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_crossing_event_get_mode(@event);
    }

    public static GdkNotifyType GdkCrossingEventGetDetail(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_crossing_event_get_detail(@event);
    }

    public static int GdkCrossingEventGetFocus(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_crossing_event_get_focus(@event);
    }

    public static GdkTouchpadGesturePhase GdkTouchpadEventGetGesturePhase(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_touchpad_event_get_gesture_phase(@event);
    }

    public static uint GdkTouchpadEventGetNFingers(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_touchpad_event_get_n_fingers(@event);
    }

    public static GdkEventHandle GdkTouchpadEventGetDeltas(this GdkEventHandle @event, out double dx, out double dy)
    {
        GdkEventExterns.gdk_touchpad_event_get_deltas(@event, out dx, out dy);
        return @event;
    }

    public static double GdkTouchpadEventGetPinchAngleDelta(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_touchpad_event_get_pinch_angle_delta(@event);
    }

    public static double GdkTouchpadEventGetPinchScale(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_touchpad_event_get_pinch_scale(@event);
    }

    public static uint GdkPadEventGetButton(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_pad_event_get_button(@event);
    }

    public static GdkEventHandle GdkPadEventGetAxisValue(this GdkEventHandle @event, out uint index, out double value)
    {
        GdkEventExterns.gdk_pad_event_get_axis_value(@event, out index, out value);
        return @event;
    }

    public static GdkEventHandle GdkPadEventGetGroupMode(this GdkEventHandle @event, out uint group, out uint mode)
    {
        GdkEventExterns.gdk_pad_event_get_group_mode(@event, out group, out mode);
        return @event;
    }

    public static GdkDropHandle GdkDndEventGetDrop(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_dnd_event_get_drop(@event);
    }

    public static GdkSurfaceHandle GdkGrabBrokenEventGetGrabSurface(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_grab_broken_event_get_grab_surface(@event);
    }

    public static int GdkGrabBrokenEventGetImplicit(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_grab_broken_event_get_implicit(@event);
    }

    public static int TriggersContextMenu(this GdkEventHandle @event)
    {
        return GdkEventExterns.gdk_event_triggers_context_menu(@event);
    }

    public static int sGetDistance(this GdkEventHandle event1, GdkEventHandle event2, out double distance)
    {
        return GdkEventExterns.gdk_events_get_distance(event1, event2, out distance);
    }

    public static int sGetAngle(this GdkEventHandle event1, GdkEventHandle event2, out double angle)
    {
        return GdkEventExterns.gdk_events_get_angle(event1, event2, out angle);
    }

    public static int sGetCenter(this GdkEventHandle event1, GdkEventHandle event2, out double x, out double y)
    {
        return GdkEventExterns.gdk_events_get_center(event1, event2, out x, out y);
    }

    public static GdkKeyMatch GdkKeyEventMatches(this GdkEventHandle @event, uint keyval, GdkModifierType modifiers)
    {
        return GdkEventExterns.gdk_key_event_matches(@event, keyval, modifiers);
    }

    public static int GdkKeyEventGetMatch(this GdkEventHandle @event, out uint keyval, out GdkModifierType[] modifiers)
    {
        return GdkEventExterns.gdk_key_event_get_match(@event, out keyval, out modifiers);
    }
}
