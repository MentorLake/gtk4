namespace MentorLake.Gtk4.GLib;

public class GErrorHandle : BaseSafeHandle
{
	public static GErrorHandle New(GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new(domain, code, format, @__arglist);
	}

	public static GErrorHandle NewLiteral(GQuark domain, int code, string message)
	{
		return GErrorExterns.g_error_new_literal(domain, code, message);
	}

	public static GErrorHandle NewValist(GQuark domain, int code, string format, IntPtr args)
	{
		return GErrorExterns.g_error_new_valist(domain, code, format, args);
	}

}


public static class GErrorHandleExtensions
{
	public static GErrorHandle Copy(this GErrorHandle error)
	{
		return GErrorExterns.g_error_copy(error);
	}

	public static GErrorHandle Free(this GErrorHandle error)
	{
		GErrorExterns.g_error_free(error);
		return error;
	}

	public static bool Matches(this GErrorHandle error, GQuark domain, int code)
	{
		return GErrorExterns.g_error_matches(error, domain, code);
	}

}
internal class GErrorExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_new(GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_new_literal(GQuark domain, int code, string message);

	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_new_valist(GQuark domain, int code, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_copy(GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_error_free(GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_error_matches(GErrorHandle error, GQuark domain, int code);

}

public struct GError
{
	public GQuark domain;
	public int code;
	public string message;
}
