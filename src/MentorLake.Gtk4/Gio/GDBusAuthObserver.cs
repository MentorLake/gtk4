namespace MentorLake.Gtk4.Gio;

public class GDBusAuthObserverHandle : GObjectHandle
{
	public static GDBusAuthObserverHandle GDbusAuthObserverNew()
	{
		return GDBusAuthObserverExterns.g_dbus_auth_observer_new();
	}

}

public static class GDBusAuthObserverSignalExtensions
{

	public static IObservable<GDBusAuthObserverSignalStructs.AllowMechanismSignal> Signal_AllowMechanism(this GDBusAuthObserverHandle instance)
	{
		return Observable.Create((IObserver<GDBusAuthObserverSignalStructs.AllowMechanismSignal> obs) =>
		{
			GDBusAuthObserverSignalDelegates.allow_mechanism handler = (GDBusAuthObserverHandle self, string mechanism, IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusAuthObserverSignalStructs.AllowMechanismSignal()
				{
					Self = self, Mechanism = mechanism, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "allow_mechanism", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GDBusAuthObserverSignalStructs.AuthorizeAuthenticatedPeerSignal> Signal_AuthorizeAuthenticatedPeer(this GDBusAuthObserverHandle instance)
	{
		return Observable.Create((IObserver<GDBusAuthObserverSignalStructs.AuthorizeAuthenticatedPeerSignal> obs) =>
		{
			GDBusAuthObserverSignalDelegates.authorize_authenticated_peer handler = (GDBusAuthObserverHandle self, GIOStreamHandle stream, GCredentialsHandle credentials, IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusAuthObserverSignalStructs.AuthorizeAuthenticatedPeerSignal()
				{
					Self = self, Stream = stream, Credentials = credentials, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "authorize_authenticated_peer", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GDBusAuthObserverSignalStructs
{

public struct AllowMechanismSignal
{
	public GDBusAuthObserverHandle Self;
	public string Mechanism;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct AuthorizeAuthenticatedPeerSignal
{
	public GDBusAuthObserverHandle Self;
	public GIOStreamHandle Stream;
	public GCredentialsHandle Credentials;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusAuthObserverSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool allow_mechanism([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusAuthObserverHandle>))] GDBusAuthObserverHandle self, string mechanism, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize_authenticated_peer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusAuthObserverHandle>))] GDBusAuthObserverHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GIOStreamHandle>))] GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GCredentialsHandle>))] GCredentialsHandle credentials, IntPtr user_data);

}


public static class GDBusAuthObserverHandleExtensions
{
	public static bool GDbusAuthObserverAllowMechanism(this GDBusAuthObserverHandle observer, string mechanism)
	{
		return GDBusAuthObserverExterns.g_dbus_auth_observer_allow_mechanism(observer, mechanism);
	}

	public static bool GDbusAuthObserverAuthorizeAuthenticatedPeer(this GDBusAuthObserverHandle observer, GIOStreamHandle stream, GCredentialsHandle credentials)
	{
		return GDBusAuthObserverExterns.g_dbus_auth_observer_authorize_authenticated_peer(observer, stream, credentials);
	}

}

internal class GDBusAuthObserverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusAuthObserverHandle g_dbus_auth_observer_new();

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_auth_observer_allow_mechanism(GDBusAuthObserverHandle observer, string mechanism);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_auth_observer_authorize_authenticated_peer(GDBusAuthObserverHandle observer, GIOStreamHandle stream, GCredentialsHandle credentials);

}
