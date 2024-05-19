namespace MentorLake.Gtk4.Gtk4;

public class GtkNothingActionHandle : GtkShortcutActionHandle
{
	public static GtkShortcutActionHandle Get()
	{
		return GtkNothingActionExterns.gtk_nothing_action_get();
	}

}

public static class GtkNothingActionHandleExtensions
{
}

internal class GtkNothingActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutActionHandle gtk_nothing_action_get();

}
