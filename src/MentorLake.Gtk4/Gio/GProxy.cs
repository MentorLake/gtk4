namespace MentorLake.Gtk4.Gio;

public interface GProxyHandle
{
}

internal class GProxyHandleImpl : BaseSafeHandle, GProxyHandle
{
}

public static class GProxyHandleExtensions
{
	public static GIOStreamHandle Connect(this GProxyHandle proxy, GIOStreamHandle connection, GProxyAddressHandle proxy_address, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GProxyExterns.g_proxy_connect(proxy, connection, proxy_address, cancellable, out error);
	}

	public static GProxyHandle ConnectAsync(this GProxyHandle proxy, GIOStreamHandle connection, GProxyAddressHandle proxy_address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GProxyExterns.g_proxy_connect_async(proxy, connection, proxy_address, cancellable, callback, user_data);
		return proxy;
	}

	public static GIOStreamHandle ConnectFinish(this GProxyHandle proxy, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GProxyExterns.g_proxy_connect_finish(proxy, result, out error);
	}

	public static bool SupportsHostname(this GProxyHandle proxy)
	{
		return GProxyExterns.g_proxy_supports_hostname(proxy);
	}

}

internal class GProxyExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_proxy_connect(GProxyHandle proxy, GIOStreamHandle connection, GProxyAddressHandle proxy_address, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_proxy_connect_async(GProxyHandle proxy, GIOStreamHandle connection, GProxyAddressHandle proxy_address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_proxy_connect_finish(GProxyHandle proxy, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_proxy_supports_hostname(GProxyHandle proxy);

}
