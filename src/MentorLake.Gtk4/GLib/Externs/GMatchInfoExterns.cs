using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GMatchInfoExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_get_regex")]
	internal static extern GRegexHandle g_match_info_get_regex(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_get_string")]
	internal static extern string g_match_info_get_string(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_ref")]
	internal static extern GMatchInfoHandle g_match_info_ref(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_unref")]
	internal static extern void g_match_info_unref(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_free")]
	internal static extern void g_match_info_free(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_next")]
	internal static extern int g_match_info_next(this GMatchInfoHandle match_info, out GErrorHandle error);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_matches")]
	internal static extern int g_match_info_matches(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_get_match_count")]
	internal static extern int g_match_info_get_match_count(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_is_partial_match")]
	internal static extern int g_match_info_is_partial_match(this GMatchInfoHandle match_info);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_expand_references")]
	internal static extern string g_match_info_expand_references(this GMatchInfoHandle match_info, string string_to_expand, out GErrorHandle error);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_fetch")]
	internal static extern string g_match_info_fetch(this GMatchInfoHandle match_info, int match_num);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_fetch_pos")]
	internal static extern int g_match_info_fetch_pos(this GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_fetch_named")]
	internal static extern string g_match_info_fetch_named(this GMatchInfoHandle match_info, string name);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_fetch_named_pos")]
	internal static extern int g_match_info_fetch_named_pos(this GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos);

	[DllImport(Libraries.GLib, EntryPoint = "g_match_info_fetch_all")]
	internal static extern string[] g_match_info_fetch_all(this GMatchInfoHandle match_info);
}
