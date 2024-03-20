using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GErrorAdaptors
{
	public static GErrorHandle Free(this GErrorHandle error)
	{
		GErrorExterns.g_error_free(error);
		return error;
	}

	public static GErrorHandle Copy(this GErrorHandle error)
	{
		return GErrorExterns.g_error_copy(error);
	}

	public static int Matches(this GErrorHandle error, GQuark domain, int code)
	{
		return GErrorExterns.g_error_matches(error, domain, code);
	}

	public static string GVariantParseErrorPrintContext(this GErrorHandle error, string source_str)
	{
		return GErrorExterns.g_variant_parse_error_print_context(error, source_str);
	}

	public static GErrorHandle NewLiteral(GQuark domain, int code, string message)
	{
		return GErrorExterns.g_error_new_literal(domain, code, message);
	}

	public static GErrorHandle NewValist(GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new_valist(domain, code, format, @__arglist);
	}
}
