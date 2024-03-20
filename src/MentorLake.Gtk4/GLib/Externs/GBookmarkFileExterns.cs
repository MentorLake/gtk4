using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GBookmarkFileExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_free")]
    internal static extern void g_bookmark_file_free(this GBookmarkFileHandle bookmark);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_load_from_file")]
    internal static extern int g_bookmark_file_load_from_file(this GBookmarkFileHandle bookmark, string filename, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_load_from_data")]
    internal static extern int g_bookmark_file_load_from_data(this GBookmarkFileHandle bookmark, string data, nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_load_from_data_dirs")]
    internal static extern int g_bookmark_file_load_from_data_dirs(this GBookmarkFileHandle bookmark, string file, string[] full_path, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_to_data")]
    internal static extern string g_bookmark_file_to_data(this GBookmarkFileHandle bookmark, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_to_file")]
    internal static extern int g_bookmark_file_to_file(this GBookmarkFileHandle bookmark, string filename, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_title")]
    internal static extern void g_bookmark_file_set_title(this GBookmarkFileHandle bookmark, string uri, string title);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_title")]
    internal static extern string g_bookmark_file_get_title(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_description")]
    internal static extern void g_bookmark_file_set_description(this GBookmarkFileHandle bookmark, string uri, string description);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_description")]
    internal static extern string g_bookmark_file_get_description(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_mime_type")]
    internal static extern void g_bookmark_file_set_mime_type(this GBookmarkFileHandle bookmark, string uri, string mime_type);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_mime_type")]
    internal static extern string g_bookmark_file_get_mime_type(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_groups")]
    internal static extern void g_bookmark_file_set_groups(this GBookmarkFileHandle bookmark, string uri, string[] groups, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_add_group")]
    internal static extern void g_bookmark_file_add_group(this GBookmarkFileHandle bookmark, string uri, string group);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_has_group")]
    internal static extern int g_bookmark_file_has_group(this GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_groups")]
    internal static extern string[] g_bookmark_file_get_groups(this GBookmarkFileHandle bookmark, string uri, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_add_application")]
    internal static extern void g_bookmark_file_add_application(this GBookmarkFileHandle bookmark, string uri, string name, string exec);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_has_application")]
    internal static extern int g_bookmark_file_has_application(this GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_applications")]
    internal static extern string[] g_bookmark_file_get_applications(this GBookmarkFileHandle bookmark, string uri, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_app_info")]
    [Obsolete]
    internal static extern int g_bookmark_file_set_app_info(this GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, time_t stamp, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_application_info")]
    internal static extern int g_bookmark_file_set_application_info(this GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, GDateTimeHandle stamp, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_app_info")]
    [Obsolete]
    internal static extern int g_bookmark_file_get_app_info(this GBookmarkFileHandle bookmark, string uri, string name, string[] exec, out uint count, out time_t stamp, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_application_info")]
    internal static extern int g_bookmark_file_get_application_info(this GBookmarkFileHandle bookmark, string uri, string name, string[] exec, out uint count, out GDateTimeHandle stamp, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_is_private")]
    internal static extern void g_bookmark_file_set_is_private(this GBookmarkFileHandle bookmark, string uri, int is_private);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_is_private")]
    internal static extern int g_bookmark_file_get_is_private(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_icon")]
    internal static extern void g_bookmark_file_set_icon(this GBookmarkFileHandle bookmark, string uri, string href, string mime_type);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_icon")]
    internal static extern int g_bookmark_file_get_icon(this GBookmarkFileHandle bookmark, string uri, string[] href, string[] mime_type, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_added")]
    [Obsolete]
    internal static extern void g_bookmark_file_set_added(this GBookmarkFileHandle bookmark, string uri, time_t added);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_added_date_time")]
    internal static extern void g_bookmark_file_set_added_date_time(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle added);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_added")]
    internal static extern time_t g_bookmark_file_get_added(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_added_date_time")]
    internal static extern GDateTimeHandle g_bookmark_file_get_added_date_time(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_modified")]
    [Obsolete]
    internal static extern void g_bookmark_file_set_modified(this GBookmarkFileHandle bookmark, string uri, time_t modified);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_modified_date_time")]
    internal static extern void g_bookmark_file_set_modified_date_time(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle modified);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_modified")]
    internal static extern time_t g_bookmark_file_get_modified(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_modified_date_time")]
    internal static extern GDateTimeHandle g_bookmark_file_get_modified_date_time(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_visited")]
    [Obsolete]
    internal static extern void g_bookmark_file_set_visited(this GBookmarkFileHandle bookmark, string uri, time_t visited);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_set_visited_date_time")]
    internal static extern void g_bookmark_file_set_visited_date_time(this GBookmarkFileHandle bookmark, string uri, GDateTimeHandle visited);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_visited")]
    internal static extern time_t g_bookmark_file_get_visited(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_visited_date_time")]
    internal static extern GDateTimeHandle g_bookmark_file_get_visited_date_time(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_has_item")]
    internal static extern int g_bookmark_file_has_item(this GBookmarkFileHandle bookmark, string uri);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_size")]
    internal static extern int g_bookmark_file_get_size(this GBookmarkFileHandle bookmark);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_get_uris")]
    internal static extern string[] g_bookmark_file_get_uris(this GBookmarkFileHandle bookmark, out nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_remove_group")]
    internal static extern int g_bookmark_file_remove_group(this GBookmarkFileHandle bookmark, string uri, string group, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_remove_application")]
    internal static extern int g_bookmark_file_remove_application(this GBookmarkFileHandle bookmark, string uri, string name, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_remove_item")]
    internal static extern int g_bookmark_file_remove_item(this GBookmarkFileHandle bookmark, string uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_bookmark_file_move_item")]
    internal static extern int g_bookmark_file_move_item(this GBookmarkFileHandle bookmark, string old_uri, string new_uri, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GBookmarkFileHandle g_bookmark_file_new();
}
