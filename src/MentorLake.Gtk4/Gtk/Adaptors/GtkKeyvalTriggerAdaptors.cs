using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkKeyvalTriggerAdaptors
{
    public static GdkModifierType GetModifiers(this GtkKeyvalTriggerHandle self)
    {
        return GtkKeyvalTriggerExterns.gtk_keyval_trigger_get_modifiers(self);
    }

    public static uint GetKeyval(this GtkKeyvalTriggerHandle self)
    {
        return GtkKeyvalTriggerExterns.gtk_keyval_trigger_get_keyval(self);
    }
}
