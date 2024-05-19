namespace MentorLake.Gtk4.Gtk4;

public class GtkMnemonicTriggerHandle : GtkShortcutTriggerHandle
{
	public static GtkMnemonicTriggerHandle New(uint keyval)
	{
		return GtkMnemonicTriggerExterns.gtk_mnemonic_trigger_new(keyval);
	}

}

public static class GtkMnemonicTriggerHandleExtensions
{
	public static uint GetKeyval(this GtkMnemonicTriggerHandle self)
	{
		return GtkMnemonicTriggerExterns.gtk_mnemonic_trigger_get_keyval(self);
	}

}

internal class GtkMnemonicTriggerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMnemonicTriggerHandle gtk_mnemonic_trigger_new(uint keyval);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_mnemonic_trigger_get_keyval(GtkMnemonicTriggerHandle self);

}
