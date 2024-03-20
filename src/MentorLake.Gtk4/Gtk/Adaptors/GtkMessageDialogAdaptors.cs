using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMessageDialogAdaptors
{
    public static GtkMessageDialogHandle SetMarkup(this GtkMessageDialogHandle message_dialog, string str)
    {
        GtkMessageDialogExterns.gtk_message_dialog_set_markup(message_dialog, str);
        return message_dialog;
    }

    public static GtkMessageDialogHandle FormatSecondaryText(this GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__argList)
    {
        GtkMessageDialogExterns.gtk_message_dialog_format_secondary_text(message_dialog, message_format, @__argList);
        return message_dialog;
    }

    public static GtkMessageDialogHandle FormatSecondaryMarkup(this GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__argList)
    {
        GtkMessageDialogExterns.gtk_message_dialog_format_secondary_markup(message_dialog, message_format, @__argList);
        return message_dialog;
    }

    public static GtkWidgetHandle GetMessageArea(this GtkMessageDialogHandle message_dialog)
    {
        return GtkMessageDialogExterns.gtk_message_dialog_get_message_area(message_dialog);
    }
}
