namespace MentorLake.Gtk4.Gtk4;

public class GtkActivateActionHandle : GtkShortcutActionHandle
{
	public static GtkShortcutActionHandle Get()
	{
		return GtkActivateActionExterns.gtk_activate_action_get();
	}

}

public static class GtkActivateActionHandleExtensions
{
}

internal class GtkActivateActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutActionHandle gtk_activate_action_get();

}
