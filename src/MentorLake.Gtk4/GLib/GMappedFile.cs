namespace MentorLake.Gtk4.GLib;

public class GMappedFileHandle : BaseSafeHandle
{
	public static GMappedFileHandle New(string filename, bool writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new(filename, writable, out error);
	}

	public static GMappedFileHandle NewFromFd(int fd, bool writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new_from_fd(fd, writable, out error);
	}

}

internal class GMappedFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_new(string filename, bool writable, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_new_from_fd(int fd, bool writable, out GErrorHandle error);

}

public struct GMappedFile
{
}
