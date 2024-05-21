namespace MentorLake.Gtk4.Gio;

public class GFileAttributeInfoListHandle : BaseSafeHandle
{
	public static GFileAttributeInfoListHandle New()
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_new();
	}

}


public static class GFileAttributeInfoListHandleExtensions
{
	public static GFileAttributeInfoListHandle Add(this GFileAttributeInfoListHandle list, string name, GFileAttributeType type, GFileAttributeInfoFlags flags)
	{
		GFileAttributeInfoListExterns.g_file_attribute_info_list_add(list, name, type, flags);
		return list;
	}

	public static GFileAttributeInfoListHandle Dup(this GFileAttributeInfoListHandle list)
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_dup(list);
	}

	public static GFileAttributeInfoHandle Lookup(this GFileAttributeInfoListHandle list, string name)
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_lookup(list, name);
	}

	public static GFileAttributeInfoListHandle Ref(this GFileAttributeInfoListHandle list)
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_ref(list);
	}

	public static GFileAttributeInfoListHandle Unref(this GFileAttributeInfoListHandle list)
	{
		GFileAttributeInfoListExterns.g_file_attribute_info_list_unref(list);
		return list;
	}

}
internal class GFileAttributeInfoListExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_attribute_info_list_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_attribute_info_list_add(GFileAttributeInfoListHandle list, string name, GFileAttributeType type, GFileAttributeInfoFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_attribute_info_list_dup(GFileAttributeInfoListHandle list);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoHandle g_file_attribute_info_list_lookup(GFileAttributeInfoListHandle list, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_attribute_info_list_ref(GFileAttributeInfoListHandle list);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_attribute_info_list_unref(GFileAttributeInfoListHandle list);

}

public struct GFileAttributeInfoList
{
	public GFileAttributeInfoHandle infos;
	public int n_infos;
}
