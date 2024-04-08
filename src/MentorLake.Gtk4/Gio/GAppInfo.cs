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

public interface GAppInfoHandle
{
}

public static class GAppInfoHandleExtensions
{
	public static bool AddSupportsType(this GAppInfoHandle appinfo, string content_type, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_add_supports_type(appinfo, content_type, out error);
	}

	public static bool CanDelete(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_can_delete(appinfo);
	}

	public static bool CanRemoveSupportsType(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_can_remove_supports_type(appinfo);
	}

	public static bool Delete(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_delete(appinfo);
	}

	public static GAppInfoHandle Dup(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_dup(appinfo);
	}

	public static bool Equal(this GAppInfoHandle appinfo1, GAppInfoHandle appinfo2)
	{
		return GAppInfoExterns.g_app_info_equal(appinfo1, appinfo2);
	}

	public static string GetCommandline(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_commandline(appinfo);
	}

	public static string GetDescription(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_description(appinfo);
	}

	public static string GetDisplayName(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_display_name(appinfo);
	}

	public static string GetExecutable(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_executable(appinfo);
	}

	public static GIconHandle GetIcon(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_icon(appinfo);
	}

	public static string GetId(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_id(appinfo);
	}

	public static string GetName(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_name(appinfo);
	}

	public static string[] GetSupportedTypes(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_get_supported_types(appinfo);
	}

	public static bool Launch(this GAppInfoHandle appinfo, GListHandle files, GAppLaunchContextHandle context, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_launch(appinfo, files, context, out error);
	}

	public static bool LaunchUris(this GAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle context, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_launch_uris(appinfo, uris, context, out error);
	}

	public static GAppInfoHandle LaunchUrisAsync(this GAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle context, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoExterns.g_app_info_launch_uris_async(appinfo, uris, context, cancellable, callback, user_data);
		return appinfo;
	}

	public static bool LaunchUrisFinish(this GAppInfoHandle appinfo, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_launch_uris_finish(appinfo, result, out error);
	}

	public static bool RemoveSupportsType(this GAppInfoHandle appinfo, string content_type, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_remove_supports_type(appinfo, content_type, out error);
	}

	public static bool SetAsDefaultForExtension(this GAppInfoHandle appinfo, string extension, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_set_as_default_for_extension(appinfo, extension, out error);
	}

	public static bool SetAsDefaultForType(this GAppInfoHandle appinfo, string content_type, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_set_as_default_for_type(appinfo, content_type, out error);
	}

	public static bool SetAsLastUsedForType(this GAppInfoHandle appinfo, string content_type, out GErrorHandle error)
	{
		return GAppInfoExterns.g_app_info_set_as_last_used_for_type(appinfo, content_type, out error);
	}

	public static bool ShouldShow(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_should_show(appinfo);
	}

	public static bool SupportsFiles(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_supports_files(appinfo);
	}

	public static bool SupportsUris(this GAppInfoHandle appinfo)
	{
		return GAppInfoExterns.g_app_info_supports_uris(appinfo);
	}

}

internal class GAppInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_add_supports_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_can_delete(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_can_remove_supports_type(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_delete(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoHandle g_app_info_dup(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_equal(GAppInfoHandle appinfo1, GAppInfoHandle appinfo2);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_info_get_commandline(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_info_get_description(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_info_get_display_name(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_info_get_executable(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_app_info_get_icon(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_info_get_id(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_info_get_name(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_app_info_get_supported_types(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_launch(GAppInfoHandle appinfo, GListHandle files, GAppLaunchContextHandle context, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_launch_uris(GAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle context, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_app_info_launch_uris_async(GAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle context, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_launch_uris_finish(GAppInfoHandle appinfo, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_remove_supports_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_set_as_default_for_extension(GAppInfoHandle appinfo, string extension, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_set_as_default_for_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_set_as_last_used_for_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_should_show(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_supports_files(GAppInfoHandle appinfo);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_app_info_supports_uris(GAppInfoHandle appinfo);
}
