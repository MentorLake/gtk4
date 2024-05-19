namespace MentorLake.Gtk4.Gio;

public class GFileAttributeInfoListHandle : BaseSafeHandle
{
	public static GFileAttributeInfoListHandle New()
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_new();
	}

}

internal class GFileAttributeInfoListExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_attribute_info_list_new();

}

public struct GFileAttributeInfoList
{
	public GFileAttributeInfoHandle infos;
	public int n_infos;
}
