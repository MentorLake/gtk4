using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GOptionGroupAdaptors
{
	public static GOptionGroupHandle SetParseHooks(this GOptionGroupHandle group, GOptionParseFunc pre_parse_func, GOptionParseFunc post_parse_func)
	{
		GOptionGroupExterns.g_option_group_set_parse_hooks(group, pre_parse_func, post_parse_func);
		return group;
	}

	public static GOptionGroupHandle SetErrorHook(this GOptionGroupHandle group, GOptionErrorFunc error_func)
	{
		GOptionGroupExterns.g_option_group_set_error_hook(group, error_func);
		return group;
	}

	public static GOptionGroupHandle Free(this GOptionGroupHandle group)
	{
		GOptionGroupExterns.g_option_group_free(group);
		return group;
	}

	public static GOptionGroupHandle Ref(this GOptionGroupHandle group)
	{
		return GOptionGroupExterns.g_option_group_ref(group);
	}

	public static GOptionGroupHandle Unref(this GOptionGroupHandle group)
	{
		GOptionGroupExterns.g_option_group_unref(group);
		return group;
	}

	public static GOptionGroupHandle AddEntries(this GOptionGroupHandle group, GOptionEntryHandle entries)
	{
		GOptionGroupExterns.g_option_group_add_entries(group, entries);
		return group;
	}

	public static GOptionGroupHandle SetTranslateFunc(this GOptionGroupHandle group, GTranslateFunc func, IntPtr data, GDestroyNotify destroy_notify)
	{
		GOptionGroupExterns.g_option_group_set_translate_func(group, func, data, destroy_notify);
		return group;
	}

	public static GOptionGroupHandle SetTranslationDomain(this GOptionGroupHandle group, string domain)
	{
		GOptionGroupExterns.g_option_group_set_translation_domain(group, domain);
		return group;
	}
}
