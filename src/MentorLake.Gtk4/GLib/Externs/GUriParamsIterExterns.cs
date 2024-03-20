using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GUriParamsIterExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_uri_params_iter_init")]
	internal static extern void g_uri_params_iter_init(this GUriParamsIterHandle iter, string @params, nint length, string separators, GUriParamsFlags flags);

	[DllImport(Libraries.GLib, EntryPoint = "g_uri_params_iter_next")]
	internal static extern int g_uri_params_iter_next(this GUriParamsIterHandle iter, string[] attribute, string[] value, out GErrorHandle error);
}
