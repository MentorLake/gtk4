using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDisplayManagerAdaptors
{
    public static GdkDisplayHandle GetDefaultDisplay(this GdkDisplayManagerHandle manager)
    {
        return GdkDisplayManagerExterns.gdk_display_manager_get_default_display(manager);
    }

    public static GdkDisplayManagerHandle SetDefaultDisplay(this GdkDisplayManagerHandle manager, GdkDisplayHandle display)
    {
        GdkDisplayManagerExterns.gdk_display_manager_set_default_display(manager, display);
        return manager;
    }

    public static GSListHandle ListDisplays(this GdkDisplayManagerHandle manager)
    {
        return GdkDisplayManagerExterns.gdk_display_manager_list_displays(manager);
    }

    public static GdkDisplayHandle OpenDisplay(this GdkDisplayManagerHandle manager, string name)
    {
        return GdkDisplayManagerExterns.gdk_display_manager_open_display(manager, name);
    }
}
