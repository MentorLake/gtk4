namespace MentorLake.Gtk4.Gtk4;

public class GtkGestureClickHandle : GtkGestureSingleHandle
{
	public static GtkGestureClickHandle New()
	{
		return GtkGestureClickExterns.gtk_gesture_click_new();
	}

}

public static class GtkGestureClickSignalExtensions
{

	public static IObservable<GtkGestureClickSignalStructs.PressedSignal> Signal_Pressed(this GtkGestureClickHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureClickSignalStructs.PressedSignal> obs) =>
		{
			GtkGestureClickSignalDelegates.pressed handler = (GtkGestureClickHandle self, int n_press, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureClickSignalStructs.PressedSignal()
				{
					Self = self, NPress = n_press, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureClickSignalStructs.ReleasedSignal> Signal_Released(this GtkGestureClickHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureClickSignalStructs.ReleasedSignal> obs) =>
		{
			GtkGestureClickSignalDelegates.released handler = (GtkGestureClickHandle self, int n_press, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureClickSignalStructs.ReleasedSignal()
				{
					Self = self, NPress = n_press, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureClickSignalStructs.StoppedSignal> Signal_Stopped(this GtkGestureClickHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureClickSignalStructs.StoppedSignal> obs) =>
		{
			GtkGestureClickSignalDelegates.stopped handler = (GtkGestureClickHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureClickSignalStructs.StoppedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "stopped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureClickSignalStructs.UnpairedReleaseSignal> Signal_UnpairedRelease(this GtkGestureClickHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureClickSignalStructs.UnpairedReleaseSignal> obs) =>
		{
			GtkGestureClickSignalDelegates.unpaired_release handler = (GtkGestureClickHandle self, double x, double y, uint button, GdkEventSequenceHandle sequence, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureClickSignalStructs.UnpairedReleaseSignal()
				{
					Self = self, X = x, Y = y, Button = button, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unpaired_release", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureClickSignalStructs
{

public struct PressedSignal
{
	public GtkGestureClickHandle Self;
	public int NPress;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct ReleasedSignal
{
	public GtkGestureClickHandle Self;
	public int NPress;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct StoppedSignal
{
	public GtkGestureClickHandle Self;
	public IntPtr UserData;
}

public struct UnpairedReleaseSignal
{
	public GtkGestureClickHandle Self;
	public double X;
	public double Y;
	public uint Button;
	public GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}
}

public static class GtkGestureClickSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, int n_press, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, int n_press, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unpaired_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, double x, double y, uint button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventSequenceHandle>))] GdkEventSequenceHandle sequence, IntPtr user_data);

}


public static class GtkGestureClickHandleExtensions
{
}

internal class GtkGestureClickExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureClickHandle gtk_gesture_click_new();

}
