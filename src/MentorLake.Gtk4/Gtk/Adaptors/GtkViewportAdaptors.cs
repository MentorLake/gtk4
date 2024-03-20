using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkViewportAdaptors
{
    public static int GetScrollToFocus(this GtkViewportHandle viewport)
    {
        return GtkViewportExterns.gtk_viewport_get_scroll_to_focus(viewport);
    }

    public static GtkViewportHandle SetScrollToFocus(this GtkViewportHandle viewport, int scroll_to_focus)
    {
        GtkViewportExterns.gtk_viewport_set_scroll_to_focus(viewport, scroll_to_focus);
        return viewport;
    }

    public static GtkViewportHandle SetChild(this GtkViewportHandle viewport, GtkWidgetHandle child)
    {
        GtkViewportExterns.gtk_viewport_set_child(viewport, child);
        return viewport;
    }

    public static GtkWidgetHandle GetChild(this GtkViewportHandle viewport)
    {
        return GtkViewportExterns.gtk_viewport_get_child(viewport);
    }
}
