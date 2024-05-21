namespace MentorLake.Gtk4.Gtk4;

public class GtkBuildableParseContextHandle : BaseSafeHandle
{
}


public static class GtkBuildableParseContextHandleExtensions
{
	public static string GetElement(this GtkBuildableParseContextHandle context)
	{
		return GtkBuildableParseContextExterns.gtk_buildable_parse_context_get_element(context);
	}

	public static IntPtr GetElementStack(this GtkBuildableParseContextHandle context)
	{
		return GtkBuildableParseContextExterns.gtk_buildable_parse_context_get_element_stack(context);
	}

	public static GtkBuildableParseContextHandle GetPosition(this GtkBuildableParseContextHandle context, out int line_number, out int char_number)
	{
		GtkBuildableParseContextExterns.gtk_buildable_parse_context_get_position(context, out line_number, out char_number);
		return context;
	}

	public static IntPtr Pop(this GtkBuildableParseContextHandle context)
	{
		return GtkBuildableParseContextExterns.gtk_buildable_parse_context_pop(context);
	}

	public static GtkBuildableParseContextHandle Push(this GtkBuildableParseContextHandle context, GtkBuildableParserHandle parser, IntPtr user_data)
	{
		GtkBuildableParseContextExterns.gtk_buildable_parse_context_push(context, parser, user_data);
		return context;
	}

}
internal class GtkBuildableParseContextExterns
{
	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_buildable_parse_context_get_element(GtkBuildableParseContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_buildable_parse_context_get_element_stack(GtkBuildableParseContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_buildable_parse_context_get_position(GtkBuildableParseContextHandle context, out int line_number, out int char_number);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_buildable_parse_context_pop(GtkBuildableParseContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_buildable_parse_context_push(GtkBuildableParseContextHandle context, GtkBuildableParserHandle parser, IntPtr user_data);

}

public struct GtkBuildableParseContext
{
}
