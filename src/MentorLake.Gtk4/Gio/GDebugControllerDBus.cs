namespace MentorLake.Gtk4.Gio;

public class GDebugControllerDBusHandle : GObjectHandle, GDebugControllerHandle, GInitableHandle
{
	public static GDebugControllerDBusHandle GDebugControllerDbusNew(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDebugControllerDBusExterns.g_debug_controller_dbus_new(connection, cancellable, out error);
	}

}

public static class GDebugControllerDBusSignalExtensions
{

	public static IObservable<GDebugControllerDBusSignalStructs.AuthorizeSignal> Signal_Authorize(this GDebugControllerDBusHandle instance)
	{
		return Observable.Create((IObserver<GDebugControllerDBusSignalStructs.AuthorizeSignal> obs) =>
		{
			GDebugControllerDBusSignalDelegates.Authorize handler = (GDebugControllerDBusHandle self, GDBusMethodInvocationHandle invocation, IntPtr user_data) =>
			{
				

				var signalStruct = new GDebugControllerDBusSignalStructs.AuthorizeSignal()
				{
					Self = self, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "authorize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GDebugControllerDBusSignalStructs
{

public struct AuthorizeSignal
{
	public GDebugControllerDBusHandle Self;
	public GDBusMethodInvocationHandle Invocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDebugControllerDBusSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Authorize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDebugControllerDBusHandle>))] GDebugControllerDBusHandle self, GDBusMethodInvocationHandle invocation, IntPtr user_data);
}


public static class GDebugControllerDBusHandleExtensions
{
	public static GDebugControllerDBusHandle GDebugControllerDbusStop(this GDebugControllerDBusHandle self)
	{
		GDebugControllerDBusExterns.g_debug_controller_dbus_stop(self);
		return self;
	}

}

internal class GDebugControllerDBusExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDebugControllerDBusHandle g_debug_controller_dbus_new(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_debug_controller_dbus_stop(GDebugControllerDBusHandle self);

}
