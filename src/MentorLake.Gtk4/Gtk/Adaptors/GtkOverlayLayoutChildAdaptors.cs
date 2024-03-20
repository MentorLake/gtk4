using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkOverlayLayoutChildAdaptors
{
    public static GtkOverlayLayoutChildHandle SetMeasure(this GtkOverlayLayoutChildHandle child, int measure)
    {
        GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_set_measure(child, measure);
        return child;
    }

    public static int GetMeasure(this GtkOverlayLayoutChildHandle child)
    {
        return GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_get_measure(child);
    }

    public static GtkOverlayLayoutChildHandle SetClipOverlay(this GtkOverlayLayoutChildHandle child, int clip_overlay)
    {
        GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_set_clip_overlay(child, clip_overlay);
        return child;
    }

    public static int GetClipOverlay(this GtkOverlayLayoutChildHandle child)
    {
        return GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_get_clip_overlay(child);
    }
}
