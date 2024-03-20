using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkToggleButtonAdaptors
{
	public static GtkToggleButtonHandle SetActive(this GtkToggleButtonHandle toggle_button, int is_active)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_active(toggle_button, is_active);
		return toggle_button;
	}

	public static int GetActive(this GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_get_active(toggle_button);
	}

	public static GtkToggleButtonHandle Toggled(this GtkToggleButtonHandle toggle_button)
	{
		GtkToggleButtonExterns.gtk_toggle_button_toggled(toggle_button);
		return toggle_button;
	}

	public static GtkToggleButtonHandle SetGroup(this GtkToggleButtonHandle toggle_button, GtkToggleButtonHandle group)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_group(toggle_button, group);
		return toggle_button;
	}

	public static GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_label(label);
	}

	public static GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_mnemonic(label);
	}
}
