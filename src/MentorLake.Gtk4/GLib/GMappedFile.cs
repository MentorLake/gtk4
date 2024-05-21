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


public static class GMappedFileHandleExtensions
{
	public static GMappedFileHandle Free(this GMappedFileHandle file)
	{
		GMappedFileExterns.g_mapped_file_free(file);
		return file;
	}

	public static GBytesHandle GetBytes(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_bytes(file);
	}

	public static string GetContents(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_contents(file);
	}

	public static UIntPtr GetLength(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_length(file);
	}

	public static GMappedFileHandle Ref(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_ref(file);
	}

	public static GMappedFileHandle Unref(this GMappedFileHandle file)
	{
		GMappedFileExterns.g_mapped_file_unref(file);
		return file;
	}

}
internal class GMappedFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_new(string filename, bool writable, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_new_from_fd(int fd, bool writable, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mapped_file_free(GMappedFileHandle file);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_mapped_file_get_bytes(GMappedFileHandle file);

	[DllImport(Libraries.GLib)]
	internal static extern string g_mapped_file_get_contents(GMappedFileHandle file);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_mapped_file_get_length(GMappedFileHandle file);

	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_ref(GMappedFileHandle file);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mapped_file_unref(GMappedFileHandle file);

}

public struct GMappedFile
{
}
