using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEventControllerFocusAdaptors
{
    public static int ContainsFocus(this GtkEventControllerFocusHandle self)
    {
        return GtkEventControllerFocusExterns.gtk_event_controller_focus_contains_focus(self);
    }

    public static int IsFocus(this GtkEventControllerFocusHandle self)
    {
        return GtkEventControllerFocusExterns.gtk_event_controller_focus_is_focus(self);
    }
}
