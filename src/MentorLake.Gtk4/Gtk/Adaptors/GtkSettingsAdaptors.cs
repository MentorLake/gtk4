using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSettingsAdaptors
{
    public static GtkSettingsHandle ResetProperty(this GtkSettingsHandle settings, string name)
    {
        GtkSettingsExterns.gtk_settings_reset_property(settings, name);
        return settings;
    }
}
