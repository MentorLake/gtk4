namespace MentorLake.Gtk4.GLib;

public class GIOChannelHandle : BaseSafeHandle
{
	public static GIOChannelHandle GIoChannelNewFile(string filename, string mode, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_new_file(filename, mode, out error);
	}

	public static GIOChannelHandle GIoChannelUnixNew(int fd)
	{
		return GIOChannelExterns.g_io_channel_unix_new(fd);
	}

}


public static class GIOChannelHandleExtensions
{
	public static GIOChannelHandle GIoChannelClose(this GIOChannelHandle channel)
	{
		GIOChannelExterns.g_io_channel_close(channel);
		return channel;
	}

	public static GIOStatus GIoChannelFlush(this GIOChannelHandle channel, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_flush(channel, out error);
	}

	public static GIOCondition GIoChannelGetBufferCondition(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_buffer_condition(channel);
	}

	public static UIntPtr GIoChannelGetBufferSize(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_buffer_size(channel);
	}

	public static bool GIoChannelGetBuffered(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_buffered(channel);
	}

	public static bool GIoChannelGetCloseOnUnref(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_close_on_unref(channel);
	}

	public static string GIoChannelGetEncoding(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_encoding(channel);
	}

	public static GIOFlags GIoChannelGetFlags(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_flags(channel);
	}

	public static string GIoChannelGetLineTerm(this GIOChannelHandle channel, out int length)
	{
		return GIOChannelExterns.g_io_channel_get_line_term(channel, out length);
	}

	public static GIOChannelHandle GIoChannelInit(this GIOChannelHandle channel)
	{
		GIOChannelExterns.g_io_channel_init(channel);
		return channel;
	}

	public static GIOError GIoChannelRead(this GIOChannelHandle channel, string buf, UIntPtr count, ref UIntPtr bytes_read)
	{
		return GIOChannelExterns.g_io_channel_read(channel, buf, count, ref bytes_read);
	}

	public static GIOStatus GIoChannelReadChars(this GIOChannelHandle channel, out string buf, UIntPtr count, out UIntPtr bytes_read, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_chars(channel, out buf, count, out bytes_read, out error);
	}

	public static GIOStatus GIoChannelReadLine(this GIOChannelHandle channel, out string str_return, out UIntPtr length, out UIntPtr terminator_pos, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_line(channel, out str_return, out length, out terminator_pos, out error);
	}

	public static GIOStatus GIoChannelReadLineString(this GIOChannelHandle channel, GStringHandle buffer, ref UIntPtr terminator_pos, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_line_string(channel, buffer, ref terminator_pos, out error);
	}

	public static GIOStatus GIoChannelReadToEnd(this GIOChannelHandle channel, out string str_return, out UIntPtr length, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_to_end(channel, out str_return, out length, out error);
	}

	public static GIOStatus GIoChannelReadUnichar(this GIOChannelHandle channel, out string thechar, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_unichar(channel, out thechar, out error);
	}

	public static GIOChannelHandle GIoChannelRef(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_ref(channel);
	}

	public static GIOError GIoChannelSeek(this GIOChannelHandle channel, long offset, GSeekType type)
	{
		return GIOChannelExterns.g_io_channel_seek(channel, offset, type);
	}

	public static GIOStatus GIoChannelSeekPosition(this GIOChannelHandle channel, long offset, GSeekType type, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_seek_position(channel, offset, type, out error);
	}

	public static GIOChannelHandle GIoChannelSetBufferSize(this GIOChannelHandle channel, UIntPtr size)
	{
		GIOChannelExterns.g_io_channel_set_buffer_size(channel, size);
		return channel;
	}

	public static GIOChannelHandle GIoChannelSetBuffered(this GIOChannelHandle channel, bool buffered)
	{
		GIOChannelExterns.g_io_channel_set_buffered(channel, buffered);
		return channel;
	}

	public static GIOChannelHandle GIoChannelSetCloseOnUnref(this GIOChannelHandle channel, bool do_close)
	{
		GIOChannelExterns.g_io_channel_set_close_on_unref(channel, do_close);
		return channel;
	}

	public static GIOStatus GIoChannelSetEncoding(this GIOChannelHandle channel, string encoding, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_set_encoding(channel, encoding, out error);
	}

	public static GIOStatus GIoChannelSetFlags(this GIOChannelHandle channel, GIOFlags flags, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_set_flags(channel, flags, out error);
	}

	public static GIOChannelHandle GIoChannelSetLineTerm(this GIOChannelHandle channel, string line_term, int length)
	{
		GIOChannelExterns.g_io_channel_set_line_term(channel, line_term, length);
		return channel;
	}

	public static GIOStatus GIoChannelShutdown(this GIOChannelHandle channel, bool flush, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_shutdown(channel, flush, out error);
	}

	public static int GIoChannelUnixGetFd(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_unix_get_fd(channel);
	}

	public static GIOChannelHandle GIoChannelUnref(this GIOChannelHandle channel)
	{
		GIOChannelExterns.g_io_channel_unref(channel);
		return channel;
	}

	public static GIOError GIoChannelWrite(this GIOChannelHandle channel, string buf, UIntPtr count, ref UIntPtr bytes_written)
	{
		return GIOChannelExterns.g_io_channel_write(channel, buf, count, ref bytes_written);
	}

	public static GIOStatus GIoChannelWriteChars(this GIOChannelHandle channel, string buf, UIntPtr count, out UIntPtr bytes_written, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_write_chars(channel, buf, count, out bytes_written, out error);
	}

	public static GIOStatus GIoChannelWriteUnichar(this GIOChannelHandle channel, char thechar, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_write_unichar(channel, thechar, out error);
	}

}
internal class GIOChannelExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GIOChannelHandle g_io_channel_new_file(string filename, string mode, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOChannelHandle g_io_channel_unix_new(int fd);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_close(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_flush(GIOChannelHandle channel, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOCondition g_io_channel_get_buffer_condition(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_io_channel_get_buffer_size(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_io_channel_get_buffered(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_io_channel_get_close_on_unref(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern string g_io_channel_get_encoding(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern GIOFlags g_io_channel_get_flags(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern string g_io_channel_get_line_term(GIOChannelHandle channel, out int length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_init(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern GIOError g_io_channel_read(GIOChannelHandle channel, string buf, UIntPtr count, ref UIntPtr bytes_read);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_read_chars(GIOChannelHandle channel, out string buf, UIntPtr count, out UIntPtr bytes_read, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_read_line(GIOChannelHandle channel, out string str_return, out UIntPtr length, out UIntPtr terminator_pos, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_read_line_string(GIOChannelHandle channel, GStringHandle buffer, ref UIntPtr terminator_pos, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_read_to_end(GIOChannelHandle channel, out string str_return, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_read_unichar(GIOChannelHandle channel, out string thechar, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOChannelHandle g_io_channel_ref(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern GIOError g_io_channel_seek(GIOChannelHandle channel, long offset, GSeekType type);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_seek_position(GIOChannelHandle channel, long offset, GSeekType type, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_set_buffer_size(GIOChannelHandle channel, UIntPtr size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_set_buffered(GIOChannelHandle channel, bool buffered);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_set_close_on_unref(GIOChannelHandle channel, bool do_close);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_set_encoding(GIOChannelHandle channel, string encoding, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_set_flags(GIOChannelHandle channel, GIOFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_set_line_term(GIOChannelHandle channel, string line_term, int length);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_shutdown(GIOChannelHandle channel, bool flush, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_io_channel_unix_get_fd(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern void g_io_channel_unref(GIOChannelHandle channel);

	[DllImport(Libraries.GLib)]
	internal static extern GIOError g_io_channel_write(GIOChannelHandle channel, string buf, UIntPtr count, ref UIntPtr bytes_written);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_write_chars(GIOChannelHandle channel, string buf, UIntPtr count, out UIntPtr bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOStatus g_io_channel_write_unichar(GIOChannelHandle channel, char thechar, out GErrorHandle error);

}

public struct GIOChannel
{
}
