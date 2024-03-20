using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMarkupParseContextAdaptors
{
	public static GMarkupParseContextHandle Ref(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_ref(context);
	}

	public static GMarkupParseContextHandle Unref(this GMarkupParseContextHandle context)
	{
		GMarkupParseContextExterns.g_markup_parse_context_unref(context);
		return context;
	}

	public static GMarkupParseContextHandle Free(this GMarkupParseContextHandle context)
	{
		GMarkupParseContextExterns.g_markup_parse_context_free(context);
		return context;
	}

	public static int Parse(this GMarkupParseContextHandle context, string text, nint text_len, out GErrorHandle error)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_parse(context, text, text_len, out error);
	}

	public static GMarkupParseContextHandle Push(this GMarkupParseContextHandle context, GMarkupParserHandle parser, IntPtr user_data)
	{
		GMarkupParseContextExterns.g_markup_parse_context_push(context, parser, user_data);
		return context;
	}

	public static IntPtr Pop(this GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_pop(context);
	}

	public static int EndParse(this GMarkupParseContextHandle context, out GErrorHandle error)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_end_parse(context, out error);
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
}
