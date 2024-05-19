namespace MentorLake.Gtk4.Gtk4;

public class GtkDropControllerMotionHandle : GtkEventControllerHandle
{
	public static GtkDropControllerMotionHandle New()
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_new();
	}

}

public static class GtkDropControllerMotionSignalExtensions
{

	public static IObservable<GtkDropControllerMotionSignalStructs.EnterSignal> Signal_Enter(this GtkDropControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkDropControllerMotionSignalStructs.EnterSignal> obs) =>
		{
			GtkDropControllerMotionSignalDelegates.Enter handler = (GtkDropControllerMotionHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropControllerMotionSignalStructs.EnterSignal()
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

	public static IObservable<GtkDropControllerMotionSignalStructs.LeaveSignal> Signal_Leave(this GtkDropControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkDropControllerMotionSignalStructs.LeaveSignal> obs) =>
		{
			GtkDropControllerMotionSignalDelegates.Leave handler = (GtkDropControllerMotionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropControllerMotionSignalStructs.LeaveSignal()
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

	public static IObservable<GtkDropControllerMotionSignalStructs.MotionSignal> Signal_Motion(this GtkDropControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkDropControllerMotionSignalStructs.MotionSignal> obs) =>
		{
			GtkDropControllerMotionSignalDelegates.Motion handler = (GtkDropControllerMotionHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropControllerMotionSignalStructs.MotionSignal()
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

public static class GtkDropControllerMotionSignalStructs
{

public struct EnterSignal
{
	public GtkDropControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct LeaveSignal
{
	public GtkDropControllerMotionHandle Self;
	public IntPtr UserData;
}

public struct MotionSignal
{
	public GtkDropControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkDropControllerMotionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropControllerMotionHandle>))] GtkDropControllerMotionHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropControllerMotionHandle>))] GtkDropControllerMotionHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropControllerMotionHandle>))] GtkDropControllerMotionHandle self, double x, double y, IntPtr user_data);
}


public static class GtkDropControllerMotionHandleExtensions
{
	public static bool ContainsPointer(this GtkDropControllerMotionHandle self)
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_contains_pointer(self);
	}

	public static GdkDropHandle GetDrop(this GtkDropControllerMotionHandle self)
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_get_drop(self);
	}

	public static bool IsPointer(this GtkDropControllerMotionHandle self)
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_is_pointer(self);
	}

}

internal class GtkDropControllerMotionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropControllerMotionHandle gtk_drop_controller_motion_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_controller_motion_contains_pointer(GtkDropControllerMotionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDropHandle gtk_drop_controller_motion_get_drop(GtkDropControllerMotionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_controller_motion_is_pointer(GtkDropControllerMotionHandle self);

}
