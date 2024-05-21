namespace MentorLake.Gtk4.Gdk4;

public class GdkFileListHandle : BaseSafeHandle
{
	public static GdkFileListHandle NewFromArray(GFileHandle[] files, UIntPtr n_files)
	{
		return GdkFileListExterns.gdk_file_list_new_from_array(files, n_files);
	}

	public static GdkFileListHandle NewFromList(GSListHandle files)
	{
		return GdkFileListExterns.gdk_file_list_new_from_list(files);
	}

}


public static class GdkFileListHandleExtensions
{
	public static GSListHandle GetFiles(this GdkFileListHandle file_list)
	{
		return GdkFileListExterns.gdk_file_list_get_files(file_list);
	}

}
internal class GdkFileListExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFileListHandle gdk_file_list_new_from_array(GFileHandle[] files, UIntPtr n_files);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFileListHandle gdk_file_list_new_from_list(GSListHandle files);

	[DllImport(Libraries.Gdk4)]
	internal static extern GSListHandle gdk_file_list_get_files(GdkFileListHandle file_list);

}

public struct GdkFileList
{
}
