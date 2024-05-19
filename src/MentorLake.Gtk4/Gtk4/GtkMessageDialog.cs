namespace MentorLake.Gtk4.Gtk4;

public class GtkMessageDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkMessageDialogHandle New(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_new(parent, flags, type, buttons, message_format, @__arglist);
	}

	public static GtkMessageDialogHandle NewWithMarkup(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_new_with_markup(parent, flags, type, buttons, message_format, @__arglist);
	}

}

public static class GtkMessageDialogHandleExtensions
{
	public static GtkMessageDialogHandle FormatSecondaryMarkup(this GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist)
	{
		GtkMessageDialogExterns.gtk_message_dialog_format_secondary_markup(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

	public static GtkMessageDialogHandle FormatSecondaryText(this GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist)
	{
		GtkMessageDialogExterns.gtk_message_dialog_format_secondary_text(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

	public static GtkWidgetHandle GetMessageArea(this GtkMessageDialogHandle message_dialog)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_get_message_area(message_dialog);
	}

	public static GtkMessageDialogHandle SetMarkup(this GtkMessageDialogHandle message_dialog, string str)
	{
		GtkMessageDialogExterns.gtk_message_dialog_set_markup(message_dialog, str);
		return message_dialog;
	}

}

internal class GtkMessageDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMessageDialogHandle gtk_message_dialog_new(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMessageDialogHandle gtk_message_dialog_new_with_markup(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_message_dialog_format_secondary_markup(GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_message_dialog_format_secondary_text(GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_message_dialog_get_message_area(GtkMessageDialogHandle message_dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_message_dialog_set_markup(GtkMessageDialogHandle message_dialog, string str);

}
