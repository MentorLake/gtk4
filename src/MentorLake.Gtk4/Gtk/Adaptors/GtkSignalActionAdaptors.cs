using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSignalActionAdaptors
{
    public static string GetSignalName(this GtkSignalActionHandle self)
    {
        return GtkSignalActionExterns.gtk_signal_action_get_signal_name(self);
    }
}
