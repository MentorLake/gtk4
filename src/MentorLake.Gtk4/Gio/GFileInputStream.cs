namespace MentorLake.Gtk4.Gio;

public class GFileInputStreamHandle : GInputStreamHandle, GSeekableHandle
{
}

public static class GFileInputStreamHandleExtensions
{
	public static GFileInfoHandle QueryInfo(this GFileInputStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileInputStreamExterns.g_file_input_stream_query_info(stream, attributes, cancellable, out error);
	}

	public static GFileInputStreamHandle QueryInfoAsync(this GFileInputStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileInputStreamExterns.g_file_input_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static GFileInfoHandle QueryInfoFinish(this GFileInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileInputStreamExterns.g_file_input_stream_query_info_finish(stream, result, out error);
	}

}

internal class GFileInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_input_stream_query_info(GFileInputStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_input_stream_query_info_async(GFileInputStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_input_stream_query_info_finish(GFileInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

}
