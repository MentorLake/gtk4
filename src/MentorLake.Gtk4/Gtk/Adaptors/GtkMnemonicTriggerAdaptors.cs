using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMnemonicTriggerAdaptors
{
    public static uint GetKeyval(this GtkMnemonicTriggerHandle self)
    {
        return GtkMnemonicTriggerExterns.gtk_mnemonic_trigger_get_keyval(self);
    }
}
