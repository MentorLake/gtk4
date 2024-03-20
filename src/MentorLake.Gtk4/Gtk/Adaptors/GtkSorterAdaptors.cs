using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSorterAdaptors
{
    public static GtkOrdering Compare(this GtkSorterHandle self, IntPtr item1, IntPtr item2)
    {
        return GtkSorterExterns.gtk_sorter_compare(self, item1, item2);
    }

    public static GtkSorterOrder GetOrder(this GtkSorterHandle self)
    {
        return GtkSorterExterns.gtk_sorter_get_order(self);
    }

    public static GtkSorterHandle Changed(this GtkSorterHandle self, GtkSorterChange change)
    {
        GtkSorterExterns.gtk_sorter_changed(self, change);
        return self;
    }

    public static GtkTreeListRowSorterHandle GtkTreeListRowSorterNew(this GtkSorterHandle sorter)
    {
        return GtkSorterExterns.gtk_tree_list_row_sorter_new(sorter);
    }
}
