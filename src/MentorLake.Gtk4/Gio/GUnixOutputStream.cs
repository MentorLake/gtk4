namespace MentorLake.Gtk4.Gio;

public class GUnixOutputStreamHandle : GOutputStreamHandle, GFileDescriptorBasedHandle, GPollableOutputStreamHandle
{
	public static GUnixOutputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixOutputStreamExterns.g_unix_output_stream_new(fd, close_fd);
	}

}

public static class GUnixOutputStreamHandleExtensions
{
	public static bool GetCloseFd(this GUnixOutputStreamHandle stream)
	{
		return GUnixOutputStreamExterns.g_unix_output_stream_get_close_fd(stream);
	}

	public static int GetFd(this GUnixOutputStreamHandle stream)
	{
		return GUnixOutputStreamExterns.g_unix_output_stream_get_fd(stream);
	}

	public static GUnixOutputStreamHandle SetCloseFd(this GUnixOutputStreamHandle stream, bool close_fd)
	{
		GUnixOutputStreamExterns.g_unix_output_stream_set_close_fd(stream, close_fd);
		return stream;
	}

}

internal class GUnixOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixOutputStreamHandle g_unix_output_stream_new(int fd, bool close_fd);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_output_stream_get_close_fd(GUnixOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_output_stream_get_fd(GUnixOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_output_stream_set_close_fd(GUnixOutputStreamHandle stream, bool close_fd);

}
