using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkNumericSorterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_numeric_sorter_get_expression")]
	internal static extern GtkExpressionHandle gtk_numeric_sorter_get_expression(this GtkNumericSorterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_numeric_sorter_set_expression")]
	internal static extern void gtk_numeric_sorter_set_expression(this GtkNumericSorterHandle self, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_numeric_sorter_get_sort_order")]
	internal static extern GtkSortType gtk_numeric_sorter_get_sort_order(this GtkNumericSorterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_numeric_sorter_set_sort_order")]
	internal static extern void gtk_numeric_sorter_set_sort_order(this GtkNumericSorterHandle self, GtkSortType sort_order);
}
