using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GDesktopAppInfoHandle : GObjectHandle
{
	public static GDesktopAppInfoHandle New(string desktop_id)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_new(desktop_id);
	}
	public static GDesktopAppInfoHandle NewFromFilename(string filename)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_new_from_filename(filename);
	}
	public static GDesktopAppInfoHandle NewFromKeyfile(GKeyFileHandle key_file)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_new_from_keyfile(key_file);
	}
}

public static class GDesktopAppInfoSignals
{
}

public static class GDesktopAppInfoHandleExtensions
{
	public static string GetActionName(this GDesktopAppInfoHandle info, string action_name)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_action_name(info, action_name);
	}

	public static bool GetBoolean(this GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_boolean(info, key);
	}

	public static string GetCategories(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_categories(info);
	}

	public static string GetFilename(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_filename(info);
	}

	public static string GetGenericName(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_generic_name(info);
	}

	public static bool GetIsHidden(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_is_hidden(info);
	}

	public static string GetKeywords(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_keywords(info);
	}

	public static string GetLocaleString(this GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_locale_string(info, key);
	}

	public static bool GetNodisplay(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_nodisplay(info);
	}

	public static bool GetShowIn(this GDesktopAppInfoHandle info, string desktop_env)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_show_in(info, desktop_env);
	}

	public static string GetStartupWmClass(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_startup_wm_class(info);
	}

	public static string GetString(this GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_string(info, key);
	}

	public static string[] GetStringList(this GDesktopAppInfoHandle info, string key, out int length)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_string_list(info, key, out length);
	}

	public static bool HasKey(this GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_has_key(info, key);
	}

	public static GDesktopAppInfoHandle LaunchAction(this GDesktopAppInfoHandle info, string action_name, GAppLaunchContextHandle launch_context)
	{
		GDesktopAppInfoExterns.g_desktop_app_info_launch_action(info, action_name, launch_context);
		return info;
	}

	public static bool LaunchUrisAsManager(this GDesktopAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle launch_context, GSpawnFlags spawn_flags, GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, out GErrorHandle error)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_launch_uris_as_manager(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, out error);
	}

	public static bool LaunchUrisAsManagerWithFds(this GDesktopAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle launch_context, GSpawnFlags spawn_flags, GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd, out GErrorHandle error)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_launch_uris_as_manager_with_fds(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, stdin_fd, stdout_fd, stderr_fd, out error);
	}

	public static string ListActions(this GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_list_actions(info);
	}

	public static GListHandle GetImplementations(this string @interface)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_get_implementations(@interface);
	}

	public static string[][] Search(this string search_string)
	{
		return GDesktopAppInfoExterns.g_desktop_app_info_search(search_string);
	}

	public static void SetDesktopEnv(this string desktop_env)
	{
		GDesktopAppInfoExterns.g_desktop_app_info_set_desktop_env(desktop_env);
	}

}

internal class GDesktopAppInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_action_name(GDesktopAppInfoHandle info, string action_name);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_get_boolean(GDesktopAppInfoHandle info, string key);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_categories(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_filename(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_generic_name(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_get_is_hidden(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_keywords(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_locale_string(GDesktopAppInfoHandle info, string key);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_get_nodisplay(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_get_show_in(GDesktopAppInfoHandle info, string desktop_env);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_startup_wm_class(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_get_string(GDesktopAppInfoHandle info, string key);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_desktop_app_info_get_string_list(GDesktopAppInfoHandle info, string key, out int length);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_has_key(GDesktopAppInfoHandle info, string key);
	[DllImport(Libraries.Gio)]
	internal static extern void g_desktop_app_info_launch_action(GDesktopAppInfoHandle info, string action_name, GAppLaunchContextHandle launch_context);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_launch_uris_as_manager(GDesktopAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle launch_context, GSpawnFlags spawn_flags, GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_desktop_app_info_launch_uris_as_manager_with_fds(GDesktopAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle launch_context, GSpawnFlags spawn_flags, GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern string g_desktop_app_info_list_actions(GDesktopAppInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_desktop_app_info_get_implementations(string @interface);
	[DllImport(Libraries.Gio)]
	internal static extern string[][] g_desktop_app_info_search(string search_string);
	[DllImport(Libraries.Gio)]
	internal static extern void g_desktop_app_info_set_desktop_env(string desktop_env);
	[DllImport(Libraries.Gio)]
	internal static extern GDesktopAppInfoHandle g_desktop_app_info_new(string desktop_id);
	[DllImport(Libraries.Gio)]
	internal static extern GDesktopAppInfoHandle g_desktop_app_info_new_from_filename(string filename);
	[DllImport(Libraries.Gio)]
	internal static extern GDesktopAppInfoHandle g_desktop_app_info_new_from_keyfile(GKeyFileHandle key_file);
}
