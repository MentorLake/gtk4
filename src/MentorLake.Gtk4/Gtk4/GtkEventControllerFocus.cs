namespace MentorLake.Gtk4.Gtk4;

public class GtkEventControllerFocusHandle : GtkEventControllerHandle
{
	public static GtkEventControllerFocusHandle New()
	{
		return GtkEventControllerFocusExterns.gtk_event_controller_focus_new();
	}

}

public static class GtkEventControllerFocusSignalExtensions
{

	public static IObservable<GtkEventControllerFocusSignalStructs.EnterSignal> Signal_Enter(this GtkEventControllerFocusHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerFocusSignalStructs.EnterSignal> obs) =>
		{
			GtkEventControllerFocusSignalDelegates.enter handler = (GtkEventControllerFocusHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerFocusSignalStructs.EnterSignal()
				{
					Self = self, UserData = user_data
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

	public static IObservable<GtkEventControllerFocusSignalStructs.LeaveSignal> Signal_Leave(this GtkEventControllerFocusHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerFocusSignalStructs.LeaveSignal> obs) =>
		{
			GtkEventControllerFocusSignalDelegates.leave handler = (GtkEventControllerFocusHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerFocusSignalStructs.LeaveSignal()
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
}

public static class GtkEventControllerFocusSignalStructs
{

public struct EnterSignal
{
	public GtkEventControllerFocusHandle Self;
	public IntPtr UserData;
}

public struct LeaveSignal
{
	public GtkEventControllerFocusHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEventControllerFocusSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerFocusHandle>))] GtkEventControllerFocusHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerFocusHandle>))] GtkEventControllerFocusHandle self, IntPtr user_data);

}


public static class GtkEventControllerFocusHandleExtensions
{
	public static bool ContainsFocus(this GtkEventControllerFocusHandle self)
	{
		return GtkEventControllerFocusExterns.gtk_event_controller_focus_contains_focus(self);
	}

	public static bool IsFocus(this GtkEventControllerFocusHandle self)
	{
		return GtkEventControllerFocusExterns.gtk_event_controller_focus_is_focus(self);
	}

}

internal class GtkEventControllerFocusExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerFocusHandle gtk_event_controller_focus_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_focus_contains_focus(GtkEventControllerFocusHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_focus_is_focus(GtkEventControllerFocusHandle self);

}
