using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellEditableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_editable_start_editing")]
	internal static extern void gtk_cell_editable_start_editing(this GtkCellEditableHandle cell_editable, GdkEventHandle @event);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_editable_editing_done")]
	internal static extern void gtk_cell_editable_editing_done(this GtkCellEditableHandle cell_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_editable_remove_widget")]
	internal static extern void gtk_cell_editable_remove_widget(this GtkCellEditableHandle cell_editable);
}
