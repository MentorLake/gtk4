using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMenuButtonAdaptors
{
	public static GtkMenuButtonHandle SetPopover(this GtkMenuButtonHandle menu_button, GtkWidgetHandle popover)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_popover(menu_button, popover);
		return menu_button;
	}

	public static GtkPopoverHandle GetPopover(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_popover(menu_button);
	}

	public static GtkMenuButtonHandle SetDirection(this GtkMenuButtonHandle menu_button, GtkArrowType direction)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_direction(menu_button, direction);
		return menu_button;
	}

	public static GtkArrowType GetDirection(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_direction(menu_button);
	}

	public static GtkMenuButtonHandle SetMenuModel(this GtkMenuButtonHandle menu_button, GMenuModelHandle menu_model)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_menu_model(menu_button, menu_model);
		return menu_button;
	}

	public static GMenuModelHandle GetMenuModel(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_menu_model(menu_button);
	}

	public static GtkMenuButtonHandle SetIconName(this GtkMenuButtonHandle menu_button, string icon_name)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_icon_name(menu_button, icon_name);
		return menu_button;
	}

	public static string GetIconName(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_icon_name(menu_button);
	}

	public static GtkMenuButtonHandle SetAlwaysShowArrow(this GtkMenuButtonHandle menu_button, int always_show_arrow)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_always_show_arrow(menu_button, always_show_arrow);
		return menu_button;
	}

	public static int GetAlwaysShowArrow(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_always_show_arrow(menu_button);
	}

	public static GtkMenuButtonHandle SetLabel(this GtkMenuButtonHandle menu_button, string label)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_label(menu_button, label);
		return menu_button;
	}

	public static string GetLabel(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_label(menu_button);
	}

	public static GtkMenuButtonHandle SetUseUnderline(this GtkMenuButtonHandle menu_button, int use_underline)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_use_underline(menu_button, use_underline);
		return menu_button;
	}

	public static int GetUseUnderline(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_use_underline(menu_button);
	}

	public static GtkMenuButtonHandle SetHasFrame(this GtkMenuButtonHandle menu_button, int has_frame)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_has_frame(menu_button, has_frame);
		return menu_button;
	}

	public static int GetHasFrame(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_has_frame(menu_button);
	}

	public static GtkMenuButtonHandle Popup(this GtkMenuButtonHandle menu_button)
	{
		GtkMenuButtonExterns.gtk_menu_button_popup(menu_button);
		return menu_button;
	}

	public static GtkMenuButtonHandle Popdown(this GtkMenuButtonHandle menu_button)
	{
		GtkMenuButtonExterns.gtk_menu_button_popdown(menu_button);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetCreatePopupFunc(this GtkMenuButtonHandle menu_button, GtkMenuButtonCreatePopupFunc func, IntPtr user_data, GDestroyNotify destroy_notify)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_create_popup_func(menu_button, func, user_data, destroy_notify);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetPrimary(this GtkMenuButtonHandle menu_button, int primary)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_primary(menu_button, primary);
		return menu_button;
	}

	public static int GetPrimary(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_primary(menu_button);
	}

	public static GtkMenuButtonHandle SetChild(this GtkMenuButtonHandle menu_button, GtkWidgetHandle child)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_child(menu_button, child);
		return menu_button;
	}

	public static GtkWidgetHandle GetChild(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_child(menu_button);
	}
}
