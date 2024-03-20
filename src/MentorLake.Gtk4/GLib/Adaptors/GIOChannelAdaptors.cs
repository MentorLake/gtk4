using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GIOChannelAdaptors
{
	public static GIOChannelHandle GIoChannelInit(this GIOChannelHandle channel)
	{
		GIOChannelExterns.g_io_channel_init(channel);
		return channel;
	}

	public static GIOChannelHandle GIoChannelRef(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_ref(channel);
	}

	public static GIOChannelHandle GIoChannelUnref(this GIOChannelHandle channel)
	{
		GIOChannelExterns.g_io_channel_unref(channel);
		return channel;
	}

	public static GIOError GIoChannelRead(this GIOChannelHandle channel, string buf, nuint count, out nuint bytes_read)
	{
		return GIOChannelExterns.g_io_channel_read(channel, buf, count, out bytes_read);
	}

	public static GIOError GIoChannelWrite(this GIOChannelHandle channel, string buf, nuint count, out nuint bytes_written)
	{
		return GIOChannelExterns.g_io_channel_write(channel, buf, count, out bytes_written);
	}

	public static GIOError GIoChannelSeek(this GIOChannelHandle channel, nint offset, GSeekType type)
	{
		return GIOChannelExterns.g_io_channel_seek(channel, offset, type);
	}

	public static GIOChannelHandle GIoChannelClose(this GIOChannelHandle channel)
	{
		GIOChannelExterns.g_io_channel_close(channel);
		return channel;
	}

	public static GIOStatus GIoChannelShutdown(this GIOChannelHandle channel, int flush, out GErrorHandle err)
	{
		return GIOChannelExterns.g_io_channel_shutdown(channel, flush, out err);
	}

	public static uint GIoAddWatchFull(this GIOChannelHandle channel, int priority, GIOCondition condition, GIOFunc func, IntPtr user_data, GDestroyNotify notify)
	{
		return GIOChannelExterns.g_io_add_watch_full(channel, priority, condition, func, user_data, notify);
	}

	public static GSourceHandle GIoCreateWatch(this GIOChannelHandle channel, GIOCondition condition)
	{
		return GIOChannelExterns.g_io_create_watch(channel, condition);
	}

	public static uint GIoAddWatch(this GIOChannelHandle channel, GIOCondition condition, GIOFunc func, IntPtr user_data)
	{
		return GIOChannelExterns.g_io_add_watch(channel, condition, func, user_data);
	}

	public static GIOChannelHandle GIoChannelSetBufferSize(this GIOChannelHandle channel, nuint size)
	{
		GIOChannelExterns.g_io_channel_set_buffer_size(channel, size);
		return channel;
	}

	public static nuint GIoChannelGetBufferSize(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_buffer_size(channel);
	}

	public static GIOCondition GIoChannelGetBufferCondition(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_buffer_condition(channel);
	}

	public static GIOStatus GIoChannelSetFlags(this GIOChannelHandle channel, GIOFlags flags, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_set_flags(channel, flags, out error);
	}

	public static GIOFlags GIoChannelGetFlags(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_flags(channel);
	}

	public static GIOChannelHandle GIoChannelSetLineTerm(this GIOChannelHandle channel, string line_term, int length)
	{
		GIOChannelExterns.g_io_channel_set_line_term(channel, line_term, length);
		return channel;
	}

	public static string GIoChannelGetLineTerm(this GIOChannelHandle channel, out int length)
	{
		return GIOChannelExterns.g_io_channel_get_line_term(channel, out length);
	}

	public static GIOChannelHandle GIoChannelSetBuffered(this GIOChannelHandle channel, int buffered)
	{
		GIOChannelExterns.g_io_channel_set_buffered(channel, buffered);
		return channel;
	}

	public static int GIoChannelGetBuffered(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_buffered(channel);
	}

	public static GIOStatus GIoChannelSetEncoding(this GIOChannelHandle channel, string encoding, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_set_encoding(channel, encoding, out error);
	}

	public static string GIoChannelGetEncoding(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_encoding(channel);
	}

	public static GIOChannelHandle GIoChannelSetCloseOnUnref(this GIOChannelHandle channel, int do_close)
	{
		GIOChannelExterns.g_io_channel_set_close_on_unref(channel, do_close);
		return channel;
	}

	public static int GIoChannelGetCloseOnUnref(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_get_close_on_unref(channel);
	}

	public static GIOStatus GIoChannelFlush(this GIOChannelHandle channel, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_flush(channel, out error);
	}

	public static GIOStatus GIoChannelReadLine(this GIOChannelHandle channel, out string str_return, out nuint length, out nuint terminator_pos, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_line(channel, out str_return, out length, out terminator_pos, out error);
	}

	public static GIOStatus GIoChannelReadLineString(this GIOChannelHandle channel, GStringHandle buffer, out nuint terminator_pos, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_line_string(channel, buffer, out terminator_pos, out error);
	}

	public static GIOStatus GIoChannelReadToEnd(this GIOChannelHandle channel, string[] str_return, out nuint length, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_to_end(channel, str_return, out length, out error);
	}

	public static GIOStatus GIoChannelReadChars(this GIOChannelHandle channel, string buf, nuint count, out nuint bytes_read, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_chars(channel, buf, count, out bytes_read, out error);
	}

	public static GIOStatus GIoChannelReadUnichar(this GIOChannelHandle channel, out char thechar, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_read_unichar(channel, out thechar, out error);
	}

	public static GIOStatus GIoChannelWriteChars(this GIOChannelHandle channel, string buf, nint count, out nuint bytes_written, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_write_chars(channel, buf, count, out bytes_written, out error);
	}

	public static GIOStatus GIoChannelWriteUnichar(this GIOChannelHandle channel, uint thechar, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_write_unichar(channel, thechar, out error);
	}

	public static GIOStatus GIoChannelSeekPosition(this GIOChannelHandle channel, nint offset, GSeekType type, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_seek_position(channel, offset, type, out error);
	}

	public static int GIoChannelUnixGetFd(this GIOChannelHandle channel)
	{
		return GIOChannelExterns.g_io_channel_unix_get_fd(channel);
	}

	public static GIOChannelHandle GIoChannelUnixNew(int fd)
	{
		return GIOChannelExterns.g_io_channel_unix_new(fd);
	}
}
