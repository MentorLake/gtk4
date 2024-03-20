using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMappedFileAdaptors
{
	public static nuint GetLength(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_length(file);
	}

	public static string GetContents(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_contents(file);
	}

	public static GBytesHandle GetBytes(this GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_bytes(file);
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

	public static GMappedFileHandle Free(this GMappedFileHandle file)
	{
		GMappedFileExterns.g_mapped_file_free(file);
		return file;
	}

	public static GMappedFileHandle NewFromFd(int fd, int writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new_from_fd(fd, writable, out error);
	}
}
