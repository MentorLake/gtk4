using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureAdaptors
{
	public static GdkDeviceHandle GetDevice(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_device(gesture);
	}

	public static int SetState(this GtkGestureHandle gesture, GtkEventSequenceState state)
	{
		return GtkGestureExterns.gtk_gesture_set_state(gesture, state);
	}

	public static GtkEventSequenceState GetSequenceState(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence)
	{
		return GtkGestureExterns.gtk_gesture_get_sequence_state(gesture, sequence);
	}

	public static int SetSequenceState(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence, GtkEventSequenceState state)
	{
		return GtkGestureExterns.gtk_gesture_set_sequence_state(gesture, sequence, state);
	}

	public static GListHandle GetSequences(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_sequences(gesture);
	}

	public static GdkEventSequenceHandle GetLastUpdatedSequence(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_last_updated_sequence(gesture);
	}

	public static int HandlesSequence(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence)
	{
		return GtkGestureExterns.gtk_gesture_handles_sequence(gesture, sequence);
	}

	public static GdkEventHandle GetLastEvent(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence)
	{
		return GtkGestureExterns.gtk_gesture_get_last_event(gesture, sequence);
	}

	public static int GetPoint(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence, out double x, out double y)
	{
		return GtkGestureExterns.gtk_gesture_get_point(gesture, sequence, out x, out y);
	}

	public static int GetBoundingBox(this GtkGestureHandle gesture, GdkRectangleHandle rect)
	{
		return GtkGestureExterns.gtk_gesture_get_bounding_box(gesture, rect);
	}

	public static int GetBoundingBoxCenter(this GtkGestureHandle gesture, out double x, out double y)
	{
		return GtkGestureExterns.gtk_gesture_get_bounding_box_center(gesture, out x, out y);
	}

	public static int IsActive(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_is_active(gesture);
	}

	public static int IsRecognized(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_is_recognized(gesture);
	}

	public static GtkGestureHandle Group(this GtkGestureHandle group_gesture, GtkGestureHandle gesture)
	{
		GtkGestureExterns.gtk_gesture_group(group_gesture, gesture);
		return group_gesture;
	}

	public static GtkGestureHandle Ungroup(this GtkGestureHandle gesture)
	{
		GtkGestureExterns.gtk_gesture_ungroup(gesture);
		return gesture;
	}

	public static GListHandle GetGroup(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_group(gesture);
	}

	public static int IsGroupedWith(this GtkGestureHandle gesture, GtkGestureHandle other)
	{
		return GtkGestureExterns.gtk_gesture_is_grouped_with(gesture, other);
	}

	public static GtkGestureHandle DragNew()
	{
		return GtkGestureExterns.gtk_gesture_drag_new();
	}

	public static GtkGestureHandle LongPressNew()
	{
		return GtkGestureExterns.gtk_gesture_long_press_new();
	}

	public static GtkGestureHandle PanNew(GtkOrientation orientation)
	{
		return GtkGestureExterns.gtk_gesture_pan_new(orientation);
	}

	public static GtkGestureHandle RotateNew()
	{
		return GtkGestureExterns.gtk_gesture_rotate_new();
	}

	public static GtkGestureHandle StylusNew()
	{
		return GtkGestureExterns.gtk_gesture_stylus_new();
	}

	public static GtkGestureHandle SwipeNew()
	{
		return GtkGestureExterns.gtk_gesture_swipe_new();
	}

	public static GtkGestureHandle ZoomNew()
	{
		return GtkGestureExterns.gtk_gesture_zoom_new();
	}
}
