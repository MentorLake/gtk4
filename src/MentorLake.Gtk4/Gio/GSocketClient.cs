namespace MentorLake.Gtk4.Gio;

public class GSocketClientHandle : GObjectHandle
{
	public static GSocketClientHandle New()
	{
		return GSocketClientExterns.g_socket_client_new();
	}

}

public static class GSocketClientSignalExtensions
{

	public static IObservable<GSocketClientSignalStructs.EventSignal> Signal_Event(this GSocketClientHandle instance)
	{
		return Observable.Create((IObserver<GSocketClientSignalStructs.EventSignal> obs) =>
		{
			GSocketClientSignalDelegates.@event handler = (GSocketClientHandle self, GSocketClientEvent @event, GSocketConnectableHandle connectable, GIOStreamHandle connection, IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketClientSignalStructs.EventSignal()
				{
					Self = self, Event = @event, Connectable = connectable, Connection = connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GSocketClientSignalStructs
{

public struct EventSignal
{
	public GSocketClientHandle Self;
	public GSocketClientEvent Event;
	public GSocketConnectableHandle Connectable;
	public GIOStreamHandle Connection;
	public IntPtr UserData;
}
}

public static class GSocketClientSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketClientHandle>))] GSocketClientHandle self, GSocketClientEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketConnectableHandleImpl>))] GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GIOStreamHandle>))] GIOStreamHandle connection, IntPtr user_data);

}


public static class GSocketClientHandleExtensions
{
	public static GSocketClientHandle AddApplicationProxy(this GSocketClientHandle client, string protocol)
	{
		GSocketClientExterns.g_socket_client_add_application_proxy(client, protocol);
		return client;
	}

	public static GSocketConnectionHandle Connect(this GSocketClientHandle client, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect(client, connectable, cancellable, out error);
	}

	public static GSocketClientHandle ConnectAsync(this GSocketClientHandle client, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketClientExterns.g_socket_client_connect_async(client, connectable, cancellable, callback, user_data);
		return client;
	}

	public static GSocketConnectionHandle ConnectFinish(this GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_finish(client, result, out error);
	}

	public static GSocketConnectionHandle ConnectToHost(this GSocketClientHandle client, string host_and_port, ushort default_port, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_to_host(client, host_and_port, default_port, cancellable, out error);
	}

	public static GSocketClientHandle ConnectToHostAsync(this GSocketClientHandle client, string host_and_port, ushort default_port, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketClientExterns.g_socket_client_connect_to_host_async(client, host_and_port, default_port, cancellable, callback, user_data);
		return client;
	}

	public static GSocketConnectionHandle ConnectToHostFinish(this GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_to_host_finish(client, result, out error);
	}

	public static GSocketConnectionHandle ConnectToService(this GSocketClientHandle client, string domain, string service, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_to_service(client, domain, service, cancellable, out error);
	}

	public static GSocketClientHandle ConnectToServiceAsync(this GSocketClientHandle client, string domain, string service, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketClientExterns.g_socket_client_connect_to_service_async(client, domain, service, cancellable, callback, user_data);
		return client;
	}

	public static GSocketConnectionHandle ConnectToServiceFinish(this GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_to_service_finish(client, result, out error);
	}

	public static GSocketConnectionHandle ConnectToUri(this GSocketClientHandle client, string uri, ushort default_port, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_to_uri(client, uri, default_port, cancellable, out error);
	}

	public static GSocketClientHandle ConnectToUriAsync(this GSocketClientHandle client, string uri, ushort default_port, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketClientExterns.g_socket_client_connect_to_uri_async(client, uri, default_port, cancellable, callback, user_data);
		return client;
	}

	public static GSocketConnectionHandle ConnectToUriFinish(this GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketClientExterns.g_socket_client_connect_to_uri_finish(client, result, out error);
	}

	public static bool GetEnableProxy(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_enable_proxy(client);
	}

	public static GSocketFamily GetFamily(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_family(client);
	}

	public static GSocketAddressHandle GetLocalAddress(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_local_address(client);
	}

	public static GSocketProtocol GetProtocol(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_protocol(client);
	}

	public static GProxyResolverHandle GetProxyResolver(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_proxy_resolver(client);
	}

	public static GSocketType GetSocketType(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_socket_type(client);
	}

	public static uint GetTimeout(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_timeout(client);
	}

	public static bool GetTls(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_tls(client);
	}

	public static GTlsCertificateFlags GetTlsValidationFlags(this GSocketClientHandle client)
	{
		return GSocketClientExterns.g_socket_client_get_tls_validation_flags(client);
	}

	public static GSocketClientHandle SetEnableProxy(this GSocketClientHandle client, bool enable)
	{
		GSocketClientExterns.g_socket_client_set_enable_proxy(client, enable);
		return client;
	}

	public static GSocketClientHandle SetFamily(this GSocketClientHandle client, GSocketFamily family)
	{
		GSocketClientExterns.g_socket_client_set_family(client, family);
		return client;
	}

	public static GSocketClientHandle SetLocalAddress(this GSocketClientHandle client, GSocketAddressHandle address)
	{
		GSocketClientExterns.g_socket_client_set_local_address(client, address);
		return client;
	}

	public static GSocketClientHandle SetProtocol(this GSocketClientHandle client, GSocketProtocol protocol)
	{
		GSocketClientExterns.g_socket_client_set_protocol(client, protocol);
		return client;
	}

	public static GSocketClientHandle SetProxyResolver(this GSocketClientHandle client, GProxyResolverHandle proxy_resolver)
	{
		GSocketClientExterns.g_socket_client_set_proxy_resolver(client, proxy_resolver);
		return client;
	}

	public static GSocketClientHandle SetSocketType(this GSocketClientHandle client, GSocketType type)
	{
		GSocketClientExterns.g_socket_client_set_socket_type(client, type);
		return client;
	}

	public static GSocketClientHandle SetTimeout(this GSocketClientHandle client, uint timeout)
	{
		GSocketClientExterns.g_socket_client_set_timeout(client, timeout);
		return client;
	}

	public static GSocketClientHandle SetTls(this GSocketClientHandle client, bool tls)
	{
		GSocketClientExterns.g_socket_client_set_tls(client, tls);
		return client;
	}

	public static GSocketClientHandle SetTlsValidationFlags(this GSocketClientHandle client, GTlsCertificateFlags flags)
	{
		GSocketClientExterns.g_socket_client_set_tls_validation_flags(client, flags);
		return client;
	}

}

internal class GSocketClientExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketClientHandle g_socket_client_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_add_application_proxy(GSocketClientHandle client, string protocol);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect(GSocketClientHandle client, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_connect_async(GSocketClientHandle client, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_to_host(GSocketClientHandle client, string host_and_port, ushort default_port, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_connect_to_host_async(GSocketClientHandle client, string host_and_port, ushort default_port, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_to_host_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_to_service(GSocketClientHandle client, string domain, string service, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_connect_to_service_async(GSocketClientHandle client, string domain, string service, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_to_service_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_to_uri(GSocketClientHandle client, string uri, ushort default_port, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_connect_to_uri_async(GSocketClientHandle client, string uri, ushort default_port, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_client_connect_to_uri_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_client_get_enable_proxy(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketFamily g_socket_client_get_family(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_client_get_local_address(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketProtocol g_socket_client_get_protocol(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern GProxyResolverHandle g_socket_client_get_proxy_resolver(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketType g_socket_client_get_socket_type(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_socket_client_get_timeout(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_client_get_tls(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_socket_client_get_tls_validation_flags(GSocketClientHandle client);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_enable_proxy(GSocketClientHandle client, bool enable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_family(GSocketClientHandle client, GSocketFamily family);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_local_address(GSocketClientHandle client, GSocketAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_protocol(GSocketClientHandle client, GSocketProtocol protocol);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_proxy_resolver(GSocketClientHandle client, GProxyResolverHandle proxy_resolver);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_socket_type(GSocketClientHandle client, GSocketType type);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_timeout(GSocketClientHandle client, uint timeout);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_tls(GSocketClientHandle client, bool tls);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_client_set_tls_validation_flags(GSocketClientHandle client, GTlsCertificateFlags flags);

}
