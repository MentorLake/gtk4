namespace MentorLake.Gtk4.GLib;

public class GRegexHandle : BaseSafeHandle
{
	public static GRegexHandle New(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_new(pattern, compile_options, match_options, out error);
	}

}


public static class GRegexHandleExtensions
{
	public static int GetCaptureCount(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_capture_count(regex);
	}

	public static GRegexCompileFlags GetCompileFlags(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_compile_flags(regex);
	}

	public static bool GetHasCrOrLf(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_has_cr_or_lf(regex);
	}

	public static GRegexMatchFlags GetMatchFlags(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_match_flags(regex);
	}

	public static int GetMaxBackref(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_max_backref(regex);
	}

	public static int GetMaxLookbehind(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_max_lookbehind(regex);
	}

	public static string GetPattern(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_pattern(regex);
	}

	public static int GetStringNumber(this GRegexHandle regex, string name)
	{
		return GRegexExterns.g_regex_get_string_number(regex, name);
	}

	public static bool Match(this GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info)
	{
		return GRegexExterns.g_regex_match(regex, @string, match_options, out match_info);
	}

	public static bool MatchAll(this GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info)
	{
		return GRegexExterns.g_regex_match_all(regex, @string, match_options, out match_info);
	}

	public static bool MatchAllFull(this GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_match_all_full(regex, @string, string_len, start_position, match_options, out match_info, out error);
	}

	public static bool MatchFull(this GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_match_full(regex, @string, string_len, start_position, match_options, out match_info, out error);
	}

	public static GRegexHandle Ref(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_ref(regex);
	}

	public static string Replace(this GRegexHandle regex, string @string, UIntPtr string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_replace(regex, @string, string_len, start_position, replacement, match_options, out error);
	}

	public static string ReplaceEval(this GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, GRegexEvalCallback eval, IntPtr user_data, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_replace_eval(regex, @string, string_len, start_position, match_options, eval, user_data, out error);
	}

	public static string ReplaceLiteral(this GRegexHandle regex, string @string, UIntPtr string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_replace_literal(regex, @string, string_len, start_position, replacement, match_options, out error);
	}

	public static IntPtr Split(this GRegexHandle regex, string @string, GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_split(regex, @string, match_options);
	}

	public static IntPtr SplitFull(this GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, int max_tokens, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_split_full(regex, @string, string_len, start_position, match_options, max_tokens, out error);
	}

	public static GRegexHandle Unref(this GRegexHandle regex)
	{
		GRegexExterns.g_regex_unref(regex);
		return regex;
	}

}
internal class GRegexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GRegexHandle g_regex_new(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_regex_get_capture_count(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern GRegexCompileFlags g_regex_get_compile_flags(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_regex_get_has_cr_or_lf(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern GRegexMatchFlags g_regex_get_match_flags(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern int g_regex_get_max_backref(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern int g_regex_get_max_lookbehind(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern string g_regex_get_pattern(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern int g_regex_get_string_number(GRegexHandle regex, string name);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_regex_match(GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_regex_match_all(GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_regex_match_all_full(GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_regex_match_full(GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GRegexHandle g_regex_ref(GRegexHandle regex);

	[DllImport(Libraries.GLib)]
	internal static extern string g_regex_replace(GRegexHandle regex, string @string, UIntPtr string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_regex_replace_eval(GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, GRegexEvalCallback eval, IntPtr user_data, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_regex_replace_literal(GRegexHandle regex, string @string, UIntPtr string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_regex_split(GRegexHandle regex, string @string, GRegexMatchFlags match_options);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_regex_split_full(GRegexHandle regex, string @string, UIntPtr string_len, int start_position, GRegexMatchFlags match_options, int max_tokens, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_regex_unref(GRegexHandle regex);

}

public struct GRegex
{
}
