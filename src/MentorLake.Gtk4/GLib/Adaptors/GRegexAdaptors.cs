using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRegexAdaptors
{
	public static GRegexHandle Ref(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_ref(regex);
	}

	public static GRegexHandle Unref(this GRegexHandle regex)
	{
		GRegexExterns.g_regex_unref(regex);
		return regex;
	}

	public static string GetPattern(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_pattern(regex);
	}

	public static int GetMaxBackref(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_max_backref(regex);
	}

	public static int GetCaptureCount(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_capture_count(regex);
	}

	public static int GetHasCrOrLf(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_has_cr_or_lf(regex);
	}

	public static int GetMaxLookbehind(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_max_lookbehind(regex);
	}

	public static int GetStringNumber(this GRegexHandle regex, string name)
	{
		return GRegexExterns.g_regex_get_string_number(regex, name);
	}

	public static GRegexCompileFlags GetCompileFlags(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_compile_flags(regex);
	}

	public static GRegexMatchFlags GetMatchFlags(this GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_match_flags(regex);
	}

	public static int Match(this GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info)
	{
		return GRegexExterns.g_regex_match(regex, @string, match_options, out match_info);
	}

	public static int MatchFull(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_match_full(regex, @string, string_len, start_position, match_options, out match_info, out error);
	}

	public static int MatchAll(this GRegexHandle regex, string @string, GRegexMatchFlags match_options, out GMatchInfoHandle match_info)
	{
		return GRegexExterns.g_regex_match_all(regex, @string, match_options, out match_info);
	}

	public static int MatchAllFull(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, out GMatchInfoHandle match_info, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_match_all_full(regex, @string, string_len, start_position, match_options, out match_info, out error);
	}

	public static string[] Split(this GRegexHandle regex, string @string, GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_split(regex, @string, match_options);
	}

	public static string[] SplitFull(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, int max_tokens, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_split_full(regex, @string, string_len, start_position, match_options, max_tokens, out error);
	}

	public static string Replace(this GRegexHandle regex, string @string, nint string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_replace(regex, @string, string_len, start_position, replacement, match_options, out error);
	}

	public static string ReplaceLiteral(this GRegexHandle regex, string @string, nint string_len, int start_position, string replacement, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_replace_literal(regex, @string, string_len, start_position, replacement, match_options, out error);
	}

	public static string ReplaceEval(this GRegexHandle regex, string @string, nint string_len, int start_position, GRegexMatchFlags match_options, GRegexEvalCallback eval, IntPtr user_data, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_replace_eval(regex, @string, string_len, start_position, match_options, eval, user_data, out error);
	}
}
