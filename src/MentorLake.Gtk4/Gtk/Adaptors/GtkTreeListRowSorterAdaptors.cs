using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeListRowSorterAdaptors
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
