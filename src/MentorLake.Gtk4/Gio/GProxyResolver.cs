namespace MentorLake.Gtk4.Gio;

public interface GProxyResolverHandle
{
}

internal class GProxyResolverHandleImpl : BaseSafeHandle, GProxyResolverHandle
{
}

public static class GProxyResolverHandleExtensions
{
	public static bool IsSupported(this GProxyResolverHandle resolver)
	{
		return GProxyResolverExterns.g_proxy_resolver_is_supported(resolver);
	}

	public static string[] Lookup(this GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GProxyResolverExterns.g_proxy_resolver_lookup(resolver, uri, cancellable, out error);
	}

	public static GProxyResolverHandle LookupAsync(this GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GProxyResolverExterns.g_proxy_resolver_lookup_async(resolver, uri, cancellable, callback, user_data);
		return resolver;
	}

	public static string[] LookupFinish(this GProxyResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GProxyResolverExterns.g_proxy_resolver_lookup_finish(resolver, result, out error);
	}

}

internal class GProxyResolverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_proxy_resolver_is_supported(GProxyResolverHandle resolver);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_proxy_resolver_lookup(GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_proxy_resolver_lookup_async(GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_proxy_resolver_lookup_finish(GProxyResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);

}
