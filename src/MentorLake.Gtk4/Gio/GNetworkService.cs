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

public class GNetworkServiceHandle : GObjectHandle
{
	public static GNetworkServiceHandle New(string service, string protocol, string domain)
	{
		return GNetworkServiceExterns.g_network_service_new(service, protocol, domain);
	}
}

public static class GNetworkServiceSignals
{
}

public static class GNetworkServiceHandleExtensions
{
	public static string GetDomain(this GNetworkServiceHandle srv)
	{
		return GNetworkServiceExterns.g_network_service_get_domain(srv);
	}

	public static string GetProtocol(this GNetworkServiceHandle srv)
	{
		return GNetworkServiceExterns.g_network_service_get_protocol(srv);
	}

	public static string GetScheme(this GNetworkServiceHandle srv)
	{
		return GNetworkServiceExterns.g_network_service_get_scheme(srv);
	}

	public static string GetService(this GNetworkServiceHandle srv)
	{
		return GNetworkServiceExterns.g_network_service_get_service(srv);
	}

	public static GNetworkServiceHandle SetScheme(this GNetworkServiceHandle srv, string scheme)
	{
		GNetworkServiceExterns.g_network_service_set_scheme(srv, scheme);
		return srv;
	}

}

internal class GNetworkServiceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_network_service_get_domain(GNetworkServiceHandle srv);
	[DllImport(Libraries.Gio)]
	internal static extern string g_network_service_get_protocol(GNetworkServiceHandle srv);
	[DllImport(Libraries.Gio)]
	internal static extern string g_network_service_get_scheme(GNetworkServiceHandle srv);
	[DllImport(Libraries.Gio)]
	internal static extern string g_network_service_get_service(GNetworkServiceHandle srv);
	[DllImport(Libraries.Gio)]
	internal static extern void g_network_service_set_scheme(GNetworkServiceHandle srv, string scheme);
	[DllImport(Libraries.Gio)]
	internal static extern GNetworkServiceHandle g_network_service_new(string service, string protocol, string domain);
}
