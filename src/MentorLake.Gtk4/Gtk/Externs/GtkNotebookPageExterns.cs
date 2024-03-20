using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkNotebookPageExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_page_get_child")]
	internal static extern GtkWidgetHandle gtk_notebook_page_get_child(this GtkNotebookPageHandle page);
}
