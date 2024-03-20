using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkToplevelAdaptors
{
    public static GdkToplevelHandle Present(this GdkToplevelHandle toplevel, GdkToplevelLayoutHandle layout)
    {
        GdkToplevelExterns.gdk_toplevel_present(toplevel, layout);
        return toplevel;
    }

    public static int Minimize(this GdkToplevelHandle toplevel)
    {
        return GdkToplevelExterns.gdk_toplevel_minimize(toplevel);
    }

    public static int Lower(this GdkToplevelHandle toplevel)
    {
        return GdkToplevelExterns.gdk_toplevel_lower(toplevel);
    }

    public static GdkToplevelHandle Focus(this GdkToplevelHandle toplevel, uint timestamp)
    {
        GdkToplevelExterns.gdk_toplevel_focus(toplevel, timestamp);
        return toplevel;
    }

    public static GdkToplevelState GetState(this GdkToplevelHandle toplevel)
    {
        return GdkToplevelExterns.gdk_toplevel_get_state(toplevel);
    }

    public static GdkToplevelHandle SetTitle(this GdkToplevelHandle toplevel, string title)
    {
        GdkToplevelExterns.gdk_toplevel_set_title(toplevel, title);
        return toplevel;
    }

    public static GdkToplevelHandle SetStartupId(this GdkToplevelHandle toplevel, string startup_id)
    {
        GdkToplevelExterns.gdk_toplevel_set_startup_id(toplevel, startup_id);
        return toplevel;
    }

    public static GdkToplevelHandle SetTransientFor(this GdkToplevelHandle toplevel, GdkSurfaceHandle parent)
    {
        GdkToplevelExterns.gdk_toplevel_set_transient_for(toplevel, parent);
        return toplevel;
    }

    public static GdkToplevelHandle SetModal(this GdkToplevelHandle toplevel, int modal)
    {
        GdkToplevelExterns.gdk_toplevel_set_modal(toplevel, modal);
        return toplevel;
    }

    public static GdkToplevelHandle SetIconList(this GdkToplevelHandle toplevel, GListHandle surfaces)
    {
        GdkToplevelExterns.gdk_toplevel_set_icon_list(toplevel, surfaces);
        return toplevel;
    }

    public static int ShowWindowMenu(this GdkToplevelHandle toplevel, GdkEventHandle @event)
    {
        return GdkToplevelExterns.gdk_toplevel_show_window_menu(toplevel, @event);
    }

    public static GdkToplevelHandle SetDecorated(this GdkToplevelHandle toplevel, int decorated)
    {
        GdkToplevelExterns.gdk_toplevel_set_decorated(toplevel, decorated);
        return toplevel;
    }

    public static GdkToplevelHandle SetDeletable(this GdkToplevelHandle toplevel, int deletable)
    {
        GdkToplevelExterns.gdk_toplevel_set_deletable(toplevel, deletable);
        return toplevel;
    }

    public static int SupportsEdgeConstraints(this GdkToplevelHandle toplevel)
    {
        return GdkToplevelExterns.gdk_toplevel_supports_edge_constraints(toplevel);
    }

    public static GdkToplevelHandle InhibitSystemShortcuts(this GdkToplevelHandle toplevel, GdkEventHandle @event)
    {
        GdkToplevelExterns.gdk_toplevel_inhibit_system_shortcuts(toplevel, @event);
        return toplevel;
    }

    public static GdkToplevelHandle RestoreSystemShortcuts(this GdkToplevelHandle toplevel)
    {
        GdkToplevelExterns.gdk_toplevel_restore_system_shortcuts(toplevel);
        return toplevel;
    }

    public static GdkToplevelHandle BeginResize(this GdkToplevelHandle toplevel, GdkSurfaceEdge edge, GdkDeviceHandle device, int button, double x, double y, uint timestamp)
    {
        GdkToplevelExterns.gdk_toplevel_begin_resize(toplevel, edge, device, button, x, y, timestamp);
        return toplevel;
    }

    public static GdkToplevelHandle BeginMove(this GdkToplevelHandle toplevel, GdkDeviceHandle device, int button, double x, double y, uint timestamp)
    {
        GdkToplevelExterns.gdk_toplevel_begin_move(toplevel, device, button, x, y, timestamp);
        return toplevel;
    }

    public static int TitlebarGesture(this GdkToplevelHandle toplevel, GdkTitlebarGesture gesture)
    {
        return GdkToplevelExterns.gdk_toplevel_titlebar_gesture(toplevel, gesture);
    }
}
