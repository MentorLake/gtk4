using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeDragDestAdaptors
{
    public static int DragDataReceived(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest, GValueHandle value)
    {
        return GtkTreeDragDestExterns.gtk_tree_drag_dest_drag_data_received(drag_dest, dest, value);
    }

    public static int RowDropPossible(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest_path, GValueHandle value)
    {
        return GtkTreeDragDestExterns.gtk_tree_drag_dest_row_drop_possible(drag_dest, dest_path, value);
    }
}
