using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStringSorterAdaptors
{
    public static GtkExpressionHandle GetExpression(this GtkStringSorterHandle self)
    {
        return GtkStringSorterExterns.gtk_string_sorter_get_expression(self);
    }

    public static GtkStringSorterHandle SetExpression(this GtkStringSorterHandle self, GtkExpressionHandle expression)
    {
        GtkStringSorterExterns.gtk_string_sorter_set_expression(self, expression);
        return self;
    }

    public static int GetIgnoreCase(this GtkStringSorterHandle self)
    {
        return GtkStringSorterExterns.gtk_string_sorter_get_ignore_case(self);
    }

    public static GtkStringSorterHandle SetIgnoreCase(this GtkStringSorterHandle self, int ignore_case)
    {
        GtkStringSorterExterns.gtk_string_sorter_set_ignore_case(self, ignore_case);
        return self;
    }
}
