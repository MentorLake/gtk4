using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNamedActionAdaptors
{
    public static string GetActionName(this GtkNamedActionHandle self)
    {
        return GtkNamedActionExterns.gtk_named_action_get_action_name(self);
    }
}
