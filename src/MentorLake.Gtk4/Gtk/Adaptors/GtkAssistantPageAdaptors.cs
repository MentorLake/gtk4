using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAssistantPageAdaptors
{
    public static GtkWidgetHandle GetChild(this GtkAssistantPageHandle page)
    {
        return GtkAssistantPageExterns.gtk_assistant_page_get_child(page);
    }
}
