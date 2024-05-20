namespace MentorLake.Gtk4.Gtk4;

public class GtkGestureHandle : GtkEventControllerHandle
{
}

public static class GtkGestureSignalExtensions
{

	public static IObservable<GtkGestureSignalStructs.BeginSignal> Signal_Begin(this GtkGestureHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSignalStructs.BeginSignal> obs) =>
		{
			GtkGestureSignalDelegates.begin handler = (GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSignalStructs.BeginSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureSignalStructs.CancelSignal> Signal_Cancel(this GtkGestureHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSignalStructs.CancelSignal> obs) =>
		{
			GtkGestureSignalDelegates.cancel handler = (GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSignalStructs.CancelSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureSignalStructs.EndSignal> Signal_End(this GtkGestureHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSignalStructs.EndSignal> obs) =>
		{
			GtkGestureSignalDelegates.end handler = (GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSignalStructs.EndSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureSignalStructs.SequenceStateChangedSignal> Signal_SequenceStateChanged(this GtkGestureHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSignalStructs.SequenceStateChangedSignal> obs) =>
		{
			GtkGestureSignalDelegates.sequence_state_changed handler = (GtkGestureHandle self, GdkEventSequenceHandle sequence, GtkEventSequenceState state, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSignalStructs.SequenceStateChangedSignal()
				{
					Self = self, Sequence = sequence, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "sequence_state_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureSignalStructs.UpdateSignal> Signal_Update(this GtkGestureHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSignalStructs.UpdateSignal> obs) =>
		{
			GtkGestureSignalDelegates.update handler = (GtkGestureHandle self, GdkEventSequenceHandle sequence, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSignalStructs.UpdateSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureSignalStructs
{

public struct BeginSignal
{
	public GtkGestureHandle Self;
	public GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public GtkGestureHandle Self;
	public GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}

public struct EndSignal
{
	public GtkGestureHandle Self;
	public GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}

public struct SequenceStateChangedSignal
{
	public GtkGestureHandle Self;
	public GdkEventSequenceHandle Sequence;
	public GtkEventSequenceState State;
	public IntPtr UserData;
}

public struct UpdateSignal
{
	public GtkGestureHandle Self;
	public GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}
}

public static class GtkGestureSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventSequenceHandle>))] GdkEventSequenceHandle sequence, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventSequenceHandle>))] GdkEventSequenceHandle sequence, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventSequenceHandle>))] GdkEventSequenceHandle sequence, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void sequence_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventSequenceHandle>))] GdkEventSequenceHandle sequence, GtkEventSequenceState state, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureHandle>))] GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventSequenceHandle>))] GdkEventSequenceHandle sequence, IntPtr user_data);

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
