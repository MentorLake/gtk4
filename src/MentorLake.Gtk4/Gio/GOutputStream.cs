namespace MentorLake.Gtk4.Gio;

public class GOutputStreamHandle : GObjectHandle
{
}

public static class GOutputStreamHandleExtensions
{
	public static GOutputStreamHandle ClearPending(this GOutputStreamHandle stream)
	{
		GOutputStreamExterns.g_output_stream_clear_pending(stream);
		return stream;
	}

	public static bool Close(this GOutputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_close(stream, cancellable, out error);
	}

	public static GOutputStreamHandle CloseAsync(this GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool CloseFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_close_finish(stream, result, out error);
	}

	public static bool Flush(this GOutputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_flush(stream, cancellable, out error);
	}

	public static GOutputStreamHandle FlushAsync(this GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_flush_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool FlushFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_flush_finish(stream, result, out error);
	}

	public static bool HasPending(this GOutputStreamHandle stream)
	{
		return GOutputStreamExterns.g_output_stream_has_pending(stream);
	}

	public static bool IsClosed(this GOutputStreamHandle stream)
	{
		return GOutputStreamExterns.g_output_stream_is_closed(stream);
	}

	public static bool IsClosing(this GOutputStreamHandle stream)
	{
		return GOutputStreamExterns.g_output_stream_is_closing(stream);
	}

	public static bool Printf(this GOutputStreamHandle stream, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error, string format, IntPtr @__arglist)
	{
		return GOutputStreamExterns.g_output_stream_printf(stream, out bytes_written, cancellable, out error, format, @__arglist);
	}

	public static bool SetPending(this GOutputStreamHandle stream, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_set_pending(stream, out error);
	}

	public static UIntPtr Splice(this GOutputStreamHandle stream, GInputStreamHandle source, GOutputStreamSpliceFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_splice(stream, source, flags, cancellable, out error);
	}

	public static GOutputStreamHandle SpliceAsync(this GOutputStreamHandle stream, GInputStreamHandle source, GOutputStreamSpliceFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_splice_async(stream, source, flags, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr SpliceFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_splice_finish(stream, result, out error);
	}

	public static bool Vprintf(this GOutputStreamHandle stream, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error, string format, IntPtr args)
	{
		return GOutputStreamExterns.g_output_stream_vprintf(stream, out bytes_written, cancellable, out error, format, args);
	}

	public static UIntPtr Write(this GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_write(stream, buffer, count, cancellable, out error);
	}

	public static bool WriteAll(this GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_write_all(stream, buffer, count, out bytes_written, cancellable, out error);
	}

	public static GOutputStreamHandle WriteAllAsync(this GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_write_all_async(stream, buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool WriteAllFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_written, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_write_all_finish(stream, result, out bytes_written, out error);
	}

	public static GOutputStreamHandle WriteAsync(this GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_write_async(stream, buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr WriteBytes(this GOutputStreamHandle stream, GBytesHandle bytes, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_write_bytes(stream, bytes, cancellable, out error);
	}

	public static GOutputStreamHandle WriteBytesAsync(this GOutputStreamHandle stream, GBytesHandle bytes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_write_bytes_async(stream, bytes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr WriteBytesFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_write_bytes_finish(stream, result, out error);
	}

	public static UIntPtr WriteFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_write_finish(stream, result, out error);
	}

	public static bool Writev(this GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_writev(stream, vectors, n_vectors, out bytes_written, cancellable, out error);
	}

	public static bool WritevAll(this GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_writev_all(stream, vectors, n_vectors, out bytes_written, cancellable, out error);
	}

	public static GOutputStreamHandle WritevAllAsync(this GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_writev_all_async(stream, vectors, n_vectors, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool WritevAllFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_written, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_writev_all_finish(stream, result, out bytes_written, out error);
	}

	public static GOutputStreamHandle WritevAsync(this GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GOutputStreamExterns.g_output_stream_writev_async(stream, vectors, n_vectors, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool WritevFinish(this GOutputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_written, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_output_stream_writev_finish(stream, result, out bytes_written, out error);
	}

	public static UIntPtr GPollableStreamWrite(this GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, bool blocking, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_pollable_stream_write(stream, buffer, count, blocking, cancellable, out error);
	}

	public static bool GPollableStreamWriteAll(this GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GOutputStreamExterns.g_pollable_stream_write_all(stream, buffer, count, blocking, out bytes_written, cancellable, out error);
	}

}

internal class GOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_clear_pending(GOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_close(GOutputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_close_async(GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_close_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_flush(GOutputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_flush_async(GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_flush_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_has_pending(GOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_is_closed(GOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_is_closing(GOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_printf(GOutputStreamHandle stream, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_set_pending(GOutputStreamHandle stream, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_output_stream_splice(GOutputStreamHandle stream, GInputStreamHandle source, GOutputStreamSpliceFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_splice_async(GOutputStreamHandle stream, GInputStreamHandle source, GOutputStreamSpliceFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_output_stream_splice_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_vprintf(GOutputStreamHandle stream, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error, string format, IntPtr args);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_output_stream_write(GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_write_all(GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_write_all_async(GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_write_all_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_written, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_write_async(GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_output_stream_write_bytes(GOutputStreamHandle stream, GBytesHandle bytes, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_write_bytes_async(GOutputStreamHandle stream, GBytesHandle bytes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_output_stream_write_bytes_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_output_stream_write_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_writev(GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_writev_all(GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_writev_all_async(GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_writev_all_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_written, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_output_stream_writev_async(GOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_output_stream_writev_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out UIntPtr bytes_written, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_pollable_stream_write(GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, bool blocking, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_stream_write_all(GOutputStreamHandle stream, IntPtr buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error);

}
