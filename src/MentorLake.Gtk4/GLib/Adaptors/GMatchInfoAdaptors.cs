using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMatchInfoAdaptors
{
    public static GRegexHandle GetRegex(this GMatchInfoHandle match_info)
    {
        return GMatchInfoExterns.g_match_info_get_regex(match_info);
    }

    public static string GetString(this GMatchInfoHandle match_info)
    {
        return GMatchInfoExterns.g_match_info_get_string(match_info);
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

    public static GMatchInfoHandle Free(this GMatchInfoHandle match_info)
    {
        GMatchInfoExterns.g_match_info_free(match_info);
        return match_info;
    }

    public static int Next(this GMatchInfoHandle match_info, out GErrorHandle error)
    {
        return GMatchInfoExterns.g_match_info_next(match_info, out error);
    }

    public static int Matches(this GMatchInfoHandle match_info)
    {
        return GMatchInfoExterns.g_match_info_matches(match_info);
    }

    public static int GetMatchCount(this GMatchInfoHandle match_info)
    {
        return GMatchInfoExterns.g_match_info_get_match_count(match_info);
    }

    public static int IsPartialMatch(this GMatchInfoHandle match_info)
    {
        return GMatchInfoExterns.g_match_info_is_partial_match(match_info);
    }

    public static string ExpandReferences(this GMatchInfoHandle match_info, string string_to_expand, out GErrorHandle error)
    {
        return GMatchInfoExterns.g_match_info_expand_references(match_info, string_to_expand, out error);
    }

    public static string Fetch(this GMatchInfoHandle match_info, int match_num)
    {
        return GMatchInfoExterns.g_match_info_fetch(match_info, match_num);
    }

    public static int FetchPos(this GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos)
    {
        return GMatchInfoExterns.g_match_info_fetch_pos(match_info, match_num, out start_pos, out end_pos);
    }

    public static string FetchNamed(this GMatchInfoHandle match_info, string name)
    {
        return GMatchInfoExterns.g_match_info_fetch_named(match_info, name);
    }

    public static int FetchNamedPos(this GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos)
    {
        return GMatchInfoExterns.g_match_info_fetch_named_pos(match_info, name, out start_pos, out end_pos);
    }

    public static string[] FetchAll(this GMatchInfoHandle match_info)
    {
        return GMatchInfoExterns.g_match_info_fetch_all(match_info);
    }
}
