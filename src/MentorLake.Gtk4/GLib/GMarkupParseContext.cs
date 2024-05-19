namespace MentorLake.Gtk4.GLib;

public class GMarkupParseContextHandle : BaseSafeHandle
{
	public static GMarkupParseContextHandle New(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_new(parser, flags, user_data, user_data_dnotify);
	}

}

internal class GMarkupParseContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMarkupParseContextHandle g_markup_parse_context_new(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify);

}

public struct GMarkupParseContext
{
}
