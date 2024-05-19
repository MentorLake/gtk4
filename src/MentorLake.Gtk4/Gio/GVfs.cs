using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GVfsHandle : GObjectHandle
{
	public static GVfsHandle GetDefault()
	{
		return GVfsExterns.g_vfs_get_default();
	}

	public static GVfsHandle GetLocal()
	{
		return GVfsExterns.g_vfs_get_local();
	}

}

public static class GVfsHandleExtensions
{
	public static GFileHandle GetFileForPath(this GVfsHandle vfs, string path)
	{
		return GVfsExterns.g_vfs_get_file_for_path(vfs, path);
	}

	public static GFileHandle GetFileForUri(this GVfsHandle vfs, string uri)
	{
		return GVfsExterns.g_vfs_get_file_for_uri(vfs, uri);
	}

	public static string GetSupportedUriSchemes(this GVfsHandle vfs)
	{
		return GVfsExterns.g_vfs_get_supported_uri_schemes(vfs);
	}

	public static bool IsActive(this GVfsHandle vfs)
	{
		return GVfsExterns.g_vfs_is_active(vfs);
	}

	public static GFileHandle ParseName(this GVfsHandle vfs, string parse_name)
	{
		return GVfsExterns.g_vfs_parse_name(vfs, parse_name);
	}

	public static bool RegisterUriScheme(this GVfsHandle vfs, string scheme, GVfsFileLookupFunc uri_func, IntPtr uri_data, GDestroyNotify uri_destroy, GVfsFileLookupFunc parse_name_func, IntPtr parse_name_data, GDestroyNotify parse_name_destroy)
	{
		return GVfsExterns.g_vfs_register_uri_scheme(vfs, scheme, uri_func, uri_data, uri_destroy, parse_name_func, parse_name_data, parse_name_destroy);
	}

	public static bool UnregisterUriScheme(this GVfsHandle vfs, string scheme)
	{
		return GVfsExterns.g_vfs_unregister_uri_scheme(vfs, scheme);
	}

}

internal class GVfsExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_vfs_get_file_for_path(GVfsHandle vfs, string path);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_vfs_get_file_for_uri(GVfsHandle vfs, string uri);

	[DllImport(Libraries.Gio)]
	internal static extern string g_vfs_get_supported_uri_schemes(GVfsHandle vfs);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_vfs_is_active(GVfsHandle vfs);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_vfs_parse_name(GVfsHandle vfs, string parse_name);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_vfs_register_uri_scheme(GVfsHandle vfs, string scheme, GVfsFileLookupFunc uri_func, IntPtr uri_data, GDestroyNotify uri_destroy, GVfsFileLookupFunc parse_name_func, IntPtr parse_name_data, GDestroyNotify parse_name_destroy);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_vfs_unregister_uri_scheme(GVfsHandle vfs, string scheme);

	[DllImport(Libraries.Gio)]
	internal static extern GVfsHandle g_vfs_get_default();

	[DllImport(Libraries.Gio)]
	internal static extern GVfsHandle g_vfs_get_local();

}
