using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GUriParamsIterAdaptors
{
    public static GUriParamsIterHandle Init(this GUriParamsIterHandle iter, string @params, nint length, string separators, GUriParamsFlags flags)
    {
        GUriParamsIterExterns.g_uri_params_iter_init(iter, @params, length, separators, flags);
        return iter;
    }

    public static int Next(this GUriParamsIterHandle iter, string[] attribute, string[] value, out GErrorHandle error)
    {
        return GUriParamsIterExterns.g_uri_params_iter_next(iter, attribute, value, out error);
    }
}
