namespace MentorLake.Gtk4.Gtk4;

public class GtkGestureStylusHandle : GtkGestureSingleHandle
{
	public static GtkGestureStylusHandle New()
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_new();
	}

}

public static class GtkGestureStylusSignalExtensions
{

	public static IObservable<GtkGestureStylusSignalStructs.DownSignal> Signal_Down(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.DownSignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.down handler = (GtkGestureStylusHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.DownSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "down", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureStylusSignalStructs.MotionSignal> Signal_Motion(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.MotionSignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.motion handler = (GtkGestureStylusHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.MotionSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureStylusSignalStructs.ProximitySignal> Signal_Proximity(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.ProximitySignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.proximity handler = (GtkGestureStylusHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.ProximitySignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "proximity", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureStylusSignalStructs.UpSignal> Signal_Up(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.UpSignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.up handler = (GtkGestureStylusHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.UpSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureStylusSignalStructs
{

public struct DownSignal
{
	public GtkGestureStylusHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct MotionSignal
{
	public GtkGestureStylusHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct ProximitySignal
{
	public GtkGestureStylusHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct UpSignal
{
	public GtkGestureStylusHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkGestureStylusSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void proximity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);

}


public static class GtkGestureStylusHandleExtensions
{
	public static bool GetAxes(this GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_axes(gesture, axes, out values);
	}

	public static bool GetAxis(this GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_axis(gesture, axis, out value);
	}

	public static bool GetBacklog(this GtkGestureStylusHandle gesture, out GdkTimeCoord[] backlog, out uint n_elems)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_backlog(gesture, out backlog, out n_elems);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GtkGestureStylusHandle gesture)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_device_tool(gesture);
	}

	public static bool GetStylusOnly(this GtkGestureStylusHandle gesture)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_stylus_only(gesture);
	}

	public static GtkGestureStylusHandle SetStylusOnly(this GtkGestureStylusHandle gesture, bool stylus_only)
	{
		GtkGestureStylusExterns.gtk_gesture_stylus_set_stylus_only(gesture, stylus_only);
		return gesture;
	}

}

internal class GtkGestureStylusExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureStylusHandle gtk_gesture_stylus_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_axes(GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_axis(GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_backlog(GtkGestureStylusHandle gesture, out GdkTimeCoord[] backlog, out uint n_elems);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDeviceToolHandle gtk_gesture_stylus_get_device_tool(GtkGestureStylusHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_stylus_only(GtkGestureStylusHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_stylus_set_stylus_only(GtkGestureStylusHandle gesture, bool stylus_only);

}
