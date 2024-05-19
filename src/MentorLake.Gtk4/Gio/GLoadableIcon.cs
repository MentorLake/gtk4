namespace MentorLake.Gtk4.Gio;

public interface GLoadableIconHandle
{
}

internal class GLoadableIconHandleImpl : BaseSafeHandle, GLoadableIconHandle
{
}

public static class GLoadableIconHandleExtensions
{
	public static GInputStreamHandle Load(this GLoadableIconHandle icon, int size, out string type, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GLoadableIconExterns.g_loadable_icon_load(icon, size, out type, cancellable, out error);
	}

	public static GLoadableIconHandle LoadAsync(this GLoadableIconHandle icon, int size, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GLoadableIconExterns.g_loadable_icon_load_async(icon, size, cancellable, callback, user_data);
		return icon;
	}

	public static GInputStreamHandle LoadFinish(this GLoadableIconHandle icon, GAsyncResultHandle res, out string type, out GErrorHandle error)
	{
		return GLoadableIconExterns.g_loadable_icon_load_finish(icon, res, out type, out error);
	}

}

internal class GLoadableIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_loadable_icon_load(GLoadableIconHandle icon, int size, out string type, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_loadable_icon_load_async(GLoadableIconHandle icon, int size, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_loadable_icon_load_finish(GLoadableIconHandle icon, GAsyncResultHandle res, out string type, out GErrorHandle error);

}
