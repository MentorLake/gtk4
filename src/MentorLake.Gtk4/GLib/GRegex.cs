namespace MentorLake.Gtk4.GLib;

public class GRegexHandle : BaseSafeHandle
{
	public static GRegexHandle New(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_new(pattern, compile_options, match_options, out error);
	}

}

internal class GRegexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GRegexHandle g_regex_new(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error);

}

public struct GRegex
{
}
