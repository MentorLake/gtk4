using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeDragSourceAdaptors
{
    public static int RowDraggable(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
    {
        return GtkTreeDragSourceExterns.gtk_tree_drag_source_row_draggable(drag_source, path);
    }

    public static int DragDataDelete(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
    {
        return GtkTreeDragSourceExterns.gtk_tree_drag_source_drag_data_delete(drag_source, path);
    }

    public static GdkContentProviderHandle DragDataGet(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
    {
        return GtkTreeDragSourceExterns.gtk_tree_drag_source_drag_data_get(drag_source, path);
    }
}
