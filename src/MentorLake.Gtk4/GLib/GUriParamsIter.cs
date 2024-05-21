namespace MentorLake.Gtk4.GLib;

public class GUriParamsIterHandle : BaseSafeHandle
{
}


public static class GUriParamsIterHandleExtensions
{
	public static GUriParamsIterHandle Init(this GUriParamsIterHandle iter, string @params, UIntPtr length, string separators, GUriParamsFlags flags)
	{
		GUriParamsIterExterns.g_uri_params_iter_init(iter, @params, length, separators, flags);
		return iter;
	}

	public static bool Next(this GUriParamsIterHandle iter, out string attribute, out string value, out GErrorHandle error)
	{
		return GUriParamsIterExterns.g_uri_params_iter_next(iter, out attribute, out value, out error);
	}

}
internal class GUriParamsIterExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_uri_params_iter_init(GUriParamsIterHandle iter, string @params, UIntPtr length, string separators, GUriParamsFlags flags);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_uri_params_iter_next(GUriParamsIterHandle iter, out string attribute, out string value, out GErrorHandle error);

}

public struct GUriParamsIter
{
}
