namespace MentorLake.Gtk4.Gtk4;

public class GtkMnemonicActionHandle : GtkShortcutActionHandle
{
	public static GtkShortcutActionHandle Get()
	{
		return GtkMnemonicActionExterns.gtk_mnemonic_action_get();
	}

}

public static class GtkMnemonicActionHandleExtensions
{
}

internal class GtkMnemonicActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutActionHandle gtk_mnemonic_action_get();

}
