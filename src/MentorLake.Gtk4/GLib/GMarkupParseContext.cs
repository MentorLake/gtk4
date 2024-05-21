namespace MentorLake.Gtk4.GLib;

public class GMarkupParseContextHandle : BaseSafeHandle
{
	public static GMarkupParseContextHandle New(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_new(parser, flags, user_data, user_data_dnotify);
	}

}


public static class GMarkupParseContextHandleExtensions
{
	public static bool EndParse(this GMarkupParseContextHandle context, out GErrorHandle error)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_end_parse(context, out error);
	}

	public static GMarkupParseContextHandle Free(this GMarkupParseContextHandle context)
	{
		GMarkupParseContextExterns.g_markup_parse_context_free(context);
		return context;
	}

	public static string GetElement(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_get_element(context);
	}

	public static GSListHandle GetElementStack(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_get_element_stack(context);
	}

	public static GMarkupParseContextHandle GetPosition(this GMarkupParseContextHandle context, out int line_number, out int char_number)
	{
		GMarkupParseContextExterns.g_markup_parse_context_get_position(context, out line_number, out char_number);
		return context;
	}

	public static IntPtr GetUserData(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_get_user_data(context);
	}

	public static bool Parse(this GMarkupParseContextHandle context, string text, UIntPtr text_len, out GErrorHandle error)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_parse(context, text, text_len, out error);
	}

	public static IntPtr Pop(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_pop(context);
	}

	public static GMarkupParseContextHandle Push(this GMarkupParseContextHandle context, GMarkupParserHandle parser, IntPtr user_data)
	{
		GMarkupParseContextExterns.g_markup_parse_context_push(context, parser, user_data);
		return context;
	}

	public static GMarkupParseContextHandle Ref(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_ref(context);
	}

	public static GMarkupParseContextHandle Unref(this GMarkupParseContextHandle context)
	{
		GMarkupParseContextExterns.g_markup_parse_context_unref(context);
		return context;
	}

}
internal class GMarkupParseContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMarkupParseContextHandle g_markup_parse_context_new(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_markup_parse_context_end_parse(GMarkupParseContextHandle context, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_markup_parse_context_free(GMarkupParseContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern string g_markup_parse_context_get_element(GMarkupParseContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_markup_parse_context_get_element_stack(GMarkupParseContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_markup_parse_context_get_position(GMarkupParseContextHandle context, out int line_number, out int char_number);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_markup_parse_context_get_user_data(GMarkupParseContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_markup_parse_context_parse(GMarkupParseContextHandle context, string text, UIntPtr text_len, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_markup_parse_context_pop(GMarkupParseContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_markup_parse_context_push(GMarkupParseContextHandle context, GMarkupParserHandle parser, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GMarkupParseContextHandle g_markup_parse_context_ref(GMarkupParseContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_markup_parse_context_unref(GMarkupParseContextHandle context);

}

public struct GMarkupParseContext
{
}
