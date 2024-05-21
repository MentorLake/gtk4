namespace MentorLake.Gtk4.GLib;

public class GOptionContextHandle : BaseSafeHandle
{
}


public static class GOptionContextHandleExtensions
{
	public static GOptionContextHandle AddGroup(this GOptionContextHandle context, GOptionGroupHandle group)
	{
		GOptionContextExterns.g_option_context_add_group(context, group);
		return context;
	}

	public static GOptionContextHandle AddMainEntries(this GOptionContextHandle context, GOptionEntry[] entries, string translation_domain)
	{
		GOptionContextExterns.g_option_context_add_main_entries(context, entries, translation_domain);
		return context;
	}

	public static GOptionContextHandle Free(this GOptionContextHandle context)
	{
		GOptionContextExterns.g_option_context_free(context);
		return context;
	}

	public static string GetDescription(this GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_description(context);
	}

	public static string GetHelp(this GOptionContextHandle context, bool main_help, GOptionGroupHandle group)
	{
		return GOptionContextExterns.g_option_context_get_help(context, main_help, group);
	}

	public static bool GetHelpEnabled(this GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_help_enabled(context);
	}

	public static bool GetIgnoreUnknownOptions(this GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_ignore_unknown_options(context);
	}

	public static GOptionGroupHandle GetMainGroup(this GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_main_group(context);
	}

	public static bool GetStrictPosix(this GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_strict_posix(context);
	}

	public static string GetSummary(this GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_summary(context);
	}

	public static bool Parse(this GOptionContextHandle context, ref int argc, ref string[] argv, out GErrorHandle error)
	{
		return GOptionContextExterns.g_option_context_parse(context, ref argc, ref argv, out error);
	}

	public static bool ParseStrv(this GOptionContextHandle context, ref string[] arguments, out GErrorHandle error)
	{
		return GOptionContextExterns.g_option_context_parse_strv(context, ref arguments, out error);
	}

	public static GOptionContextHandle SetDescription(this GOptionContextHandle context, string description)
	{
		GOptionContextExterns.g_option_context_set_description(context, description);
		return context;
	}

	public static GOptionContextHandle SetHelpEnabled(this GOptionContextHandle context, bool help_enabled)
	{
		GOptionContextExterns.g_option_context_set_help_enabled(context, help_enabled);
		return context;
	}

	public static GOptionContextHandle SetIgnoreUnknownOptions(this GOptionContextHandle context, bool ignore_unknown)
	{
		GOptionContextExterns.g_option_context_set_ignore_unknown_options(context, ignore_unknown);
		return context;
	}

	public static GOptionContextHandle SetMainGroup(this GOptionContextHandle context, GOptionGroupHandle group)
	{
		GOptionContextExterns.g_option_context_set_main_group(context, group);
		return context;
	}

	public static GOptionContextHandle SetStrictPosix(this GOptionContextHandle context, bool strict_posix)
	{
		GOptionContextExterns.g_option_context_set_strict_posix(context, strict_posix);
		return context;
	}

	public static GOptionContextHandle SetSummary(this GOptionContextHandle context, string summary)
	{
		GOptionContextExterns.g_option_context_set_summary(context, summary);
		return context;
	}

	public static GOptionContextHandle SetTranslateFunc(this GOptionContextHandle context, GTranslateFunc func, IntPtr data, GDestroyNotify destroy_notify)
	{
		GOptionContextExterns.g_option_context_set_translate_func(context, func, data, destroy_notify);
		return context;
	}

	public static GOptionContextHandle SetTranslationDomain(this GOptionContextHandle context, string domain)
	{
		GOptionContextExterns.g_option_context_set_translation_domain(context, domain);
		return context;
	}

}
internal class GOptionContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_add_group(GOptionContextHandle context, GOptionGroupHandle group);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_add_main_entries(GOptionContextHandle context, GOptionEntry[] entries, string translation_domain);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_free(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern string g_option_context_get_description(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern string g_option_context_get_help(GOptionContextHandle context, bool main_help, GOptionGroupHandle group);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_option_context_get_help_enabled(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_option_context_get_ignore_unknown_options(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern GOptionGroupHandle g_option_context_get_main_group(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_option_context_get_strict_posix(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern string g_option_context_get_summary(GOptionContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_option_context_parse(GOptionContextHandle context, ref int argc, ref string[] argv, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_option_context_parse_strv(GOptionContextHandle context, ref string[] arguments, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_description(GOptionContextHandle context, string description);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_help_enabled(GOptionContextHandle context, bool help_enabled);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_ignore_unknown_options(GOptionContextHandle context, bool ignore_unknown);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_main_group(GOptionContextHandle context, GOptionGroupHandle group);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_strict_posix(GOptionContextHandle context, bool strict_posix);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_summary(GOptionContextHandle context, string summary);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_translate_func(GOptionContextHandle context, GTranslateFunc func, IntPtr data, GDestroyNotify destroy_notify);

	[DllImport(Libraries.GLib)]
	internal static extern void g_option_context_set_translation_domain(GOptionContextHandle context, string domain);

}

public struct GOptionContext
{
}
