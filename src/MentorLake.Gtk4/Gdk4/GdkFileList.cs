namespace MentorLake.Gtk4.Gdk4;

public class GdkFileListHandle : BaseSafeHandle
{
	public static GdkFileListHandle NewFromArray(GFileHandle[] files, int n_files)
	{
		return GdkFileListExterns.gdk_file_list_new_from_array(files, n_files);
	}

	public static GdkFileListHandle NewFromList(GSListHandle files)
	{
		return GdkFileListExterns.gdk_file_list_new_from_list(files);
	}

}

internal class GdkFileListExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFileListHandle gdk_file_list_new_from_array(GFileHandle[] files, int n_files);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFileListHandle gdk_file_list_new_from_list(GSListHandle files);

}

public struct GdkFileList
{
}
