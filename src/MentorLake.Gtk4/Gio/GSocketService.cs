namespace MentorLake.Gtk4.Gio;

public class GSocketServiceHandle : GSocketListenerHandle
{
	public static GSocketServiceHandle New()
	{
		return GSocketServiceExterns.g_socket_service_new();
	}

}

public static class GSocketServiceSignalExtensions
{

	public static IObservable<GSocketServiceSignalStructs.IncomingSignal> Signal_Incoming(this GSocketServiceHandle instance)
	{
		return Observable.Create((IObserver<GSocketServiceSignalStructs.IncomingSignal> obs) =>
		{
			GSocketServiceSignalDelegates.incoming handler = (GSocketServiceHandle self, GSocketConnectionHandle connection, GObjectHandle source_object, IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketServiceSignalStructs.IncomingSignal()
				{
					Self = self, Connection = connection, SourceObject = source_object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "incoming", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GSocketServiceSignalStructs
{

public struct IncomingSignal
{
	public GSocketServiceHandle Self;
	public GSocketConnectionHandle Connection;
	public GObjectHandle SourceObject;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GSocketServiceSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool incoming([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketServiceHandle>))] GSocketServiceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketConnectionHandle>))] GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle source_object, IntPtr user_data);

}


public static class GSocketServiceHandleExtensions
{
	public static bool IsActive(this GSocketServiceHandle service)
	{
		return GSocketServiceExterns.g_socket_service_is_active(service);
	}

	public static GSocketServiceHandle Start(this GSocketServiceHandle service)
	{
		GSocketServiceExterns.g_socket_service_start(service);
		return service;
	}

	public static GSocketServiceHandle Stop(this GSocketServiceHandle service)
	{
		GSocketServiceExterns.g_socket_service_stop(service);
		return service;
	}

}

internal class GSocketServiceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketServiceHandle g_socket_service_new();

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_service_is_active(GSocketServiceHandle service);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_service_start(GSocketServiceHandle service);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_service_stop(GSocketServiceHandle service);

}
