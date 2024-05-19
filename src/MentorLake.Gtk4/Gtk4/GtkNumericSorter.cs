namespace MentorLake.Gtk4.Gtk4;

public class GtkNumericSorterHandle : GtkSorterHandle
{
	public static GtkNumericSorterHandle New(GtkExpressionHandle expression)
	{
		return GtkNumericSorterExterns.gtk_numeric_sorter_new(expression);
	}

}

public static class GtkNumericSorterHandleExtensions
{
	public static GtkExpressionHandle GetExpression(this GtkNumericSorterHandle self)
	{
		return GtkNumericSorterExterns.gtk_numeric_sorter_get_expression(self);
	}

	public static GtkSortType GetSortOrder(this GtkNumericSorterHandle self)
	{
		return GtkNumericSorterExterns.gtk_numeric_sorter_get_sort_order(self);
	}

	public static GtkNumericSorterHandle SetExpression(this GtkNumericSorterHandle self, GtkExpressionHandle expression)
	{
		GtkNumericSorterExterns.gtk_numeric_sorter_set_expression(self, expression);
		return self;
	}

	public static GtkNumericSorterHandle SetSortOrder(this GtkNumericSorterHandle self, GtkSortType sort_order)
	{
		GtkNumericSorterExterns.gtk_numeric_sorter_set_sort_order(self, sort_order);
		return self;
	}

}

internal class GtkNumericSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNumericSorterHandle gtk_numeric_sorter_new(GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_numeric_sorter_get_expression(GtkNumericSorterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSortType gtk_numeric_sorter_get_sort_order(GtkNumericSorterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_numeric_sorter_set_expression(GtkNumericSorterHandle self, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_numeric_sorter_set_sort_order(GtkNumericSorterHandle self, GtkSortType sort_order);

}
