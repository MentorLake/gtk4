using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDragAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_display(drag);
    }

    public static GdkDeviceHandle GetDevice(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_device(drag);
    }

    public static GdkContentFormatsHandle GetFormats(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_formats(drag);
    }

    public static GdkDragAction GetActions(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_actions(drag);
    }

    public static GdkDragAction GetSelectedAction(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_selected_action(drag);
    }

    public static GdkDragHandle DropDone(this GdkDragHandle drag, int success)
    {
        GdkDragExterns.gdk_drag_drop_done(drag, success);
        return drag;
    }

    public static GdkSurfaceHandle GetDragSurface(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_drag_surface(drag);
    }

    public static GdkDragHandle SetHotspot(this GdkDragHandle drag, int hot_x, int hot_y)
    {
        GdkDragExterns.gdk_drag_set_hotspot(drag, hot_x, hot_y);
        return drag;
    }

    public static GdkContentProviderHandle GetContent(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_content(drag);
    }

    public static GdkSurfaceHandle GetSurface(this GdkDragHandle drag)
    {
        return GdkDragExterns.gdk_drag_get_surface(drag);
    }
}
