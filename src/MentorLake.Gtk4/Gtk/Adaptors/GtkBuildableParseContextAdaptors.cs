using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuildableParseContextAdaptors
{
    public static GtkBuildableParseContextHandle Push(this GtkBuildableParseContextHandle context, GtkBuildableParserHandle parser, IntPtr user_data)
    {
        GtkBuildableParseContextExterns.gtk_buildable_parse_context_push(context, parser, user_data);
        return context;
    }

    public static IntPtr Pop(this GtkBuildableParseContextHandle context)
    {
        return GtkBuildableParseContextExterns.gtk_buildable_parse_context_pop(context);
    }

    public static string GetElement(this GtkBuildableParseContextHandle context)
    {
        return GtkBuildableParseContextExterns.gtk_buildable_parse_context_get_element(context);
    }

    public static GPtrArrayHandle GetElementStack(this GtkBuildableParseContextHandle context)
    {
        return GtkBuildableParseContextExterns.gtk_buildable_parse_context_get_element_stack(context);
    }

    public static GtkBuildableParseContextHandle GetPosition(this GtkBuildableParseContextHandle context, out int line_number, out int char_number)
    {
        GtkBuildableParseContextExterns.gtk_buildable_parse_context_get_position(context, out line_number, out char_number);
        return context;
    }
}
