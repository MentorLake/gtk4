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

public class GSocketAddressHandle : GObjectHandle, GSocketConnectableHandle
{
	public static GSocketAddressHandle NewFromNative(IntPtr native, int len)
	{
		return GSocketAddressExterns.g_socket_address_new_from_native(native, len);
	}

}

public static class GSocketAddressHandleExtensions
{
	public static GSocketFamily GetFamily(this GSocketAddressHandle address)
	{
		return GSocketAddressExterns.g_socket_address_get_family(address);
	}

	public static int GetNativeSize(this GSocketAddressHandle address)
	{
		return GSocketAddressExterns.g_socket_address_get_native_size(address);
	}

	public static bool ToNative(this GSocketAddressHandle address, IntPtr dest, int destlen, out GErrorHandle error)
	{
		return GSocketAddressExterns.g_socket_address_to_native(address, dest, destlen, out error);
	}

}

internal class GSocketAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_address_new_from_native(IntPtr native, int len);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketFamily g_socket_address_get_family(GSocketAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_address_get_native_size(GSocketAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_address_to_native(GSocketAddressHandle address, IntPtr dest, int destlen, out GErrorHandle error);
}
