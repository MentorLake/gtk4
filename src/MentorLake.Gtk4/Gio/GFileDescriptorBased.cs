namespace MentorLake.Gtk4.Gio;

public interface GFileDescriptorBasedHandle
{
}

internal class GFileDescriptorBasedHandleImpl : BaseSafeHandle, GFileDescriptorBasedHandle
{
}

public static class GFileDescriptorBasedHandleExtensions
{
	public static int GetFd(this GFileDescriptorBasedHandle fd_based)
	{
		return GFileDescriptorBasedExterns.g_file_descriptor_based_get_fd(fd_based);
	}

}

internal class GFileDescriptorBasedExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern int g_file_descriptor_based_get_fd(GFileDescriptorBasedHandle fd_based);

}
