using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEventControllerKeyAdaptors
{
    public static GtkEventControllerKeyHandle SetImContext(this GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context)
    {
        GtkEventControllerKeyExterns.gtk_event_controller_key_set_im_context(controller, im_context);
        return controller;
    }

    public static GtkIMContextHandle GetImContext(this GtkEventControllerKeyHandle controller)
    {
        return GtkEventControllerKeyExterns.gtk_event_controller_key_get_im_context(controller);
    }

    public static int Forward(this GtkEventControllerKeyHandle controller, GtkWidgetHandle widget)
    {
        return GtkEventControllerKeyExterns.gtk_event_controller_key_forward(controller, widget);
    }

    public static uint GetGroup(this GtkEventControllerKeyHandle controller)
    {
        return GtkEventControllerKeyExterns.gtk_event_controller_key_get_group(controller);
    }
}
