namespace MentorLake.Gtk4.Gtk4;

public class GtkEventControllerMotionHandle : GtkEventControllerHandle
{
	public static GtkEventControllerMotionHandle New()
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_new();
	}

}

public static class GtkEventControllerMotionSignalExtensions
{

	public static IObservable<GtkEventControllerMotionSignalStructs.EnterSignal> Signal_Enter(this GtkEventControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionSignalStructs.EnterSignal> obs) =>
		{
			GtkEventControllerMotionSignalDelegates.Enter handler = (GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionSignalStructs.EnterSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerMotionSignalStructs.LeaveSignal> Signal_Leave(this GtkEventControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionSignalStructs.LeaveSignal> obs) =>
		{
			GtkEventControllerMotionSignalDelegates.Leave handler = (GtkEventControllerMotionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerMotionSignalStructs.MotionSignal> Signal_Motion(this GtkEventControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionSignalStructs.MotionSignal> obs) =>
		{
			GtkEventControllerMotionSignalDelegates.Motion handler = (GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionSignalStructs.MotionSignal()
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
}

public static class GtkEventControllerMotionSignalStructs
{

public struct EnterSignal
{
	public GtkEventControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct LeaveSignal
{
	public GtkEventControllerMotionHandle Self;
	public IntPtr UserData;
}

public struct MotionSignal
{
	public GtkEventControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkEventControllerMotionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);
}


public static class GtkEventControllerMotionHandleExtensions
{
	public static bool ContainsPointer(this GtkEventControllerMotionHandle self)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_contains_pointer(self);
	}

	public static bool IsPointer(this GtkEventControllerMotionHandle self)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_is_pointer(self);
	}

}

internal class GtkEventControllerMotionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerMotionHandle gtk_event_controller_motion_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_motion_contains_pointer(GtkEventControllerMotionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_motion_is_pointer(GtkEventControllerMotionHandle self);

}
