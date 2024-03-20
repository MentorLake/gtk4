using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GUriAdaptors
{
    public static GUriHandle Ref(this GUriHandle uri)
    {
        return GUriExterns.g_uri_ref(uri);
    }

    public static GUriHandle Unref(this GUriHandle uri)
    {
        GUriExterns.g_uri_unref(uri);
        return uri;
    }

    public static GUriHandle ParseRelative(this GUriHandle base_uri, string uri_ref, GUriFlags flags, out GErrorHandle error)
    {
        return GUriExterns.g_uri_parse_relative(base_uri, uri_ref, flags, out error);
    }

    public static string ToString(this GUriHandle uri)
    {
        return GUriExterns.g_uri_to_string(uri);
    }

    public static string ToStringPartial(this GUriHandle uri, GUriHideFlags flags)
    {
        return GUriExterns.g_uri_to_string_partial(uri, flags);
    }

    public static string GetScheme(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_scheme(uri);
    }

    public static string GetUserinfo(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_userinfo(uri);
    }

    public static string GetUser(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_user(uri);
    }

    public static string GetPassword(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_password(uri);
    }

    public static string GetAuthParams(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_auth_params(uri);
    }

    public static string GetHost(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_host(uri);
    }

    public static int GetPort(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_port(uri);
    }

    public static string GetPath(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_path(uri);
    }

    public static string GetQuery(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_query(uri);
    }

    public static string GetFragment(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_fragment(uri);
    }

    public static GUriFlags GetFlags(this GUriHandle uri)
    {
        return GUriExterns.g_uri_get_flags(uri);
    }
}
