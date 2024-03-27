using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GSocketHandle : GObjectHandle
{
	public static GSocketHandle New(GSocketFamily family, GSocketType type, GSocketProtocol protocol, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_new(family, type, protocol, out error);
	}
	public static GSocketHandle NewFromFd(int fd, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_new_from_fd(fd, out error);
	}
}

public static class GSocketSignals
{
}

public static class GSocketHandleExtensions
{
	public static GSocketHandle Accept(this GSocketHandle socket, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_accept(socket, cancellable, out error);
	}

	public static bool Bind(this GSocketHandle socket, GSocketAddressHandle address, bool allow_reuse, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_bind(socket, address, allow_reuse, out error);
	}

	public static bool CheckConnectResult(this GSocketHandle socket, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_check_connect_result(socket, out error);
	}

	public static bool Close(this GSocketHandle socket, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_close(socket, out error);
	}

	public static GIOCondition ConditionCheck(this GSocketHandle socket, GIOCondition condition)
	{
		return GSocketExterns.g_socket_condition_check(socket, condition);
	}

	public static bool ConditionTimedWait(this GSocketHandle socket, GIOCondition condition, long timeout_us, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_condition_timed_wait(socket, condition, timeout_us, cancellable, out error);
	}

	public static bool ConditionWait(this GSocketHandle socket, GIOCondition condition, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_condition_wait(socket, condition, cancellable, out error);
	}

	public static bool Connect(this GSocketHandle socket, GSocketAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_connect(socket, address, cancellable, out error);
	}

	public static GSocketConnectionHandle ConnectionFactoryCreateConnection(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_connection_factory_create_connection(socket);
	}

	public static GSourceHandle CreateSource(this GSocketHandle socket, GIOCondition condition, GCancellableHandle cancellable)
	{
		return GSocketExterns.g_socket_create_source(socket, condition, cancellable);
	}

	public static int GetAvailableBytes(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_available_bytes(socket);
	}

	public static bool GetBlocking(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_blocking(socket);
	}

	public static bool GetBroadcast(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_broadcast(socket);
	}

	public static GCredentialsHandle GetCredentials(this GSocketHandle socket, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_get_credentials(socket, out error);
	}

	public static GSocketFamily GetFamily(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_family(socket);
	}

	public static int GetFd(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_fd(socket);
	}

	public static bool GetKeepalive(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_keepalive(socket);
	}

	public static int GetListenBacklog(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_listen_backlog(socket);
	}

	public static GSocketAddressHandle GetLocalAddress(this GSocketHandle socket, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_get_local_address(socket, out error);
	}

	public static bool GetMulticastLoopback(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_multicast_loopback(socket);
	}

	public static uint GetMulticastTtl(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_multicast_ttl(socket);
	}

	public static bool GetOption(this GSocketHandle socket, int level, int optname, out int value, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_get_option(socket, level, optname, out value, out error);
	}

	public static GSocketProtocol GetProtocol(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_protocol(socket);
	}

	public static GSocketAddressHandle GetRemoteAddress(this GSocketHandle socket, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_get_remote_address(socket, out error);
	}

	public static GSocketType GetSocketType(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_socket_type(socket);
	}

	public static uint GetTimeout(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_timeout(socket);
	}

	public static uint GetTtl(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_get_ttl(socket);
	}

	public static bool IsClosed(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_is_closed(socket);
	}

	public static bool IsConnected(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_is_connected(socket);
	}

	public static bool JoinMulticastGroup(this GSocketHandle socket, GInetAddressHandle group, bool source_specific, string iface, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_join_multicast_group(socket, group, source_specific, iface, out error);
	}

	public static bool JoinMulticastGroupSsm(this GSocketHandle socket, GInetAddressHandle group, GInetAddressHandle source_specific, string iface, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_join_multicast_group_ssm(socket, group, source_specific, iface, out error);
	}

	public static bool LeaveMulticastGroup(this GSocketHandle socket, GInetAddressHandle group, bool source_specific, string iface, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_leave_multicast_group(socket, group, source_specific, iface, out error);
	}

	public static bool LeaveMulticastGroupSsm(this GSocketHandle socket, GInetAddressHandle group, GInetAddressHandle source_specific, string iface, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_leave_multicast_group_ssm(socket, group, source_specific, iface, out error);
	}

	public static bool Listen(this GSocketHandle socket, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_listen(socket, out error);
	}

	public static int Receive(this GSocketHandle socket, out string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive(socket, out buffer, size, cancellable, out error);
	}

	public static GBytesHandle ReceiveBytes(this GSocketHandle socket, int size, long timeout_us, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive_bytes(socket, size, timeout_us, cancellable, out error);
	}

	public static GBytesHandle ReceiveBytesFrom(this GSocketHandle socket, out GSocketAddressHandle address, int size, long timeout_us, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive_bytes_from(socket, out address, size, timeout_us, cancellable, out error);
	}

	public static int ReceiveFrom(this GSocketHandle socket, out GSocketAddressHandle address, out string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive_from(socket, out address, out buffer, size, cancellable, out error);
	}

	public static int ReceiveMessage(this GSocketHandle socket, out GSocketAddressHandle address, GInputVector[] vectors, int num_vectors, out GSocketControlMessageHandle[] messages, out int num_messages, ref int flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive_message(socket, out address, vectors, num_vectors, out messages, out num_messages, ref flags, cancellable, out error);
	}

	public static int ReceiveMessages(this GSocketHandle socket, GInputMessage[] messages, uint num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive_messages(socket, messages, num_messages, flags, cancellable, out error);
	}

	public static int ReceiveWithBlocking(this GSocketHandle socket, out string buffer, int size, bool blocking, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_receive_with_blocking(socket, out buffer, size, blocking, cancellable, out error);
	}

	public static int Send(this GSocketHandle socket, string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_send(socket, buffer, size, cancellable, out error);
	}

	public static int SendMessage(this GSocketHandle socket, GSocketAddressHandle address, GOutputVector[] vectors, int num_vectors, GSocketControlMessageHandle[] messages, int num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_send_message(socket, address, vectors, num_vectors, messages, num_messages, flags, cancellable, out error);
	}

	public static GPollableReturn SendMessageWithTimeout(this GSocketHandle socket, GSocketAddressHandle address, GOutputVector[] vectors, int num_vectors, GSocketControlMessageHandle[] messages, int num_messages, int flags, long timeout_us, out int bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_send_message_with_timeout(socket, address, vectors, num_vectors, messages, num_messages, flags, timeout_us, out bytes_written, cancellable, out error);
	}

	public static int SendMessages(this GSocketHandle socket, GOutputMessage[] messages, uint num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_send_messages(socket, messages, num_messages, flags, cancellable, out error);
	}

	public static int SendTo(this GSocketHandle socket, GSocketAddressHandle address, string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_send_to(socket, address, buffer, size, cancellable, out error);
	}

	public static int SendWithBlocking(this GSocketHandle socket, string buffer, int size, bool blocking, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_send_with_blocking(socket, buffer, size, blocking, cancellable, out error);
	}

	public static GSocketHandle SetBlocking(this GSocketHandle socket, bool blocking)
	{
		GSocketExterns.g_socket_set_blocking(socket, blocking);
		return socket;
	}

	public static GSocketHandle SetBroadcast(this GSocketHandle socket, bool broadcast)
	{
		GSocketExterns.g_socket_set_broadcast(socket, broadcast);
		return socket;
	}

	public static GSocketHandle SetKeepalive(this GSocketHandle socket, bool keepalive)
	{
		GSocketExterns.g_socket_set_keepalive(socket, keepalive);
		return socket;
	}

	public static GSocketHandle SetListenBacklog(this GSocketHandle socket, int backlog)
	{
		GSocketExterns.g_socket_set_listen_backlog(socket, backlog);
		return socket;
	}

	public static GSocketHandle SetMulticastLoopback(this GSocketHandle socket, bool loopback)
	{
		GSocketExterns.g_socket_set_multicast_loopback(socket, loopback);
		return socket;
	}

	public static GSocketHandle SetMulticastTtl(this GSocketHandle socket, uint ttl)
	{
		GSocketExterns.g_socket_set_multicast_ttl(socket, ttl);
		return socket;
	}

	public static bool SetOption(this GSocketHandle socket, int level, int optname, int value, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_set_option(socket, level, optname, value, out error);
	}

	public static GSocketHandle SetTimeout(this GSocketHandle socket, uint timeout)
	{
		GSocketExterns.g_socket_set_timeout(socket, timeout);
		return socket;
	}

	public static GSocketHandle SetTtl(this GSocketHandle socket, uint ttl)
	{
		GSocketExterns.g_socket_set_ttl(socket, ttl);
		return socket;
	}

	public static bool Shutdown(this GSocketHandle socket, bool shutdown_read, bool shutdown_write, out GErrorHandle error)
	{
		return GSocketExterns.g_socket_shutdown(socket, shutdown_read, shutdown_write, out error);
	}

	public static bool SpeaksIpv4(this GSocketHandle socket)
	{
		return GSocketExterns.g_socket_speaks_ipv4(socket);
	}

}

internal class GSocketExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketHandle g_socket_accept(GSocketHandle socket, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_bind(GSocketHandle socket, GSocketAddressHandle address, bool allow_reuse, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_check_connect_result(GSocketHandle socket, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_close(GSocketHandle socket, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GIOCondition g_socket_condition_check(GSocketHandle socket, GIOCondition condition);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_condition_timed_wait(GSocketHandle socket, GIOCondition condition, long timeout_us, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_condition_wait(GSocketHandle socket, GIOCondition condition, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_connect(GSocketHandle socket, GSocketAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectionHandle g_socket_connection_factory_create_connection(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_socket_create_source(GSocketHandle socket, GIOCondition condition, GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_get_available_bytes(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_get_blocking(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_get_broadcast(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_socket_get_credentials(GSocketHandle socket, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketFamily g_socket_get_family(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_get_fd(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_get_keepalive(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_get_listen_backlog(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_get_local_address(GSocketHandle socket, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_get_multicast_loopback(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_socket_get_multicast_ttl(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_get_option(GSocketHandle socket, int level, int optname, out int value, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketProtocol g_socket_get_protocol(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_get_remote_address(GSocketHandle socket, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketType g_socket_get_socket_type(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_socket_get_timeout(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_socket_get_ttl(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_is_closed(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_is_connected(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_join_multicast_group(GSocketHandle socket, GInetAddressHandle group, bool source_specific, string iface, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_join_multicast_group_ssm(GSocketHandle socket, GInetAddressHandle group, GInetAddressHandle source_specific, string iface, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_leave_multicast_group(GSocketHandle socket, GInetAddressHandle group, bool source_specific, string iface, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_leave_multicast_group_ssm(GSocketHandle socket, GInetAddressHandle group, GInetAddressHandle source_specific, string iface, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_listen(GSocketHandle socket, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_receive(GSocketHandle socket, out string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_socket_receive_bytes(GSocketHandle socket, int size, long timeout_us, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_socket_receive_bytes_from(GSocketHandle socket, out GSocketAddressHandle address, int size, long timeout_us, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_receive_from(GSocketHandle socket, out GSocketAddressHandle address, out string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_receive_message(GSocketHandle socket, out GSocketAddressHandle address, GInputVector[] vectors, int num_vectors, out GSocketControlMessageHandle[] messages, out int num_messages, ref int flags, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_receive_messages(GSocketHandle socket, GInputMessage[] messages, uint num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_receive_with_blocking(GSocketHandle socket, out string buffer, int size, bool blocking, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_send(GSocketHandle socket, string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_send_message(GSocketHandle socket, GSocketAddressHandle address, GOutputVector[] vectors, int num_vectors, GSocketControlMessageHandle[] messages, int num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GPollableReturn g_socket_send_message_with_timeout(GSocketHandle socket, GSocketAddressHandle address, GOutputVector[] vectors, int num_vectors, GSocketControlMessageHandle[] messages, int num_messages, int flags, long timeout_us, out int bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_send_messages(GSocketHandle socket, GOutputMessage[] messages, uint num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_send_to(GSocketHandle socket, GSocketAddressHandle address, string buffer, int size, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_send_with_blocking(GSocketHandle socket, string buffer, int size, bool blocking, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_blocking(GSocketHandle socket, bool blocking);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_broadcast(GSocketHandle socket, bool broadcast);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_keepalive(GSocketHandle socket, bool keepalive);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_listen_backlog(GSocketHandle socket, int backlog);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_multicast_loopback(GSocketHandle socket, bool loopback);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_multicast_ttl(GSocketHandle socket, uint ttl);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_set_option(GSocketHandle socket, int level, int optname, int value, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_timeout(GSocketHandle socket, uint timeout);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_set_ttl(GSocketHandle socket, uint ttl);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_shutdown(GSocketHandle socket, bool shutdown_read, bool shutdown_write, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_speaks_ipv4(GSocketHandle socket);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketHandle g_socket_new(GSocketFamily family, GSocketType type, GSocketProtocol protocol, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketHandle g_socket_new_from_fd(int fd, out GErrorHandle error);
}
