namespace MentorLake.Gtk4.Gio;

public class GSimpleActionHandle : GObjectHandle, GActionHandle
{
	public static GSimpleActionHandle New(string name, GVariantTypeHandle parameter_type)
	{
		return GSimpleActionExterns.g_simple_action_new(name, parameter_type);
	}

	public static GSimpleActionHandle NewStateful(string name, GVariantTypeHandle parameter_type, GVariantHandle state)
	{
		return GSimpleActionExterns.g_simple_action_new_stateful(name, parameter_type, state);
	}

}

public static class GSimpleActionSignalExtensions
{

	public static IObservable<GSimpleActionSignalStructs.ActivateSignal> Signal_Activate(this GSimpleActionHandle instance)
	{
		return Observable.Create((IObserver<GSimpleActionSignalStructs.ActivateSignal> obs) =>
		{
			GSimpleActionSignalDelegates.activate handler = (GSimpleActionHandle self, GVariantHandle parameter, IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionSignalStructs.ActivateSignal()
				{
					Self = self, Parameter = parameter, UserData = user_data
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

	public static IObservable<GSimpleActionSignalStructs.ChangeStateSignal> Signal_ChangeState(this GSimpleActionHandle instance)
	{
		return Observable.Create((IObserver<GSimpleActionSignalStructs.ChangeStateSignal> obs) =>
		{
			GSimpleActionSignalDelegates.change_state handler = (GSimpleActionHandle self, GVariantHandle value, IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionSignalStructs.ChangeStateSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_state", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GSimpleActionSignalStructs
{

public struct ActivateSignal
{
	public GSimpleActionHandle Self;
	public GVariantHandle Parameter;
	public IntPtr UserData;
}

public struct ChangeStateSignal
{
	public GSimpleActionHandle Self;
	public GVariantHandle Value;
	public IntPtr UserData;
}
}

public static class GSimpleActionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSimpleActionHandle>))] GSimpleActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVariantHandle>))] GVariantHandle parameter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void change_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSimpleActionHandle>))] GSimpleActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVariantHandle>))] GVariantHandle value, IntPtr user_data);

}


public static class GSimpleActionHandleExtensions
{
	public static GSimpleActionHandle SetEnabled(this GSimpleActionHandle simple, bool enabled)
	{
		GSimpleActionExterns.g_simple_action_set_enabled(simple, enabled);
		return simple;
	}

	public static GSimpleActionHandle SetState(this GSimpleActionHandle simple, GVariantHandle value)
	{
		GSimpleActionExterns.g_simple_action_set_state(simple, value);
		return simple;
	}

	public static GSimpleActionHandle SetStateHint(this GSimpleActionHandle simple, GVariantHandle state_hint)
	{
		GSimpleActionExterns.g_simple_action_set_state_hint(simple, state_hint);
		return simple;
	}

}

internal class GSimpleActionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleActionHandle g_simple_action_new(string name, GVariantTypeHandle parameter_type);

	[DllImport(Libraries.Gio)]
	internal static extern GSimpleActionHandle g_simple_action_new_stateful(string name, GVariantTypeHandle parameter_type, GVariantHandle state);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_set_enabled(GSimpleActionHandle simple, bool enabled);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_set_state(GSimpleActionHandle simple, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_set_state_hint(GSimpleActionHandle simple, GVariantHandle state_hint);

}
