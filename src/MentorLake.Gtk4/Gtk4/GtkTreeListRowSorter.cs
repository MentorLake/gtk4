namespace MentorLake.Gtk4.Gtk4;

public class GtkTreeListRowSorterHandle : GtkSorterHandle
{
	public static GtkTreeListRowSorterHandle New(GtkSorterHandle sorter)
	{
		return GtkTreeListRowSorterExterns.gtk_tree_list_row_sorter_new(sorter);
	}

}

public static class GtkTreeListRowSorterHandleExtensions
{
	public static GtkSorterHandle GetSorter(this GtkTreeListRowSorterHandle self)
	{
		return GtkTreeListRowSorterExterns.gtk_tree_list_row_sorter_get_sorter(self);
	}

	public static GtkTreeListRowSorterHandle SetSorter(this GtkTreeListRowSorterHandle self, GtkSorterHandle sorter)
	{
		GtkTreeListRowSorterExterns.gtk_tree_list_row_sorter_set_sorter(self, sorter);
		return self;
	}

}

internal class GtkTreeListRowSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowSorterHandle gtk_tree_list_row_sorter_new(GtkSorterHandle sorter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterHandle gtk_tree_list_row_sorter_get_sorter(GtkTreeListRowSorterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_list_row_sorter_set_sorter(GtkTreeListRowSorterHandle self, GtkSorterHandle sorter);

}
