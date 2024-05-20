namespace MentorLake.Gtk4.Gtk4;

public class GtkSwitchHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkSwitchHandle New()
	{
		return GtkSwitchExterns.gtk_switch_new();
	}

}

public static class GtkSwitchSignalExtensions
{

	public static IObservable<GtkSwitchSignalStructs.ActivateSignal> Signal_Activate(this GtkSwitchHandle instance)
	{
		return Observable.Create((IObserver<GtkSwitchSignalStructs.ActivateSignal> obs) =>
		{
			GtkSwitchSignalDelegates.activate handler = (GtkSwitchHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSwitchSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSwitchSignalStructs.StateSetSignal> Signal_StateSet(this GtkSwitchHandle instance)
	{
		return Observable.Create((IObserver<GtkSwitchSignalStructs.StateSetSignal> obs) =>
		{
			GtkSwitchSignalDelegates.state_set handler = (GtkSwitchHandle self, bool state, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSwitchSignalStructs.StateSetSignal()
				{
					Self = self, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "state_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkSwitchSignalStructs
{

public struct ActivateSignal
{
	public GtkSwitchHandle Self;
	public IntPtr UserData;
}

public struct StateSetSignal
{
	public GtkSwitchHandle Self;
	public bool State;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkSwitchSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSwitchHandle>))] GtkSwitchHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool state_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSwitchHandle>))] GtkSwitchHandle self, bool state, IntPtr user_data);

}


public static class GtkSwitchHandleExtensions
{
	public static bool GetActive(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_active(self);
	}

	public static bool GetState(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_state(self);
	}

	public static GtkSwitchHandle SetActive(this GtkSwitchHandle self, bool is_active)
	{
		GtkSwitchExterns.gtk_switch_set_active(self, is_active);
		return self;
	}

	public static GtkSwitchHandle SetState(this GtkSwitchHandle self, bool state)
	{
		GtkSwitchExterns.gtk_switch_set_state(self, state);
		return self;
	}

}

internal class GtkSwitchExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSwitchHandle gtk_switch_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_switch_get_active(GtkSwitchHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_switch_get_state(GtkSwitchHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_switch_set_active(GtkSwitchHandle self, bool is_active);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_switch_set_state(GtkSwitchHandle self, bool state);

}
