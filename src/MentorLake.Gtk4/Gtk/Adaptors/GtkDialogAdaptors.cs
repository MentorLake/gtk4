using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDialogAdaptors
{
	public static GtkDialogHandle AddActionWidget(this GtkDialogHandle dialog, GtkWidgetHandle child, int response_id)
	{
		GtkDialogExterns.gtk_dialog_add_action_widget(dialog, child, response_id);
		return dialog;
	}

	public static GtkWidgetHandle AddButton(this GtkDialogHandle dialog, string button_text, int response_id)
	{
		return GtkDialogExterns.gtk_dialog_add_button(dialog, button_text, response_id);
	}

	public static GtkDialogHandle AddButtons(this GtkDialogHandle dialog, string first_button_text, IntPtr @__argList)
	{
		GtkDialogExterns.gtk_dialog_add_buttons(dialog, first_button_text, @__argList);
		return dialog;
	}

	public static GtkDialogHandle SetResponseSensitive(this GtkDialogHandle dialog, int response_id, int setting)
	{
		GtkDialogExterns.gtk_dialog_set_response_sensitive(dialog, response_id, setting);
		return dialog;
	}

	public static GtkDialogHandle SetDefaultResponse(this GtkDialogHandle dialog, int response_id)
	{
		GtkDialogExterns.gtk_dialog_set_default_response(dialog, response_id);
		return dialog;
	}

	public static GtkWidgetHandle GetWidgetForResponse(this GtkDialogHandle dialog, int response_id)
	{
		return GtkDialogExterns.gtk_dialog_get_widget_for_response(dialog, response_id);
	}

	public static int GetResponseForWidget(this GtkDialogHandle dialog, GtkWidgetHandle widget)
	{
		return GtkDialogExterns.gtk_dialog_get_response_for_widget(dialog, widget);
	}

	public static GtkDialogHandle Response(this GtkDialogHandle dialog, int response_id)
	{
		GtkDialogExterns.gtk_dialog_response(dialog, response_id);
		return dialog;
	}

	public static GtkWidgetHandle GetContentArea(this GtkDialogHandle dialog)
	{
		return GtkDialogExterns.gtk_dialog_get_content_area(dialog);
	}

	public static GtkWidgetHandle GetHeaderBar(this GtkDialogHandle dialog)
	{
		return GtkDialogExterns.gtk_dialog_get_header_bar(dialog);
	}

	public static GtkDialogHandle NewWithButtons(string title, GtkWindowHandle parent, GtkDialogFlags flags, string first_button_text, IntPtr @__arglist)
	{
		return GtkDialogExterns.gtk_dialog_new_with_buttons(title, parent, flags, first_button_text, @__arglist);
	}
}
