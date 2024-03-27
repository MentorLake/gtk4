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

public class GInetAddressHandle : GObjectHandle
{
	public static GInetAddressHandle NewAny(GSocketFamily family)
	{
		return GInetAddressExterns.g_inet_address_new_any(family);
	}
	public static GInetAddressHandle NewFromBytes(byte[] bytes, GSocketFamily family)
	{
		return GInetAddressExterns.g_inet_address_new_from_bytes(bytes, family);
	}
	public static GInetAddressHandle NewFromString(string @string)
	{
		return GInetAddressExterns.g_inet_address_new_from_string(@string);
	}
	public static GInetAddressHandle NewLoopback(GSocketFamily family)
	{
		return GInetAddressExterns.g_inet_address_new_loopback(family);
	}
}

public static class GInetAddressSignals
{
}

public static class GInetAddressHandleExtensions
{
	public static bool Equal(this GInetAddressHandle address, GInetAddressHandle other_address)
	{
		return GInetAddressExterns.g_inet_address_equal(address, other_address);
	}

	public static GSocketFamily GetFamily(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_family(address);
	}

	public static bool GetIsAny(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_any(address);
	}

	public static bool GetIsLinkLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_link_local(address);
	}

	public static bool GetIsLoopback(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_loopback(address);
	}

	public static bool GetIsMcGlobal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_global(address);
	}

	public static bool GetIsMcLinkLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_link_local(address);
	}

	public static bool GetIsMcNodeLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_node_local(address);
	}

	public static bool GetIsMcOrgLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_org_local(address);
	}

	public static bool GetIsMcSiteLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_site_local(address);
	}

	public static bool GetIsMulticast(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_multicast(address);
	}

	public static bool GetIsSiteLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_site_local(address);
	}

	public static int GetNativeSize(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_native_size(address);
	}

	public static byte[] ToBytes(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_to_bytes(address);
	}

	public static string ToString(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_to_string(address);
	}

}

internal class GInetAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_equal(GInetAddressHandle address, GInetAddressHandle other_address);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketFamily g_inet_address_get_family(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_any(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_link_local(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_loopback(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_global(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_link_local(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_node_local(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_org_local(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_site_local(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_multicast(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_site_local(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern int g_inet_address_get_native_size(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern byte[] g_inet_address_to_bytes(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern string g_inet_address_to_string(GInetAddressHandle address);
	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_any(GSocketFamily family);
	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_from_bytes(byte[] bytes, GSocketFamily family);
	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_from_string(string @string);
	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_loopback(GSocketFamily family);
}
