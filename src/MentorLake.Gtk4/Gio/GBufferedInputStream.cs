namespace MentorLake.Gtk4.Gio;

public class GBufferedInputStreamHandle : GFilterInputStreamHandle, GSeekableHandle
{
	public static GBufferedInputStreamHandle New(GInputStreamHandle base_stream)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_new(base_stream);
	}

	public static GBufferedInputStreamHandle NewSized(GInputStreamHandle base_stream, UIntPtr size)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedInputStreamHandleExtensions
{
	public static UIntPtr Fill(this GBufferedInputStreamHandle stream, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_fill(stream, count, cancellable, out error);
	}

	public static GBufferedInputStreamHandle FillAsync(this GBufferedInputStreamHandle stream, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GBufferedInputStreamExterns.g_buffered_input_stream_fill_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr FillFinish(this GBufferedInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_fill_finish(stream, result, out error);
	}

	public static UIntPtr GetAvailable(this GBufferedInputStreamHandle stream)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_get_available(stream);
	}

	public static UIntPtr GetBufferSize(this GBufferedInputStreamHandle stream)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_get_buffer_size(stream);
	}

	public static UIntPtr Peek(this GBufferedInputStreamHandle stream, IntPtr buffer, UIntPtr offset, UIntPtr count)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_peek(stream, buffer, offset, count);
	}

	public static IntPtr PeekBuffer(this GBufferedInputStreamHandle stream, out UIntPtr count)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_peek_buffer(stream, out count);
	}

	public static int ReadByte(this GBufferedInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GBufferedInputStreamExterns.g_buffered_input_stream_read_byte(stream, cancellable, out error);
	}

	public static GBufferedInputStreamHandle SetBufferSize(this GBufferedInputStreamHandle stream, UIntPtr size)
	{
		GBufferedInputStreamExterns.g_buffered_input_stream_set_buffer_size(stream, size);
		return stream;
	}

}

internal class GBufferedInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GBufferedInputStreamHandle g_buffered_input_stream_new(GInputStreamHandle base_stream);

	[DllImport(Libraries.Gio)]
	internal static extern GBufferedInputStreamHandle g_buffered_input_stream_new_sized(GInputStreamHandle base_stream, UIntPtr size);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_buffered_input_stream_fill(GBufferedInputStreamHandle stream, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_buffered_input_stream_fill_async(GBufferedInputStreamHandle stream, UIntPtr count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_buffered_input_stream_fill_finish(GBufferedInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_buffered_input_stream_get_available(GBufferedInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_buffered_input_stream_get_buffer_size(GBufferedInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_buffered_input_stream_peek(GBufferedInputStreamHandle stream, IntPtr buffer, UIntPtr offset, UIntPtr count);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_buffered_input_stream_peek_buffer(GBufferedInputStreamHandle stream, out UIntPtr count);

	[DllImport(Libraries.Gio)]
	internal static extern int g_buffered_input_stream_read_byte(GBufferedInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_buffered_input_stream_set_buffer_size(GBufferedInputStreamHandle stream, UIntPtr size);

}
