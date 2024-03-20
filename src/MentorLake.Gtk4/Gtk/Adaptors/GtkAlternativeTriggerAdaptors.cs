using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAlternativeTriggerAdaptors
{
    public static GtkShortcutTriggerHandle GetFirst(this GtkAlternativeTriggerHandle self)
    {
        return GtkAlternativeTriggerExterns.gtk_alternative_trigger_get_first(self);
    }

    public static GtkShortcutTriggerHandle GetSecond(this GtkAlternativeTriggerHandle self)
    {
        return GtkAlternativeTriggerExterns.gtk_alternative_trigger_get_second(self);
    }
}
