using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GBookmarkFileAdaptors
{
	public static GBookmarkFileHandle Free(this GBookmarkFileHandle bookmark)
	{
		GBookmarkFileExterns.g_bookmark_file_free(bookmark);
		return bookmark;
	}

	public static int LoadFromFile(this GBookmarkFileHandle bookmark, string filename, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_file(bookmark, filename, out error);
	}

	public static int LoadFromData(this GBookmarkFileHandle bookmark, string data, nuint length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_data(bookmark, data, length, out error);
	}

	public static int LoadFromDataDirs(this GBookmarkFileHandle bookmark, string file, string[] full_path, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_data_dirs(bookmark, file, full_path, out error);
	}

	public static string ToData(this GBookmarkFileHandle bookmark, out nuint length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_to_data(bookmark, out length, out error);
	}

	public static int ToFile(this GBookmarkFileHandle bookmark, string filename, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_to_file(bookmark, filename, out error);
	}

	public static GBookmarkFileHandle SetTitle(this GBookmarkFileHandle bookmark, string uri, string title)
	{
		GBookmarkFileExterns.g_bookmark_file_set_title(bookmark, uri, title);
		return bookmark;
	}

	public static string GetTitle(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_title(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetDescription(this GBookmarkFileHandle bookmark, string uri, string description)
	{
		GBookmarkFileExterns.g_bookmark_file_set_description(bookmark, uri, description);
		return bookmark;
	}

	public static string GetDescription(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_description(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetMimeType(this GBookmarkFileHandle bookmark, string uri, string mime_type)
	{
		GBookmarkFileExterns.g_bookmark_file_set_mime_type(bookmark, uri, mime_type);
		return bookmark;
	}

	public static string GetMimeType(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_mime_type(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetGroups(this GBookmarkFileHandle bookmark, string uri, string[] groups, nuint length)
	{
		GBookmarkFileExterns.g_bookmark_file_set_groups(bookmark, uri, groups, length);
		return bookmark;
	}

	public static GBookmarkFileHandle AddGroup(this GBookmarkFileHandle bookmark, string uri, string group)
	{
		GBookmarkFileExterns.g_bookmark_file_add_group(bookmark, uri, group);
		return bookmark;
	}

	public static int HasGroup(this GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_group(bookmark, uri, group, out error);
	}

	public static string[] GetGroups(this GBookmarkFileHandle bookmark, string uri, out nuint length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_groups(bookmark, uri, out length, out error);
	}

	public static GBookmarkFileHandle AddApplication(this GBookmarkFileHandle bookmark, string uri, string name, string exec)
	{
		GBookmarkFileExterns.g_bookmark_file_add_application(bookmark, uri, name, exec);
		return bookmark;
	}

	public static int HasApplication(this GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_application(bookmark, uri, name, out error);
	}

	public static string[] GetApplications(this GBookmarkFileHandle bookmark, string uri, out nuint length, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_applications(bookmark, uri, out length, out error);
	}

	public static int SetAppInfo(this GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, time_t stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_set_app_info(bookmark, uri, name, exec, count, stamp, out error);
	}

	public static int SetApplicationInfo(this GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, GDateTimeHandle stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_set_application_info(bookmark, uri, name, exec, count, stamp, out error);
	}

	public static int GetAppInfo(this GBookmarkFileHandle bookmark, string uri, string name, string[] exec, out uint count, out time_t stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_app_info(bookmark, uri, name, exec, out count, out stamp, out error);
	}

	public static int GetApplicationInfo(this GBookmarkFileHandle bookmark, string uri, string name, string[] exec, out uint count, out GDateTimeHandle stamp, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_application_info(bookmark, uri, name, exec, out count, out stamp, out error);
	}

	public static GBookmarkFileHandle SetIsPrivate(this GBookmarkFileHandle bookmark, string uri, int is_private)
	{
		GBookmarkFileExterns.g_bookmark_file_set_is_private(bookmark, uri, is_private);
		return bookmark;
	}

	public static int GetIsPrivate(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_is_private(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetIcon(this GBookmarkFileHandle bookmark, string uri, string href, string mime_type)
	{
		GBookmarkFileExterns.g_bookmark_file_set_icon(bookmark, uri, href, mime_type);
		return bookmark;
	}

	public static int GetIcon(this GBookmarkFileHandle bookmark, string uri, string[] href, string[] mime_type, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_icon(bookmark, uri, href, mime_type, out error);
	}

	public static GBookmarkFileHandle SetAdded(this GBookmarkFileHandle bookmark, string uri, time_t added)
	{
		GBookmarkFileExterns.g_bookmark_file_set_added(bookmark, uri, added);
		return bookmark;
	}

	public static GBookmarkFileHandle SetAddedDateTime(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle added)
	{
		GBookmarkFileExterns.g_bookmark_file_set_added_date_time(bookmark, uri, added);
		return bookmark;
	}

	public static time_t GetAdded(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_added(bookmark, uri, out error);
	}

	public static GDateTimeHandle GetAddedDateTime(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_added_date_time(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetModified(this GBookmarkFileHandle bookmark, string uri, time_t modified)
	{
		GBookmarkFileExterns.g_bookmark_file_set_modified(bookmark, uri, modified);
		return bookmark;
	}

	public static GBookmarkFileHandle SetModifiedDateTime(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle modified)
	{
		GBookmarkFileExterns.g_bookmark_file_set_modified_date_time(bookmark, uri, modified);
		return bookmark;
	}

	public static time_t GetModified(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_modified(bookmark, uri, out error);
	}

	public static GDateTimeHandle GetModifiedDateTime(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_modified_date_time(bookmark, uri, out error);
	}

	public static GBookmarkFileHandle SetVisited(this GBookmarkFileHandle bookmark, string uri, time_t visited)
	{
		GBookmarkFileExterns.g_bookmark_file_set_visited(bookmark, uri, visited);
		return bookmark;
	}

	public static GBookmarkFileHandle SetVisitedDateTime(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle visited)
	{
		GBookmarkFileExterns.g_bookmark_file_set_visited_date_time(bookmark, uri, visited);
		return bookmark;
	}

	public static time_t GetVisited(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_visited(bookmark, uri, out error);
	}

	public static GDateTimeHandle GetVisitedDateTime(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_visited_date_time(bookmark, uri, out error);
	}

	public static int HasItem(this GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_item(bookmark, uri);
	}

	public static int GetSize(this GBookmarkFileHandle bookmark)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_size(bookmark);
	}

	public static string[] GetUris(this GBookmarkFileHandle bookmark, out nuint length)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_uris(bookmark, out length);
	}

	public static int RemoveGroup(this GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_group(bookmark, uri, group, out error);
	}

	public static int RemoveApplication(this GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_application(bookmark, uri, name, out error);
	}

	public static int RemoveItem(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_item(bookmark, uri, out error);
	}

	public static int MoveItem(this GBookmarkFileHandle bookmark, string old_uri, string new_uri, out GErrorHandle error)
	{
		return GBookmarkFileExterns.g_bookmark_file_move_item(bookmark, old_uri, new_uri, out error);
	}
}
