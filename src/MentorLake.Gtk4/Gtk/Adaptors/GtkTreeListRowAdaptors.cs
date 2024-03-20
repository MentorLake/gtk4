using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeListRowAdaptors
{
    public static IntPtr GetItem(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_item(self);
    }

    public static GtkTreeListRowHandle SetExpanded(this GtkTreeListRowHandle self, int expanded)
    {
        GtkTreeListRowExterns.gtk_tree_list_row_set_expanded(self, expanded);
        return self;
    }

    public static int GetExpanded(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_expanded(self);
    }

    public static int IsExpandable(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_is_expandable(self);
    }

    public static uint GetPosition(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_position(self);
    }

    public static uint GetDepth(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_depth(self);
    }

    public static GListModelHandle GetChildren(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_children(self);
    }

    public static GtkTreeListRowHandle GetParent(this GtkTreeListRowHandle self)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_parent(self);
    }

    public static GtkTreeListRowHandle GetChildRow(this GtkTreeListRowHandle self, uint position)
    {
        return GtkTreeListRowExterns.gtk_tree_list_row_get_child_row(self, position);
    }
}
