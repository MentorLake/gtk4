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

public class GNetworkAddressHandle : GObjectHandle
{
	public static GNetworkAddressHandle New(string hostname, ushort port)
	{
		return GNetworkAddressExterns.g_network_address_new(hostname, port);
	}
	public static GNetworkAddressHandle NewLoopback(ushort port)
	{
		return GNetworkAddressExterns.g_network_address_new_loopback(port);
	}
}

public static class GNetworkAddressSignals
{
}

public static class GNetworkAddressHandleExtensions
{
	public static string GetHostname(this GNetworkAddressHandle addr)
	{
		return GNetworkAddressExterns.g_network_address_get_hostname(addr);
	}

	public static ushort GetPort(this GNetworkAddressHandle addr)
	{
		return GNetworkAddressExterns.g_network_address_get_port(addr);
	}

	public static string GetScheme(this GNetworkAddressHandle addr)
	{
		return GNetworkAddressExterns.g_network_address_get_scheme(addr);
	}

}

internal class GNetworkAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_network_address_get_hostname(GNetworkAddressHandle addr);
	[DllImport(Libraries.Gio)]
	internal static extern ushort g_network_address_get_port(GNetworkAddressHandle addr);
	[DllImport(Libraries.Gio)]
	internal static extern string g_network_address_get_scheme(GNetworkAddressHandle addr);
	[DllImport(Libraries.Gio)]
	internal static extern GNetworkAddressHandle g_network_address_new(string hostname, ushort port);
	[DllImport(Libraries.Gio)]
	internal static extern GNetworkAddressHandle g_network_address_new_loopback(ushort port);
}
