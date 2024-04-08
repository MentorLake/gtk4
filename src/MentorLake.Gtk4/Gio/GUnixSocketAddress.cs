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

public class GUnixSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
	public static GUnixSocketAddressHandle New(string path)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_new(path);
	}

	public static GUnixSocketAddressHandle NewAbstract(string path, int path_len)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_new_abstract(path, path_len);
	}

	public static GUnixSocketAddressHandle NewWithType(string path, int path_len, GUnixSocketAddressType type)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_new_with_type(path, path_len, type);
	}

	public static bool AbstractNamesSupported()
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_abstract_names_supported();
	}

}

public static class GUnixSocketAddressHandleExtensions
{
	public static GUnixSocketAddressType GetAddressType(this GUnixSocketAddressHandle address)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_get_address_type(address);
	}

	public static bool GetIsAbstract(this GUnixSocketAddressHandle address)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_get_is_abstract(address);
	}

	public static string GetPath(this GUnixSocketAddressHandle address)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_get_path(address);
	}

	public static int GetPathLen(this GUnixSocketAddressHandle address)
	{
		return GUnixSocketAddressExterns.g_unix_socket_address_get_path_len(address);
	}

}

internal class GUnixSocketAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixSocketAddressHandle g_unix_socket_address_new(string path);
	[DllImport(Libraries.Gio)]
	internal static extern GUnixSocketAddressHandle g_unix_socket_address_new_abstract(string path, int path_len);
	[DllImport(Libraries.Gio)]
	internal static extern GUnixSocketAddressHandle g_unix_socket_address_new_with_type(string path, int path_len, GUnixSocketAddressType type);
	[DllImport(Libraries.Gio)]
	internal static extern GUnixSocketAddressType g_unix_socket_address_get_address_type(GUnixSocketAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_socket_address_get_is_abstract(GUnixSocketAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern string g_unix_socket_address_get_path(GUnixSocketAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_socket_address_get_path_len(GUnixSocketAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_socket_address_abstract_names_supported();
}
