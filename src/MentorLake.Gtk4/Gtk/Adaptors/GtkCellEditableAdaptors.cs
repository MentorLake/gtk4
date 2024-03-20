using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellEditableAdaptors
{
    public static GtkCellEditableHandle StartEditing(this GtkCellEditableHandle cell_editable, GdkEventHandle @event)
    {
        GtkCellEditableExterns.gtk_cell_editable_start_editing(cell_editable, @event);
        return cell_editable;
    }

    public static GtkCellEditableHandle EditingDone(this GtkCellEditableHandle cell_editable)
    {
        GtkCellEditableExterns.gtk_cell_editable_editing_done(cell_editable);
        return cell_editable;
    }

    public static GtkCellEditableHandle RemoveWidget(this GtkCellEditableHandle cell_editable)
    {
        GtkCellEditableExterns.gtk_cell_editable_remove_widget(cell_editable);
        return cell_editable;
    }
}
