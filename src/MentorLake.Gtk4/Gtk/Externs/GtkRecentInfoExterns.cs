using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkRecentInfoExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_ref")]
	internal static extern GtkRecentInfoHandle gtk_recent_info_ref(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_unref")]
	internal static extern void gtk_recent_info_unref(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_uri")]
	internal static extern string gtk_recent_info_get_uri(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_display_name")]
	internal static extern string gtk_recent_info_get_display_name(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_description")]
	internal static extern string gtk_recent_info_get_description(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_mime_type")]
	internal static extern string gtk_recent_info_get_mime_type(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_added")]
	internal static extern GDateTimeHandle gtk_recent_info_get_added(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_modified")]
	internal static extern GDateTimeHandle gtk_recent_info_get_modified(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_visited")]
	internal static extern GDateTimeHandle gtk_recent_info_get_visited(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_private_hint")]
	internal static extern int gtk_recent_info_get_private_hint(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_application_info")]
	internal static extern int gtk_recent_info_get_application_info(this GtkRecentInfoHandle info, string app_name, out string[] app_exec, out uint count, out GDateTimeHandle stamp);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_create_app_info")]
	internal static extern GAppInfoHandle gtk_recent_info_create_app_info(this GtkRecentInfoHandle info, string app_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_applications")]
	internal static extern string[] gtk_recent_info_get_applications(this GtkRecentInfoHandle info, out nuint length);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_last_application")]
	internal static extern string gtk_recent_info_last_application(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_has_application")]
	internal static extern int gtk_recent_info_has_application(this GtkRecentInfoHandle info, string app_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_groups")]
	internal static extern string[] gtk_recent_info_get_groups(this GtkRecentInfoHandle info, out nuint length);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_has_group")]
	internal static extern int gtk_recent_info_has_group(this GtkRecentInfoHandle info, string group_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_gicon")]
	internal static extern GIconHandle gtk_recent_info_get_gicon(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_short_name")]
	internal static extern string gtk_recent_info_get_short_name(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_uri_display")]
	internal static extern string gtk_recent_info_get_uri_display(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_get_age")]
	internal static extern int gtk_recent_info_get_age(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_is_local")]
	internal static extern int gtk_recent_info_is_local(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_exists")]
	internal static extern int gtk_recent_info_exists(this GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_info_match")]
	internal static extern int gtk_recent_info_match(this GtkRecentInfoHandle info_a, GtkRecentInfoHandle info_b);
}
