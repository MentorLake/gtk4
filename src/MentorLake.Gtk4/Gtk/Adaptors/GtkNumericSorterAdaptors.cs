using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNumericSorterAdaptors
{
    public static GtkExpressionHandle GetExpression(this GtkNumericSorterHandle self)
    {
        return GtkNumericSorterExterns.gtk_numeric_sorter_get_expression(self);
    }

    public static GtkNumericSorterHandle SetExpression(this GtkNumericSorterHandle self, GtkExpressionHandle expression)
    {
        GtkNumericSorterExterns.gtk_numeric_sorter_set_expression(self, expression);
        return self;
    }

    public static GtkSortType GetSortOrder(this GtkNumericSorterHandle self)
    {
        return GtkNumericSorterExterns.gtk_numeric_sorter_get_sort_order(self);
    }

    public static GtkNumericSorterHandle SetSortOrder(this GtkNumericSorterHandle self, GtkSortType sort_order)
    {
        GtkNumericSorterExterns.gtk_numeric_sorter_set_sort_order(self, sort_order);
        return self;
    }
}
