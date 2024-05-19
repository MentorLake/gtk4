namespace MentorLake.Gtk4.Gio;

public interface GDesktopAppInfoLookupHandle
{
}

internal class GDesktopAppInfoLookupHandleImpl : BaseSafeHandle, GDesktopAppInfoLookupHandle
{
}

public static class GDesktopAppInfoLookupHandleExtensions
{
	public static GAppInfoHandle GetDefaultForUriScheme(this GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		return GDesktopAppInfoLookupExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

}

internal class GDesktopAppInfoLookupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoHandle g_desktop_app_info_lookup_get_default_for_uri_scheme(GDesktopAppInfoLookupHandle lookup, string uri_scheme);

}
