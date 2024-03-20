using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkInfoBarAdaptors
{
	public static GtkInfoBarHandle AddActionWidget(this GtkInfoBarHandle info_bar, GtkWidgetHandle child, int response_id)
	{
		GtkInfoBarExterns.gtk_info_bar_add_action_widget(info_bar, child, response_id);
		return info_bar;
	}

	public static GtkInfoBarHandle RemoveActionWidget(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget)
	{
		GtkInfoBarExterns.gtk_info_bar_remove_action_widget(info_bar, widget);
		return info_bar;
	}

	public static GtkWidgetHandle AddButton(this GtkInfoBarHandle info_bar, string button_text, int response_id)
	{
		return GtkInfoBarExterns.gtk_info_bar_add_button(info_bar, button_text, response_id);
	}

	public static GtkInfoBarHandle AddButtons(this GtkInfoBarHandle info_bar, string first_button_text, IntPtr @__argList)
	{
		GtkInfoBarExterns.gtk_info_bar_add_buttons(info_bar, first_button_text, @__argList);
		return info_bar;
	}

	public static GtkInfoBarHandle AddChild(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget)
	{
		GtkInfoBarExterns.gtk_info_bar_add_child(info_bar, widget);
		return info_bar;
	}

	public static GtkInfoBarHandle RemoveChild(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget)
	{
		GtkInfoBarExterns.gtk_info_bar_remove_child(info_bar, widget);
		return info_bar;
	}

	public static GtkInfoBarHandle SetResponseSensitive(this GtkInfoBarHandle info_bar, int response_id, int setting)
	{
		GtkInfoBarExterns.gtk_info_bar_set_response_sensitive(info_bar, response_id, setting);
		return info_bar;
	}

	public static GtkInfoBarHandle SetDefaultResponse(this GtkInfoBarHandle info_bar, int response_id)
	{
		GtkInfoBarExterns.gtk_info_bar_set_default_response(info_bar, response_id);
		return info_bar;
	}

	public static GtkInfoBarHandle Response(this GtkInfoBarHandle info_bar, int response_id)
	{
		GtkInfoBarExterns.gtk_info_bar_response(info_bar, response_id);
		return info_bar;
	}

	public static GtkInfoBarHandle SetMessageType(this GtkInfoBarHandle info_bar, GtkMessageType message_type)
	{
		GtkInfoBarExterns.gtk_info_bar_set_message_type(info_bar, message_type);
		return info_bar;
	}

	public static GtkMessageType GetMessageType(this GtkInfoBarHandle info_bar)
	{
		return GtkInfoBarExterns.gtk_info_bar_get_message_type(info_bar);
	}

	public static GtkInfoBarHandle SetShowCloseButton(this GtkInfoBarHandle info_bar, int setting)
	{
		GtkInfoBarExterns.gtk_info_bar_set_show_close_button(info_bar, setting);
		return info_bar;
	}

	public static int GetShowCloseButton(this GtkInfoBarHandle info_bar)
	{
		return GtkInfoBarExterns.gtk_info_bar_get_show_close_button(info_bar);
	}

	public static GtkInfoBarHandle SetRevealed(this GtkInfoBarHandle info_bar, int revealed)
	{
		GtkInfoBarExterns.gtk_info_bar_set_revealed(info_bar, revealed);
		return info_bar;
	}

	public static int GetRevealed(this GtkInfoBarHandle info_bar)
	{
		return GtkInfoBarExterns.gtk_info_bar_get_revealed(info_bar);
	}

	public static GtkInfoBarHandle NewWithButtons(string first_button_text, IntPtr @__arglist)
	{
		return GtkInfoBarExterns.gtk_info_bar_new_with_buttons(first_button_text, @__arglist);
	}
}
