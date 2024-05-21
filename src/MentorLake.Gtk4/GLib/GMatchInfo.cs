namespace MentorLake.Gtk4.GLib;

public class GMatchInfoHandle : BaseSafeHandle
{
}


public static class GMatchInfoHandleExtensions
{
	public static string ExpandReferences(this GMatchInfoHandle match_info, string string_to_expand, out GErrorHandle error)
	{
		return GMatchInfoExterns.g_match_info_expand_references(match_info, string_to_expand, out error);
	}

	public static string Fetch(this GMatchInfoHandle match_info, int match_num)
	{
		return GMatchInfoExterns.g_match_info_fetch(match_info, match_num);
	}

	public static IntPtr FetchAll(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_fetch_all(match_info);
	}

	public static string FetchNamed(this GMatchInfoHandle match_info, string name)
	{
		return GMatchInfoExterns.g_match_info_fetch_named(match_info, name);
	}

	public static bool FetchNamedPos(this GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos)
	{
		return GMatchInfoExterns.g_match_info_fetch_named_pos(match_info, name, out start_pos, out end_pos);
	}

	public static bool FetchPos(this GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos)
	{
		return GMatchInfoExterns.g_match_info_fetch_pos(match_info, match_num, out start_pos, out end_pos);
	}

	public static GMatchInfoHandle Free(this GMatchInfoHandle match_info)
	{
		GMatchInfoExterns.g_match_info_free(match_info);
		return match_info;
	}

	public static int GetMatchCount(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_get_match_count(match_info);
	}

	public static GRegexHandle GetRegex(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_get_regex(match_info);
	}

	public static string GetString(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_get_string(match_info);
	}

	public static bool IsPartialMatch(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_is_partial_match(match_info);
	}

	public static bool Matches(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_matches(match_info);
	}

	public static bool Next(this GMatchInfoHandle match_info, out GErrorHandle error)
	{
		return GMatchInfoExterns.g_match_info_next(match_info, out error);
	}

	public static GMatchInfoHandle Ref(this GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_ref(match_info);
	}

	public static GMatchInfoHandle Unref(this GMatchInfoHandle match_info)
	{
		GMatchInfoExterns.g_match_info_unref(match_info);
		return match_info;
	}

}
internal class GMatchInfoExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern string g_match_info_expand_references(GMatchInfoHandle match_info, string string_to_expand, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_match_info_fetch(GMatchInfoHandle match_info, int match_num);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_match_info_fetch_all(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern string g_match_info_fetch_named(GMatchInfoHandle match_info, string name);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_match_info_fetch_named_pos(GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_match_info_fetch_pos(GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos);

	[DllImport(Libraries.GLib)]
	internal static extern void g_match_info_free(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern int g_match_info_get_match_count(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern GRegexHandle g_match_info_get_regex(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern string g_match_info_get_string(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_match_info_is_partial_match(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_match_info_matches(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_match_info_next(GMatchInfoHandle match_info, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GMatchInfoHandle g_match_info_ref(GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib)]
	internal static extern void g_match_info_unref(GMatchInfoHandle match_info);

}

public struct GMatchInfo
{
}
