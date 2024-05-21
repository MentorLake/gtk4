namespace MentorLake.Gtk4.GLib;

public class GBookmarkFileHandle : BaseSafeHandle
{
	public static GBookmarkFileHandle New()
	{
		return GBookmarkFileExterns.g_bookmark_file_new();
	}

}


public static class GBookmarkFileHandleExtensions
{
	public static GBookmarkFileHandle AddApplication(this GBookmarkFileHandle bookmark, string uri, string name, string exec)
	{
		GBookmarkFileExterns.g_bookmark_file_add_application(bookmark, uri, name, exec);
		return bookmark;
	}

	public static GBookmarkFileHandle AddGroup(this GBookmarkFileHandle bookmark, string uri, string group)
	{
		GBookmarkFileExterns.g_bookmark_file_add_group(bookmark, uri, group);
		return bookmark;
	}

	public static GBookmarkFileHandle Copy(this GBookmarkFileHandle bookmark)
	{
		return GBookmarkFileExterns.g_bookmark_file_copy(bookmark);
	}

	public static GBookmarkFileHandle Free(this GBookmarkFileHandle bookmark)
	{
		GBookmarkFileExterns.g_bookmark_file_free(bookmark);
		return bookmark;
	}

	public static long GetAdded(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_added(bookmark, uri, out error);
	}

	public static GDateTimeHandle GetAddedDateTime(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_added_date_time(bookmark, uri, out error);
	}

	public static bool GetAppInfo(this GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out long stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_app_info(bookmark, uri, name, out exec, out count, out stamp, out error);
	}

	public static bool GetApplicationInfo(this GBookmarkFileHandle bookmark, string uri, string name, out string exec, out int count, out GDateTimeHandle stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_application_info(bookmark, uri, name, out exec, out count, out stamp, out error);
	}

	public static IntPtr GetApplications(this GBookmarkFileHandle bookmark, string uri, out UIntPtr length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_applications(bookmark, uri, out length, out error);
	}

	public static string GetDescription(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_description(bookmark, uri, out error);
	}

	public static IntPtr GetGroups(this GBookmarkFileHandle bookmark, string uri, out UIntPtr length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_groups(bookmark, uri, out length, out error);
	}

	public static bool GetIcon(this GBookmarkFileHandle bookmark, string uri, out string href, out string mime_type, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_icon(bookmark, uri, out href, out mime_type, out error);
	}

	public static bool GetIsPrivate(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_is_private(bookmark, uri, out error);
	}

	public static string GetMimeType(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_mime_type(bookmark, uri, out error);
	}

	public static long GetModified(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_modified(bookmark, uri, out error);
	}

	public static GDateTimeHandle GetModifiedDateTime(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_modified_date_time(bookmark, uri, out error);
	}

	public static int GetSize(this GBookmarkFileHandle bookmark)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_size(bookmark);
	}

	public static string GetTitle(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_title(bookmark, uri, out error);
	}

	public static IntPtr GetUris(this GBookmarkFileHandle bookmark, out UIntPtr length)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_uris(bookmark, out length);
	}

	public static long GetVisited(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_visited(bookmark, uri, out error);
	}

	public static GDateTimeHandle GetVisitedDateTime(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_visited_date_time(bookmark, uri, out error);
	}

	public static bool HasApplication(this GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_application(bookmark, uri, name, out error);
	}

	public static bool HasGroup(this GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_group(bookmark, uri, group, out error);
	}

	public static bool HasItem(this GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_item(bookmark, uri);
	}

	public static bool LoadFromData(this GBookmarkFileHandle bookmark, string data, UIntPtr length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_data(bookmark, data, length, out error);
	}

	public static bool LoadFromDataDirs(this GBookmarkFileHandle bookmark, string file, out string full_path, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_data_dirs(bookmark, file, out full_path, out error);
	}

	public static bool LoadFromFile(this GBookmarkFileHandle bookmark, string filename, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_file(bookmark, filename, out error);
	}

	public static bool MoveItem(this GBookmarkFileHandle bookmark, string old_uri, string new_uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_move_item(bookmark, old_uri, new_uri, out error);
	}

	public static bool RemoveApplication(this GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_application(bookmark, uri, name, out error);
	}

	public static bool RemoveGroup(this GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_group(bookmark, uri, group, out error);
	}

	public static bool RemoveItem(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_item(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetAdded(this GBookmarkFileHandle bookmark, string uri, long added)
	{
		GBookmarkFileExterns.g_bookmark_file_set_added(bookmark, uri, added);
		return bookmark;
	}

	public static GBookmarkFileHandle SetAddedDateTime(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle added)
	{
		GBookmarkFileExterns.g_bookmark_file_set_added_date_time(bookmark, uri, added);
		return bookmark;
	}

	public static bool SetAppInfo(this GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, long stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_set_app_info(bookmark, uri, name, exec, count, stamp, out error);
	}

	public static bool SetApplicationInfo(this GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, GDateTimeHandle stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_set_application_info(bookmark, uri, name, exec, count, stamp, out error);
	}

	public static GBookmarkFileHandle SetDescription(this GBookmarkFileHandle bookmark, string uri, string description)
	{
		GBookmarkFileExterns.g_bookmark_file_set_description(bookmark, uri, description);
		return bookmark;
	}

	public static GBookmarkFileHandle SetGroups(this GBookmarkFileHandle bookmark, string uri, string[] groups, UIntPtr length)
	{
		GBookmarkFileExterns.g_bookmark_file_set_groups(bookmark, uri, groups, length);
		return bookmark;
	}

	public static GBookmarkFileHandle SetIcon(this GBookmarkFileHandle bookmark, string uri, string href, string mime_type)
	{
		GBookmarkFileExterns.g_bookmark_file_set_icon(bookmark, uri, href, mime_type);
		return bookmark;
	}

	public static GBookmarkFileHandle SetIsPrivate(this GBookmarkFileHandle bookmark, string uri, bool is_private)
	{
		GBookmarkFileExterns.g_bookmark_file_set_is_private(bookmark, uri, is_private);
		return bookmark;
	}

	public static GBookmarkFileHandle SetMimeType(this GBookmarkFileHandle bookmark, string uri, string mime_type)
	{
		GBookmarkFileExterns.g_bookmark_file_set_mime_type(bookmark, uri, mime_type);
		return bookmark;
	}

	public static GBookmarkFileHandle SetModified(this GBookmarkFileHandle bookmark, string uri, long modified)
	{
		GBookmarkFileExterns.g_bookmark_file_set_modified(bookmark, uri, modified);
		return bookmark;
	}

	public static GBookmarkFileHandle SetModifiedDateTime(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle modified)
	{
		GBookmarkFileExterns.g_bookmark_file_set_modified_date_time(bookmark, uri, modified);
		return bookmark;
	}

	public static GBookmarkFileHandle SetTitle(this GBookmarkFileHandle bookmark, string uri, string title)
	{
		GBookmarkFileExterns.g_bookmark_file_set_title(bookmark, uri, title);
		return bookmark;
	}

	public static GBookmarkFileHandle SetVisited(this GBookmarkFileHandle bookmark, string uri, long visited)
	{
		GBookmarkFileExterns.g_bookmark_file_set_visited(bookmark, uri, visited);
		return bookmark;
	}

	public static GBookmarkFileHandle SetVisitedDateTime(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle visited)
	{
		GBookmarkFileExterns.g_bookmark_file_set_visited_date_time(bookmark, uri, visited);
		return bookmark;
	}

	public static IntPtr ToData(this GBookmarkFileHandle bookmark, out UIntPtr length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_to_data(bookmark, out length, out error);
	}

	public static bool ToFile(this GBookmarkFileHandle bookmark, string filename, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_to_file(bookmark, filename, out error);
	}

}
internal class GBookmarkFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GBookmarkFileHandle g_bookmark_file_new();

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_add_application(GBookmarkFileHandle bookmark, string uri, string name, string exec);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_add_group(GBookmarkFileHandle bookmark, string uri, string group);

	[DllImport(Libraries.GLib)]
	internal static extern GBookmarkFileHandle g_bookmark_file_copy(GBookmarkFileHandle bookmark);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_free(GBookmarkFileHandle bookmark);

	[DllImport(Libraries.GLib)]
	internal static extern long g_bookmark_file_get_added(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_bookmark_file_get_added_date_time(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_get_app_info(GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out long stamp, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_get_application_info(GBookmarkFileHandle bookmark, string uri, string name, out string exec, out int count, out GDateTimeHandle stamp, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bookmark_file_get_applications(GBookmarkFileHandle bookmark, string uri, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_bookmark_file_get_description(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bookmark_file_get_groups(GBookmarkFileHandle bookmark, string uri, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_get_icon(GBookmarkFileHandle bookmark, string uri, out string href, out string mime_type, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_get_is_private(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_bookmark_file_get_mime_type(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern long g_bookmark_file_get_modified(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_bookmark_file_get_modified_date_time(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_bookmark_file_get_size(GBookmarkFileHandle bookmark);

	[DllImport(Libraries.GLib)]
	internal static extern string g_bookmark_file_get_title(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bookmark_file_get_uris(GBookmarkFileHandle bookmark, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern long g_bookmark_file_get_visited(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_bookmark_file_get_visited_date_time(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_has_application(GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_has_group(GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_has_item(GBookmarkFileHandle bookmark, string uri);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_load_from_data(GBookmarkFileHandle bookmark, string data, UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_load_from_data_dirs(GBookmarkFileHandle bookmark, string file, out string full_path, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_load_from_file(GBookmarkFileHandle bookmark, string filename, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_move_item(GBookmarkFileHandle bookmark, string old_uri, string new_uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_remove_application(GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_remove_group(GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_remove_item(GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_added(GBookmarkFileHandle bookmark, string uri, long added);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_added_date_time(GBookmarkFileHandle bookmark, string uri, GDateTimeHandle added);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_set_app_info(GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, long stamp, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_set_application_info(GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, GDateTimeHandle stamp, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_description(GBookmarkFileHandle bookmark, string uri, string description);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_groups(GBookmarkFileHandle bookmark, string uri, string[] groups, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_icon(GBookmarkFileHandle bookmark, string uri, string href, string mime_type);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_is_private(GBookmarkFileHandle bookmark, string uri, bool is_private);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_mime_type(GBookmarkFileHandle bookmark, string uri, string mime_type);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_modified(GBookmarkFileHandle bookmark, string uri, long modified);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_modified_date_time(GBookmarkFileHandle bookmark, string uri, GDateTimeHandle modified);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_title(GBookmarkFileHandle bookmark, string uri, string title);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_visited(GBookmarkFileHandle bookmark, string uri, long visited);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bookmark_file_set_visited_date_time(GBookmarkFileHandle bookmark, string uri, GDateTimeHandle visited);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_bookmark_file_to_data(GBookmarkFileHandle bookmark, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bookmark_file_to_file(GBookmarkFileHandle bookmark, string filename, out GErrorHandle error);

}

public struct GBookmarkFile
{
}
