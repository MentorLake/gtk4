using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkEventExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_ref")]
	internal static extern GdkEventHandle gdk_event_ref(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_unref")]
	internal static extern void gdk_event_unref(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_event_type")]
	internal static extern GdkEventType gdk_event_get_event_type(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_surface")]
	internal static extern GdkSurfaceHandle gdk_event_get_surface(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_seat")]
	internal static extern GdkSeatHandle gdk_event_get_seat(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_device")]
	internal static extern GdkDeviceHandle gdk_event_get_device(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_device_tool")]
	internal static extern GdkDeviceToolHandle gdk_event_get_device_tool(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_time")]
	internal static extern uint gdk_event_get_time(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_display")]
	internal static extern GdkDisplayHandle gdk_event_get_display(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_event_sequence")]
	internal static extern GdkEventSequenceHandle gdk_event_get_event_sequence(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_modifier_state")]
	internal static extern GdkModifierType gdk_event_get_modifier_state(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_position")]
	internal static extern int gdk_event_get_position(this GdkEventHandle @event, out double x, out double y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_axes")]
	internal static extern int gdk_event_get_axes(this GdkEventHandle @event, out double[] axes, out uint n_axes);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_axis")]
	internal static extern int gdk_event_get_axis(this GdkEventHandle @event, GdkAxisUse axis_use, out double value);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_history")]
	internal static extern GdkTimeCoordHandle gdk_event_get_history(this GdkEventHandle @event, out uint out_n_coords);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_get_pointer_emulated")]
	internal static extern int gdk_event_get_pointer_emulated(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_button_event_get_button")]
	internal static extern uint gdk_button_event_get_button(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_scroll_event_get_direction")]
	internal static extern GdkScrollDirection gdk_scroll_event_get_direction(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_scroll_event_get_deltas")]
	internal static extern void gdk_scroll_event_get_deltas(this GdkEventHandle @event, out double delta_x, out double delta_y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_scroll_event_is_stop")]
	internal static extern int gdk_scroll_event_is_stop(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_get_keyval")]
	internal static extern uint gdk_key_event_get_keyval(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_get_keycode")]
	internal static extern uint gdk_key_event_get_keycode(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_get_consumed_modifiers")]
	internal static extern GdkModifierType gdk_key_event_get_consumed_modifiers(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_get_layout")]
	internal static extern uint gdk_key_event_get_layout(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_get_level")]
	internal static extern uint gdk_key_event_get_level(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_is_modifier")]
	internal static extern int gdk_key_event_is_modifier(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_focus_event_get_in")]
	internal static extern int gdk_focus_event_get_in(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_touch_event_get_emulating_pointer")]
	internal static extern int gdk_touch_event_get_emulating_pointer(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_crossing_event_get_mode")]
	internal static extern GdkCrossingMode gdk_crossing_event_get_mode(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_crossing_event_get_detail")]
	internal static extern GdkNotifyType gdk_crossing_event_get_detail(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_crossing_event_get_focus")]
	internal static extern int gdk_crossing_event_get_focus(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_touchpad_event_get_gesture_phase")]
	internal static extern GdkTouchpadGesturePhase gdk_touchpad_event_get_gesture_phase(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_touchpad_event_get_n_fingers")]
	internal static extern uint gdk_touchpad_event_get_n_fingers(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_touchpad_event_get_deltas")]
	internal static extern void gdk_touchpad_event_get_deltas(this GdkEventHandle @event, out double dx, out double dy);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_touchpad_event_get_pinch_angle_delta")]
	internal static extern double gdk_touchpad_event_get_pinch_angle_delta(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_touchpad_event_get_pinch_scale")]
	internal static extern double gdk_touchpad_event_get_pinch_scale(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_pad_event_get_button")]
	internal static extern uint gdk_pad_event_get_button(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_pad_event_get_axis_value")]
	internal static extern void gdk_pad_event_get_axis_value(this GdkEventHandle @event, out uint index, out double value);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_pad_event_get_group_mode")]
	internal static extern void gdk_pad_event_get_group_mode(this GdkEventHandle @event, out uint group, out uint mode);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_dnd_event_get_drop")]
	internal static extern GdkDropHandle gdk_dnd_event_get_drop(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_grab_broken_event_get_grab_surface")]
	internal static extern GdkSurfaceHandle gdk_grab_broken_event_get_grab_surface(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_grab_broken_event_get_implicit")]
	internal static extern int gdk_grab_broken_event_get_implicit(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_event_triggers_context_menu")]
	internal static extern int gdk_event_triggers_context_menu(this GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_events_get_distance")]
	internal static extern int gdk_events_get_distance(this GdkEventHandle event1, GdkEventHandle event2, out double distance);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_events_get_angle")]
	internal static extern int gdk_events_get_angle(this GdkEventHandle event1, GdkEventHandle event2, out double angle);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_events_get_center")]
	internal static extern int gdk_events_get_center(this GdkEventHandle event1, GdkEventHandle event2, out double x, out double y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_matches")]
	internal static extern GdkKeyMatch gdk_key_event_matches(this GdkEventHandle @event, uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_key_event_get_match")]
	internal static extern int gdk_key_event_get_match(this GdkEventHandle @event, out uint keyval, out GdkModifierType[] modifiers);
}
