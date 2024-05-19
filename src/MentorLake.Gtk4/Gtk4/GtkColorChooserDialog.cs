namespace MentorLake.Gtk4.Gtk4;

public class GtkColorChooserDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkColorChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkColorChooserDialogExterns.gtk_color_chooser_dialog_new(title, parent);
	}

}

public static class GtkColorChooserDialogHandleExtensions
{
}

internal class GtkColorChooserDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorChooserDialogHandle gtk_color_chooser_dialog_new(string title, GtkWindowHandle parent);

}
