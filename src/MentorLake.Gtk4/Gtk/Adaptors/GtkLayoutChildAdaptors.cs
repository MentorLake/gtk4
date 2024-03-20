using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLayoutChildAdaptors
{
    public static GtkLayoutManagerHandle GetLayoutManager(this GtkLayoutChildHandle layout_child)
    {
        return GtkLayoutChildExterns.gtk_layout_child_get_layout_manager(layout_child);
    }

    public static GtkWidgetHandle GetChildWidget(this GtkLayoutChildHandle layout_child)
    {
        return GtkLayoutChildExterns.gtk_layout_child_get_child_widget(layout_child);
    }
}
