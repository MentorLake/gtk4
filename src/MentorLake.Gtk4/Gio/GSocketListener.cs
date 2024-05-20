namespace MentorLake.Gtk4.Gio;

public class GSocketListenerHandle : GObjectHandle
{
	public static GSocketListenerHandle New()
	{
		return GSocketListenerExterns.g_socket_listener_new();
	}

}

public static class GSocketListenerSignalExtensions
{

	public static IObservable<GSocketListenerSignalStructs.EventSignal> Signal_Event(this GSocketListenerHandle instance)
	{
		return Observable.Create((IObserver<GSocketListenerSignalStructs.EventSignal> obs) =>
		{
			GSocketListenerSignalDelegates.@event handler = (GSocketListenerHandle self, GSocketListenerEvent @event, GSocketHandle socket, IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketListenerSignalStructs.EventSignal()
				{
					Self = self, Event = @event, Socket = socket, UserData = user_data
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

public static class GSocketListenerSignalStructs
{

public struct EventSignal
{
	public GSocketListenerHandle Self;
	public GSocketListenerEvent Event;
	public GSocketHandle Socket;
	public IntPtr UserData;
}
}

public static class GSocketListenerSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketListenerHandle>))] GSocketListenerHandle self, GSocketListenerEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketHandle>))] GSocketHandle socket, IntPtr user_data);

}


public static class GSocketListenerHandleExtensions
{
	public static GSocketConnectionHandle Accept(this GSocketListenerHandle listener, out GObjectHandle source_object, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_accept(listener, out source_object, cancellable, out error);
	}

	public static GSocketListenerHandle AcceptAsync(this GSocketListenerHandle listener, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketListenerExterns.g_socket_listener_accept_async(listener, cancellable, callback, user_data);
		return listener;
	}

	public static GSocketConnectionHandle AcceptFinish(this GSocketListenerHandle listener, GAsyncResultHandle result, out GObjectHandle source_object, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_accept_finish(listener, result, out source_object, out error);
	}

	public static GSocketHandle AcceptSocket(this GSocketListenerHandle listener, out GObjectHandle source_object, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_accept_socket(listener, out source_object, cancellable, out error);
	}

	public static GSocketListenerHandle AcceptSocketAsync(this GSocketListenerHandle listener, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketListenerExterns.g_socket_listener_accept_socket_async(listener, cancellable, callback, user_data);
		return listener;
	}

	public static GSocketHandle AcceptSocketFinish(this GSocketListenerHandle listener, GAsyncResultHandle result, out GObjectHandle source_object, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_accept_socket_finish(listener, result, out source_object, out error);
	}

	public static bool AddAddress(this GSocketListenerHandle listener, GSocketAddressHandle address, GSocketType type, GSocketProtocol protocol, GObjectHandle source_object, out GSocketAddressHandle effective_address, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_add_address(listener, address, type, protocol, source_object, out effective_address, out error);
	}

	public static ushort AddAnyInetPort(this GSocketListenerHandle listener, GObjectHandle source_object, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_add_any_inet_port(listener, source_object, out error);
	}

	public static bool AddInetPort(this GSocketListenerHandle listener, ushort port, GObjectHandle source_object, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_add_inet_port(listener, port, source_object, out error);
	}

	public static bool AddSocket(this GSocketListenerHandle listener, GSocketHandle socket, GObjectHandle source_object, out GErrorHandle error)
	{
		return GSocketListenerExterns.g_socket_listener_add_socket(listener, socket, source_object, out error);
	}

	public static GSocketListenerHandle Close(this GSocketListenerHandle listener)
	{
		GSocketListenerExterns.g_socket_listener_close(listener);
		return listener;
	}

	public static GSocketListenerHandle SetBacklog(this GSocketListenerHandle listener, int listen_backlog)
	{
		GSocketListenerExterns.g_socket_listener_set_backlog(listener, listen_backlog);
		return listener;
	}

}

internal class GSocketListenerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketListenerHandle g_socket_listener_new();

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_listener_accept(GSocketListenerHandle listener, out GObjectHandle source_object, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_listener_accept_async(GSocketListenerHandle listener, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_listener_accept_finish(GSocketListenerHandle listener, GAsyncResultHandle result, out GObjectHandle source_object, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketHandle g_socket_listener_accept_socket(GSocketListenerHandle listener, out GObjectHandle source_object, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_listener_accept_socket_async(GSocketListenerHandle listener, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketHandle g_socket_listener_accept_socket_finish(GSocketListenerHandle listener, GAsyncResultHandle result, out GObjectHandle source_object, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_listener_add_address(GSocketListenerHandle listener, GSocketAddressHandle address, GSocketType type, GSocketProtocol protocol, GObjectHandle source_object, out GSocketAddressHandle effective_address, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_socket_listener_add_any_inet_port(GSocketListenerHandle listener, GObjectHandle source_object, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_listener_add_inet_port(GSocketListenerHandle listener, ushort port, GObjectHandle source_object, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_listener_add_socket(GSocketListenerHandle listener, GSocketHandle socket, GObjectHandle source_object, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_listener_close(GSocketListenerHandle listener);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_listener_set_backlog(GSocketListenerHandle listener, int listen_backlog);

}
