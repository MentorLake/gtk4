using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkButtonAdaptors
{
	public static GtkButtonHandle SetHasFrame(this GtkButtonHandle button, int has_frame)
	{
		GtkButtonExterns.gtk_button_set_has_frame(button, has_frame);
		return button;
	}

	public static int GetHasFrame(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_has_frame(button);
	}

	public static GtkButtonHandle SetLabel(this GtkButtonHandle button, string label)
	{
		GtkButtonExterns.gtk_button_set_label(button, label);
		return button;
	}

	public static string GetLabel(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_label(button);
	}

	public static GtkButtonHandle SetUseUnderline(this GtkButtonHandle button, int use_underline)
	{
		GtkButtonExterns.gtk_button_set_use_underline(button, use_underline);
		return button;
	}

	public static int GetUseUnderline(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_use_underline(button);
	}

	public static GtkButtonHandle SetIconName(this GtkButtonHandle button, string icon_name)
	{
		GtkButtonExterns.gtk_button_set_icon_name(button, icon_name);
		return button;
	}

	public static string GetIconName(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_icon_name(button);
	}

	public static GtkButtonHandle SetChild(this GtkButtonHandle button, GtkWidgetHandle child)
	{
		GtkButtonExterns.gtk_button_set_child(button, child);
		return button;
	}

	public static GtkWidgetHandle GetChild(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_child(button);
	}

	public static GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_label(label);
	}

	public static GtkButtonHandle NewFromIconName(string icon_name)
	{
		return GtkButtonExterns.gtk_button_new_from_icon_name(icon_name);
	}

	public static GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_mnemonic(label);
	}
}
