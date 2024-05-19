namespace MentorLake.Gtk4.Gio;

public class GNetworkAddressHandle : GObjectHandle, GSocketConnectableHandle
{
	public static GNetworkAddressHandle New(string hostname, ushort port)
	{
		return GNetworkAddressExterns.g_network_address_new(hostname, port);
	}

	public static GNetworkAddressHandle NewLoopback(ushort port)
	{
		return GNetworkAddressExterns.g_network_address_new_loopback(port);
	}

	public static GSocketConnectableHandle Parse(string host_and_port, ushort default_port, out GErrorHandle error)
	{
		return GNetworkAddressExterns.g_network_address_parse(host_and_port, default_port, out error);
	}

	public static GSocketConnectableHandle ParseUri(string uri, ushort default_port, out GErrorHandle error)
	{
		return GNetworkAddressExterns.g_network_address_parse_uri(uri, default_port, out error);
	}

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
	internal static extern GNetworkAddressHandle g_network_address_new(string hostname, ushort port);

	[DllImport(Libraries.Gio)]
	internal static extern GNetworkAddressHandle g_network_address_new_loopback(ushort port);

	[DllImport(Libraries.Gio)]
	internal static extern string g_network_address_get_hostname(GNetworkAddressHandle addr);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_network_address_get_port(GNetworkAddressHandle addr);

	[DllImport(Libraries.Gio)]
	internal static extern string g_network_address_get_scheme(GNetworkAddressHandle addr);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectableHandle g_network_address_parse(string host_and_port, ushort default_port, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectableHandle g_network_address_parse_uri(string uri, ushort default_port, out GErrorHandle error);

}
