namespace MentorLake.Gtk4.Gtk4;

public class GtkShortcutsGroupHandle : GtkBoxHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
}

public static class GtkShortcutsGroupHandleExtensions
{
	public static GtkShortcutsGroupHandle AddShortcut(this GtkShortcutsGroupHandle self, GtkShortcutsShortcutHandle shortcut)
	{
		GtkShortcutsGroupExterns.gtk_shortcuts_group_add_shortcut(self, shortcut);
		return self;
	}

}

internal class GtkShortcutsGroupExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_group_add_shortcut(GtkShortcutsGroupHandle self, GtkShortcutsShortcutHandle shortcut);

}
