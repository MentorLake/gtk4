namespace MentorLake.Gtk4.Gio;

public interface GSocketConnectableHandle
{
}

internal class GSocketConnectableHandleImpl : BaseSafeHandle, GSocketConnectableHandle
{
}

public static class GSocketConnectableHandleExtensions
{
	public static GSocketAddressEnumeratorHandle Enumerate(this GSocketConnectableHandle connectable)
	{
		return GSocketConnectableExterns.g_socket_connectable_enumerate(connectable);
	}

	public static GSocketAddressEnumeratorHandle ProxyEnumerate(this GSocketConnectableHandle connectable)
	{
		return GSocketConnectableExterns.g_socket_connectable_proxy_enumerate(connectable);
	}

	public static string ToString(this GSocketConnectableHandle connectable)
	{
		return GSocketConnectableExterns.g_socket_connectable_to_string(connectable);
	}

}

internal class GSocketConnectableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressEnumeratorHandle g_socket_connectable_enumerate(GSocketConnectableHandle connectable);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressEnumeratorHandle g_socket_connectable_proxy_enumerate(GSocketConnectableHandle connectable);

	[DllImport(Libraries.Gio)]
	internal static extern string g_socket_connectable_to_string(GSocketConnectableHandle connectable);

}
