using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNotebookPageAdaptors
{
    public static GtkWidgetHandle GetChild(this GtkNotebookPageHandle page)
    {
        return GtkNotebookPageExterns.gtk_notebook_page_get_child(page);
    }
}
