using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellRendererToggleAdaptors
{
    public static int GetRadio(this GtkCellRendererToggleHandle toggle)
    {
        return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_radio(toggle);
    }

    public static GtkCellRendererToggleHandle SetRadio(this GtkCellRendererToggleHandle toggle, int radio)
    {
        GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_radio(toggle, radio);
        return toggle;
    }

    public static int GetActive(this GtkCellRendererToggleHandle toggle)
    {
        return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_active(toggle);
    }

    public static GtkCellRendererToggleHandle SetActive(this GtkCellRendererToggleHandle toggle, int setting)
    {
        GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_active(toggle, setting);
        return toggle;
    }

    public static int GetActivatable(this GtkCellRendererToggleHandle toggle)
    {
        return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_activatable(toggle);
    }

    public static GtkCellRendererToggleHandle SetActivatable(this GtkCellRendererToggleHandle toggle, int setting)
    {
        GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_activatable(toggle, setting);
        return toggle;
    }
}
