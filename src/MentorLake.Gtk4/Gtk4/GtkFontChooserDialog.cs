namespace MentorLake.Gtk4.Gtk4;

public class GtkFontChooserDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFontChooserHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkFontChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkFontChooserDialogExterns.gtk_font_chooser_dialog_new(title, parent);
	}

}

public static class GtkFontChooserDialogHandleExtensions
{
}

internal class GtkFontChooserDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontChooserDialogHandle gtk_font_chooser_dialog_new(string title, GtkWindowHandle parent);

}
