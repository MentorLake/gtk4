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

public static class GtkGestureSignalExtensions
{
	public static GtkGestureHandle Signal_Begin(this GtkGestureHandle instance, GtkGestureSignalDelegates.Begin handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureHandle Signal_Cancel(this GtkGestureHandle instance, GtkGestureSignalDelegates.Cancel handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureHandle Signal_End(this GtkGestureHandle instance, GtkGestureSignalDelegates.End handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureHandle Signal_SequenceStateChanged(this GtkGestureHandle instance, GtkGestureSignalDelegates.SequenceStateChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "sequence_state_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureHandle Signal_Update(this GtkGestureHandle instance, GtkGestureSignalDelegates.Update handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void End([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SequenceStateChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, GdkEventSequenceHandle sequence, GtkEventSequenceState state, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data);
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
