using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEventControllerScrollAdaptors
{
    public static GtkEventControllerScrollHandle SetFlags(this GtkEventControllerScrollHandle scroll, GtkEventControllerScrollFlags flags)
    {
        GtkEventControllerScrollExterns.gtk_event_controller_scroll_set_flags(scroll, flags);
        return scroll;
    }

    public static GtkEventControllerScrollFlags GetFlags(this GtkEventControllerScrollHandle scroll)
    {
        return GtkEventControllerScrollExterns.gtk_event_controller_scroll_get_flags(scroll);
    }
}
