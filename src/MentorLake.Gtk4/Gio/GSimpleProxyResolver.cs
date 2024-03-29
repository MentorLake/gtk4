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

public class GSimpleProxyResolverHandle : GObjectHandle
{
	public static GProxyResolverHandle New(string default_proxy, string[] ignore_hosts)
	{
		return GSimpleProxyResolverExterns.g_simple_proxy_resolver_new(default_proxy, ignore_hosts);
	}

}

public static class GSimpleProxyResolverHandleExtensions
{
	public static GSimpleProxyResolverHandle SetDefaultProxy(this GSimpleProxyResolverHandle resolver, string default_proxy)
	{
		GSimpleProxyResolverExterns.g_simple_proxy_resolver_set_default_proxy(resolver, default_proxy);
		return resolver;
	}

	public static GSimpleProxyResolverHandle SetIgnoreHosts(this GSimpleProxyResolverHandle resolver, string[] ignore_hosts)
	{
		GSimpleProxyResolverExterns.g_simple_proxy_resolver_set_ignore_hosts(resolver, ignore_hosts);
		return resolver;
	}

	public static GSimpleProxyResolverHandle SetUriProxy(this GSimpleProxyResolverHandle resolver, string uri_scheme, string proxy)
	{
		GSimpleProxyResolverExterns.g_simple_proxy_resolver_set_uri_proxy(resolver, uri_scheme, proxy);
		return resolver;
	}

}

internal class GSimpleProxyResolverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_proxy_resolver_set_default_proxy(GSimpleProxyResolverHandle resolver, string default_proxy);
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_proxy_resolver_set_ignore_hosts(GSimpleProxyResolverHandle resolver, string[] ignore_hosts);
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_proxy_resolver_set_uri_proxy(GSimpleProxyResolverHandle resolver, string uri_scheme, string proxy);
	[DllImport(Libraries.Gio)]
	internal static extern GProxyResolverHandle g_simple_proxy_resolver_new(string default_proxy, string[] ignore_hosts);
}
