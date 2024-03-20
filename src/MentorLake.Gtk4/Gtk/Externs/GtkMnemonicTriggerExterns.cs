using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkMnemonicTriggerExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_mnemonic_trigger_get_keyval")]
	internal static extern uint gtk_mnemonic_trigger_get_keyval(this GtkMnemonicTriggerHandle self);
}
