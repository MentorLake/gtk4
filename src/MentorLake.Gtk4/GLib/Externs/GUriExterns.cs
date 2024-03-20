using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GUriExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_uri_ref")]
	internal static extern GUriHandle g_uri_ref(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_unref")]
	internal static extern void g_uri_unref(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_parse_relative")]
	internal static extern GUriHandle g_uri_parse_relative(this GUriHandle base_uri, string uri_ref, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_to_string")]
	internal static extern string g_uri_to_string(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_to_string_partial")]
	internal static extern string g_uri_to_string_partial(this GUriHandle uri, GUriHideFlags flags);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_scheme")]
	internal static extern string g_uri_get_scheme(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_userinfo")]
	internal static extern string g_uri_get_userinfo(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_user")]
	internal static extern string g_uri_get_user(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_password")]
	internal static extern string g_uri_get_password(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_auth_params")]
	internal static extern string g_uri_get_auth_params(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_host")]
	internal static extern string g_uri_get_host(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_port")]
	internal static extern int g_uri_get_port(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_path")]
	internal static extern string g_uri_get_path(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_query")]
	internal static extern string g_uri_get_query(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_fragment")]
	internal static extern string g_uri_get_fragment(this GUriHandle uri);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_get_flags")]
	internal static extern GUriFlags g_uri_get_flags(this GUriHandle uri);
}
