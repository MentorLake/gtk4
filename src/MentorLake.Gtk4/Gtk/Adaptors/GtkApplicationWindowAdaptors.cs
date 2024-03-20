using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkApplicationWindowAdaptors
{
    public static GtkApplicationWindowHandle SetShowMenubar(this GtkApplicationWindowHandle window, int show_menubar)
    {
        GtkApplicationWindowExterns.gtk_application_window_set_show_menubar(window, show_menubar);
        return window;
    }

    public static int GetShowMenubar(this GtkApplicationWindowHandle window)
    {
        return GtkApplicationWindowExterns.gtk_application_window_get_show_menubar(window);
    }

    public static uint GetId(this GtkApplicationWindowHandle window)
    {
        return GtkApplicationWindowExterns.gtk_application_window_get_id(window);
    }

    public static GtkApplicationWindowHandle SetHelpOverlay(this GtkApplicationWindowHandle window, GtkShortcutsWindowHandle help_overlay)
    {
        GtkApplicationWindowExterns.gtk_application_window_set_help_overlay(window, help_overlay);
        return window;
    }

    public static GtkShortcutsWindowHandle GetHelpOverlay(this GtkApplicationWindowHandle window)
    {
        return GtkApplicationWindowExterns.gtk_application_window_get_help_overlay(window);
    }
}
