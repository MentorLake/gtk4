namespace MentorLake.Gtk4.Gtk4;

public class GtkFileChooserDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFileChooserHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkFileChooserDialogHandle New(string title, GtkWindowHandle parent, GtkFileChooserAction action, string first_button_text, IntPtr @__arglist)
	{
		return GtkFileChooserDialogExterns.gtk_file_chooser_dialog_new(title, parent, action, first_button_text, @__arglist);
	}

}

public static class GtkFileChooserDialogHandleExtensions
{
}

internal class GtkFileChooserDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserDialogHandle gtk_file_chooser_dialog_new(string title, GtkWindowHandle parent, GtkFileChooserAction action, string first_button_text, IntPtr @__arglist);

}
