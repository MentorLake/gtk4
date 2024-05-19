namespace MentorLake.Gtk4.Gio;

public class GDataInputStreamHandle : GBufferedInputStreamHandle, GSeekableHandle
{
	public static GDataInputStreamHandle New(GInputStreamHandle base_stream)
	{
		return GDataInputStreamExterns.g_data_input_stream_new(base_stream);
	}

}

public static class GDataInputStreamHandleExtensions
{
	public static GDataStreamByteOrder GetByteOrder(this GDataInputStreamHandle stream)
	{
		return GDataInputStreamExterns.g_data_input_stream_get_byte_order(stream);
	}

	public static GDataStreamNewlineType GetNewlineType(this GDataInputStreamHandle stream)
	{
		return GDataInputStreamExterns.g_data_input_stream_get_newline_type(stream);
	}

	public static char ReadByte(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_byte(stream, cancellable, out error);
	}

	public static short ReadInt16(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_int16(stream, cancellable, out error);
	}

	public static int ReadInt32(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_int32(stream, cancellable, out error);
	}

	public static long ReadInt64(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_int64(stream, cancellable, out error);
	}

	public static string ReadLine(this GDataInputStreamHandle stream, out int length, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_line(stream, out length, cancellable, out error);
	}

	public static GDataInputStreamHandle ReadLineAsync(this GDataInputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDataInputStreamExterns.g_data_input_stream_read_line_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static string ReadLineFinish(this GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_line_finish(stream, result, out length, out error);
	}

	public static string ReadLineFinishUtf8(this GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_line_finish_utf8(stream, result, out length, out error);
	}

	public static string ReadLineUtf8(this GDataInputStreamHandle stream, out int length, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_line_utf8(stream, out length, cancellable, out error);
	}

	public static ushort ReadUint16(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_uint16(stream, cancellable, out error);
	}

	public static uint ReadUint32(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_uint32(stream, cancellable, out error);
	}

	public static ulong ReadUint64(this GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_uint64(stream, cancellable, out error);
	}

	public static string ReadUntil(this GDataInputStreamHandle stream, string stop_chars, out int length, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_until(stream, stop_chars, out length, cancellable, out error);
	}

	public static GDataInputStreamHandle ReadUntilAsync(this GDataInputStreamHandle stream, string stop_chars, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDataInputStreamExterns.g_data_input_stream_read_until_async(stream, stop_chars, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static string ReadUntilFinish(this GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_until_finish(stream, result, out length, out error);
	}

	public static string ReadUpto(this GDataInputStreamHandle stream, string stop_chars, int stop_chars_len, out int length, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_upto(stream, stop_chars, stop_chars_len, out length, cancellable, out error);
	}

	public static GDataInputStreamHandle ReadUptoAsync(this GDataInputStreamHandle stream, string stop_chars, int stop_chars_len, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDataInputStreamExterns.g_data_input_stream_read_upto_async(stream, stop_chars, stop_chars_len, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static string ReadUptoFinish(this GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error)
	{
		return GDataInputStreamExterns.g_data_input_stream_read_upto_finish(stream, result, out length, out error);
	}

	public static GDataInputStreamHandle SetByteOrder(this GDataInputStreamHandle stream, GDataStreamByteOrder order)
	{
		GDataInputStreamExterns.g_data_input_stream_set_byte_order(stream, order);
		return stream;
	}

	public static GDataInputStreamHandle SetNewlineType(this GDataInputStreamHandle stream, GDataStreamNewlineType type)
	{
		GDataInputStreamExterns.g_data_input_stream_set_newline_type(stream, type);
		return stream;
	}

}

internal class GDataInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDataInputStreamHandle g_data_input_stream_new(GInputStreamHandle base_stream);

	[DllImport(Libraries.Gio)]
	internal static extern GDataStreamByteOrder g_data_input_stream_get_byte_order(GDataInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern GDataStreamNewlineType g_data_input_stream_get_newline_type(GDataInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern char g_data_input_stream_read_byte(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern short g_data_input_stream_read_int16(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern int g_data_input_stream_read_int32(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern long g_data_input_stream_read_int64(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_line(GDataInputStreamHandle stream, out int length, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_data_input_stream_read_line_async(GDataInputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_line_finish(GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_line_finish_utf8(GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_line_utf8(GDataInputStreamHandle stream, out int length, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_data_input_stream_read_uint16(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_data_input_stream_read_uint32(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern ulong g_data_input_stream_read_uint64(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_until(GDataInputStreamHandle stream, string stop_chars, out int length, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_data_input_stream_read_until_async(GDataInputStreamHandle stream, string stop_chars, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_until_finish(GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_upto(GDataInputStreamHandle stream, string stop_chars, int stop_chars_len, out int length, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_data_input_stream_read_upto_async(GDataInputStreamHandle stream, string stop_chars, int stop_chars_len, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern string g_data_input_stream_read_upto_finish(GDataInputStreamHandle stream, GAsyncResultHandle result, out int length, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_data_input_stream_set_byte_order(GDataInputStreamHandle stream, GDataStreamByteOrder order);

	[DllImport(Libraries.Gio)]
	internal static extern void g_data_input_stream_set_newline_type(GDataInputStreamHandle stream, GDataStreamNewlineType type);

}
