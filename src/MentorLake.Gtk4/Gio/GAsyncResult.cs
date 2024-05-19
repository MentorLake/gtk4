namespace MentorLake.Gtk4.Gio;

public interface GAsyncResultHandle
{
}

internal class GAsyncResultHandleImpl : BaseSafeHandle, GAsyncResultHandle
{
}

public static class GAsyncResultHandleExtensions
{
	public static GObjectHandle GetSourceObject(this GAsyncResultHandle res)
	{
		return GAsyncResultExterns.g_async_result_get_source_object(res);
	}

	public static IntPtr GetUserData(this GAsyncResultHandle res)
	{
		return GAsyncResultExterns.g_async_result_get_user_data(res);
	}

	public static bool IsTagged(this GAsyncResultHandle res, IntPtr source_tag)
	{
		return GAsyncResultExterns.g_async_result_is_tagged(res, source_tag);
	}

	public static bool LegacyPropagateError(this GAsyncResultHandle res, out GErrorHandle error)
	{
		return GAsyncResultExterns.g_async_result_legacy_propagate_error(res, out error);
	}

}

internal class GAsyncResultExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_async_result_get_source_object(GAsyncResultHandle res);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_async_result_get_user_data(GAsyncResultHandle res);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_async_result_is_tagged(GAsyncResultHandle res, IntPtr source_tag);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_async_result_legacy_propagate_error(GAsyncResultHandle res, out GErrorHandle error);

}
