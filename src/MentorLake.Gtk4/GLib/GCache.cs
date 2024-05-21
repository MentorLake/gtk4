namespace MentorLake.Gtk4.GLib;

public class GCacheHandle : BaseSafeHandle
{
}


public static class GCacheHandleExtensions
{
	public static GCacheHandle Destroy(this GCacheHandle cache)
	{
		GCacheExterns.g_cache_destroy(cache);
		return cache;
	}

	public static IntPtr Insert(this GCacheHandle cache, IntPtr key)
	{
		return GCacheExterns.g_cache_insert(cache, key);
	}

	public static GCacheHandle KeyForeach(this GCacheHandle cache, GHFunc func, IntPtr user_data)
	{
		GCacheExterns.g_cache_key_foreach(cache, func, user_data);
		return cache;
	}

	public static GCacheHandle Remove(this GCacheHandle cache, IntPtr value)
	{
		GCacheExterns.g_cache_remove(cache, value);
		return cache;
	}

	public static GCacheHandle ValueForeach(this GCacheHandle cache, GHFunc func, IntPtr user_data)
	{
		GCacheExterns.g_cache_value_foreach(cache, func, user_data);
		return cache;
	}

}
internal class GCacheExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_destroy(GCacheHandle cache);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_cache_insert(GCacheHandle cache, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_key_foreach(GCacheHandle cache, GHFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_remove(GCacheHandle cache, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_value_foreach(GCacheHandle cache, GHFunc func, IntPtr user_data);

}

public struct GCache
{
}
