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

namespace MentorLake.Gtk4.Gtk4;

public class GtkGestureHandle : GtkEventControllerHandle
{
}

public class GtkGestureSignal
{
	public string Value { get; set; }
	public GtkGestureSignal(string value) => Value = value;
}

public static class GtkGestureSignals
{
	public static GtkGestureSignal Begin = new("begin");
	public static GtkGestureSignal Cancel = new("cancel");
	public static GtkGestureSignal End = new("end");
	public static GtkGestureSignal SequenceStateChanged = new("sequence-state-changed");
	public static GtkGestureSignal Update = new("update");
}

public static class GtkGestureHandleExtensions
{
	public static bool GetBoundingBox(this GtkGestureHandle gesture, out GdkRectangle rect)
	{
		return GtkGestureExterns.gtk_gesture_get_bounding_box(gesture, out rect);
	}

	public static bool GetBoundingBoxCenter(this GtkGestureHandle gesture, out double x, out double y)
	{
		return GtkGestureExterns.gtk_gesture_get_bounding_box_center(gesture, out x, out y);
	}

	public static GdkDeviceHandle GetDevice(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_device(gesture);
	}

	public static GListHandle GetGroup(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_group(gesture);
	}

	public static GdkEventHandle GetLastEvent(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence)
	{
		return GtkGestureExterns.gtk_gesture_get_last_event(gesture, sequence);
	}

	public static GdkEventSequenceHandle GetLastUpdatedSequence(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_last_updated_sequence(gesture);
	}

	public static bool GetPoint(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence, out double x, out double y)
	{
		return GtkGestureExterns.gtk_gesture_get_point(gesture, sequence, out x, out y);
	}

	public static GtkEventSequenceState GetSequenceState(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence)
	{
		return GtkGestureExterns.gtk_gesture_get_sequence_state(gesture, sequence);
	}

	public static GListHandle GetSequences(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_get_sequences(gesture);
	}

	public static GtkGestureHandle Group(this GtkGestureHandle group_gesture, GtkGestureHandle gesture)
	{
		GtkGestureExterns.gtk_gesture_group(group_gesture, gesture);
		return group_gesture;
	}

	public static bool HandlesSequence(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence)
	{
		return GtkGestureExterns.gtk_gesture_handles_sequence(gesture, sequence);
	}

	public static bool IsActive(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_is_active(gesture);
	}

	public static bool IsGroupedWith(this GtkGestureHandle gesture, GtkGestureHandle other)
	{
		return GtkGestureExterns.gtk_gesture_is_grouped_with(gesture, other);
	}

	public static bool IsRecognized(this GtkGestureHandle gesture)
	{
		return GtkGestureExterns.gtk_gesture_is_recognized(gesture);
	}

	public static bool SetSequenceState(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence, GtkEventSequenceState state)
	{
		return GtkGestureExterns.gtk_gesture_set_sequence_state(gesture, sequence, state);
	}

	public static bool SetState(this GtkGestureHandle gesture, GtkEventSequenceState state)
	{
		return GtkGestureExterns.gtk_gesture_set_state(gesture, state);
	}

	public static GtkGestureHandle Ungroup(this GtkGestureHandle gesture)
	{
		GtkGestureExterns.gtk_gesture_ungroup(gesture);
		return gesture;
	}

	public static GtkGestureHandle Connect(this GtkGestureHandle instance, GtkGestureSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkGestureExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_get_bounding_box(GtkGestureHandle gesture, out GdkRectangle rect);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_get_bounding_box_center(GtkGestureHandle gesture, out double x, out double y);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDeviceHandle gtk_gesture_get_device(GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_gesture_get_group(GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkEventHandle gtk_gesture_get_last_event(GtkGestureHandle gesture, GdkEventSequenceHandle sequence);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkEventSequenceHandle gtk_gesture_get_last_updated_sequence(GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_get_point(GtkGestureHandle gesture, GdkEventSequenceHandle sequence, out double x, out double y);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventSequenceState gtk_gesture_get_sequence_state(GtkGestureHandle gesture, GdkEventSequenceHandle sequence);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_gesture_get_sequences(GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_group(GtkGestureHandle group_gesture, GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_handles_sequence(GtkGestureHandle gesture, GdkEventSequenceHandle sequence);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_is_active(GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_is_grouped_with(GtkGestureHandle gesture, GtkGestureHandle other);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_is_recognized(GtkGestureHandle gesture);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_set_sequence_state(GtkGestureHandle gesture, GdkEventSequenceHandle sequence, GtkEventSequenceState state);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_set_state(GtkGestureHandle gesture, GtkEventSequenceState state);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_ungroup(GtkGestureHandle gesture);
}
