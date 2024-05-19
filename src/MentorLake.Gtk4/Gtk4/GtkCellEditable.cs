namespace MentorLake.Gtk4.Gtk4;

public interface GtkCellEditableHandle
{
}

internal class GtkCellEditableHandleImpl : BaseSafeHandle, GtkCellEditableHandle
{
}

public static class GtkCellEditableHandleExtensions
{
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

	public static GtkCellEditableHandle StartEditing(this GtkCellEditableHandle cell_editable, GdkEventHandle @event)
	{
		GtkCellEditableExterns.gtk_cell_editable_start_editing(cell_editable, @event);
		return cell_editable;
	}

}

internal class GtkCellEditableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_editable_editing_done(GtkCellEditableHandle cell_editable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_editable_remove_widget(GtkCellEditableHandle cell_editable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_editable_start_editing(GtkCellEditableHandle cell_editable, GdkEventHandle @event);

}
