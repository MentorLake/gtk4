namespace MentorLake.Gtk4.Gtk4;

public class GtkColumnViewSorterHandle : GtkSorterHandle
{
}

public static class GtkColumnViewSorterHandleExtensions
{
	public static uint GetNSortColumns(this GtkColumnViewSorterHandle self)
	{
		return GtkColumnViewSorterExterns.gtk_column_view_sorter_get_n_sort_columns(self);
	}

	public static GtkColumnViewColumnHandle GetNthSortColumn(this GtkColumnViewSorterHandle self, uint position, out GtkSortType sort_order)
	{
		return GtkColumnViewSorterExterns.gtk_column_view_sorter_get_nth_sort_column(self, position, out sort_order);
	}

	public static GtkColumnViewColumnHandle GetPrimarySortColumn(this GtkColumnViewSorterHandle self)
	{
		return GtkColumnViewSorterExterns.gtk_column_view_sorter_get_primary_sort_column(self);
	}

	public static GtkSortType GetPrimarySortOrder(this GtkColumnViewSorterHandle self)
	{
		return GtkColumnViewSorterExterns.gtk_column_view_sorter_get_primary_sort_order(self);
	}

}

internal class GtkColumnViewSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_column_view_sorter_get_n_sort_columns(GtkColumnViewSorterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColumnViewColumnHandle gtk_column_view_sorter_get_nth_sort_column(GtkColumnViewSorterHandle self, uint position, out GtkSortType sort_order);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColumnViewColumnHandle gtk_column_view_sorter_get_primary_sort_column(GtkColumnViewSorterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSortType gtk_column_view_sorter_get_primary_sort_order(GtkColumnViewSorterHandle self);

}
