namespace MentorLake.Gtk4.Gtk4;

public class GtkNeverTriggerHandle : GtkShortcutTriggerHandle
{
	public static GtkShortcutTriggerHandle Get()
	{
		return GtkNeverTriggerExterns.gtk_never_trigger_get();
	}

}

public static class GtkNeverTriggerHandleExtensions
{
}

internal class GtkNeverTriggerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutTriggerHandle gtk_never_trigger_get();

}
