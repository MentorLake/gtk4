namespace MentorLake.Gtk4.Gio;

public class GDataOutputStreamHandle : GFilterOutputStreamHandle, GSeekableHandle
{
	public static GDataOutputStreamHandle New(GOutputStreamHandle base_stream)
	{
		return GDataOutputStreamExterns.g_data_output_stream_new(base_stream);
	}

}

public static class GDataOutputStreamHandleExtensions
{
	public static GDataStreamByteOrder GetByteOrder(this GDataOutputStreamHandle stream)
	{
		return GDataOutputStreamExterns.g_data_output_stream_get_byte_order(stream);
	}

	public static bool PutByte(this GDataOutputStreamHandle stream, char data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_byte(stream, data, cancellable, out error);
	}

	public static bool PutInt16(this GDataOutputStreamHandle stream, short data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_int16(stream, data, cancellable, out error);
	}

	public static bool PutInt32(this GDataOutputStreamHandle stream, int data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_int32(stream, data, cancellable, out error);
	}

	public static bool PutInt64(this GDataOutputStreamHandle stream, long data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_int64(stream, data, cancellable, out error);
	}

	public static bool PutString(this GDataOutputStreamHandle stream, string str, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_string(stream, str, cancellable, out error);
	}

	public static bool PutUint16(this GDataOutputStreamHandle stream, ushort data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_uint16(stream, data, cancellable, out error);
	}

	public static bool PutUint32(this GDataOutputStreamHandle stream, uint data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_uint32(stream, data, cancellable, out error);
	}

	public static bool PutUint64(this GDataOutputStreamHandle stream, ulong data, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDataOutputStreamExterns.g_data_output_stream_put_uint64(stream, data, cancellable, out error);
	}

	public static GDataOutputStreamHandle SetByteOrder(this GDataOutputStreamHandle stream, GDataStreamByteOrder order)
	{
		GDataOutputStreamExterns.g_data_output_stream_set_byte_order(stream, order);
		return stream;
	}

}

internal class GDataOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDataOutputStreamHandle g_data_output_stream_new(GOutputStreamHandle base_stream);

	[DllImport(Libraries.Gio)]
	internal static extern GDataStreamByteOrder g_data_output_stream_get_byte_order(GDataOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_byte(GDataOutputStreamHandle stream, char data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_int16(GDataOutputStreamHandle stream, short data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_int32(GDataOutputStreamHandle stream, int data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_int64(GDataOutputStreamHandle stream, long data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_string(GDataOutputStreamHandle stream, string str, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_uint16(GDataOutputStreamHandle stream, ushort data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_uint32(GDataOutputStreamHandle stream, uint data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_data_output_stream_put_uint64(GDataOutputStreamHandle stream, ulong data, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_data_output_stream_set_byte_order(GDataOutputStreamHandle stream, GDataStreamByteOrder order);

}
