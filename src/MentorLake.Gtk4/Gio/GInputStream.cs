namespace MentorLake.Gtk4.Gio;

public class GInputStreamHandle : GObjectHandle
{
}

public static class GInputStreamHandleExtensions
{
	public static GInputStreamHandle ClearPending(this GInputStreamHandle stream)
	{
		GInputStreamExterns.g_input_stream_clear_pending(stream);
		return stream;
	}

	public static bool Close(this GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_close(stream, cancellable, out error);
	}

	public static GInputStreamHandle CloseAsync(this GInputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GInputStreamExterns.g_input_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool CloseFinish(this GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_close_finish(stream, result, out error);
	}

	public static bool HasPending(this GInputStreamHandle stream)
	{
		return GInputStreamExterns.g_input_stream_has_pending(stream);
	}

	public static bool IsClosed(this GInputStreamHandle stream)
	{
		return GInputStreamExterns.g_input_stream_is_closed(stream);
	}

	public static UIntPtr Read(this GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_read(stream, out buffer, count, cancellable, out error);
	}

	public static bool ReadAll(this GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, out UIntPtr bytes_read, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_read_all(stream, out buffer, count, out bytes_read, cancellable, out error);
	}

	public static GInputStreamHandle ReadAllAsync(this GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GInputStreamExterns.g_input_stream_read_all_async(stream, out buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool ReadAllFinish(this GInputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_read, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_read_all_finish(stream, result, out bytes_read, out error);
	}

	public static GInputStreamHandle ReadAsync(this GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GInputStreamExterns.g_input_stream_read_async(stream, out buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static GBytesHandle ReadBytes(this GInputStreamHandle stream, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_read_bytes(stream, count, cancellable, out error);
	}

	public static GInputStreamHandle ReadBytesAsync(this GInputStreamHandle stream, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GInputStreamExterns.g_input_stream_read_bytes_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static GBytesHandle ReadBytesFinish(this GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_read_bytes_finish(stream, result, out error);
	}

	public static UIntPtr ReadFinish(this GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_read_finish(stream, result, out error);
	}

	public static bool SetPending(this GInputStreamHandle stream, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_set_pending(stream, out error);
	}

	public static UIntPtr Skip(this GInputStreamHandle stream, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_skip(stream, count, cancellable, out error);
	}

	public static GInputStreamHandle SkipAsync(this GInputStreamHandle stream, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GInputStreamExterns.g_input_stream_skip_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr SkipFinish(this GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GInputStreamExterns.g_input_stream_skip_finish(stream, result, out error);
	}

	public static UIntPtr GPollableStreamRead(this GInputStreamHandle stream, IntPtr buffer, UIntPtr count, bool blocking, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInputStreamExterns.g_pollable_stream_read(stream, buffer, count, blocking, cancellable, out error);
	}

}

internal class GInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_input_stream_clear_pending(GInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_close(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_input_stream_close_async(GInputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_close_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_has_pending(GInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_is_closed(GInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_input_stream_read(GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_read_all(GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, out UIntPtr bytes_read, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_input_stream_read_all_async(GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_read_all_finish(GInputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_read, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_input_stream_read_async(GInputStreamHandle stream, out IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_input_stream_read_bytes(GInputStreamHandle stream, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_input_stream_read_bytes_async(GInputStreamHandle stream, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_input_stream_read_bytes_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_input_stream_read_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_input_stream_set_pending(GInputStreamHandle stream, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_input_stream_skip(GInputStreamHandle stream, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_input_stream_skip_async(GInputStreamHandle stream, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_input_stream_skip_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_pollable_stream_read(GInputStreamHandle stream, IntPtr buffer, UIntPtr count, bool blocking, GCancellableHandle cancellable, out GErrorHandle error);

}
