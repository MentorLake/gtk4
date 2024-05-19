namespace MentorLake.Gtk4.Gtk4;

public class GtkNotebookPageHandle : GObjectHandle
{
}

public static class GtkNotebookPageHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkNotebookPageHandle page)
	{
		return GtkNotebookPageExterns.gtk_notebook_page_get_child(page);
	}

}

internal class GtkNotebookPageExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_notebook_page_get_child(GtkNotebookPageHandle page);

}
