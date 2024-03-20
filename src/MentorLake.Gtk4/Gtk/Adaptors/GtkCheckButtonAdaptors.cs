using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCheckButtonAdaptors
{
	public static GtkCheckButtonHandle SetInconsistent(this GtkCheckButtonHandle check_button, int inconsistent)
	{
		GtkCheckButtonExterns.gtk_check_button_set_inconsistent(check_button, inconsistent);
		return check_button;
	}

	public static int GetInconsistent(this GtkCheckButtonHandle check_button)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_inconsistent(check_button);
	}

	public static int GetActive(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_active(self);
	}

	public static GtkCheckButtonHandle SetActive(this GtkCheckButtonHandle self, int setting)
	{
		GtkCheckButtonExterns.gtk_check_button_set_active(self, setting);
		return self;
	}

	public static string GetLabel(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_label(self);
	}

	public static GtkCheckButtonHandle SetLabel(this GtkCheckButtonHandle self, string label)
	{
		GtkCheckButtonExterns.gtk_check_button_set_label(self, label);
		return self;
	}

	public static GtkCheckButtonHandle SetGroup(this GtkCheckButtonHandle self, GtkCheckButtonHandle group)
	{
		GtkCheckButtonExterns.gtk_check_button_set_group(self, group);
		return self;
	}

	public static int GetUseUnderline(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_use_underline(self);
	}

	public static GtkCheckButtonHandle SetUseUnderline(this GtkCheckButtonHandle self, int setting)
	{
		GtkCheckButtonExterns.gtk_check_button_set_use_underline(self, setting);
		return self;
	}

	public static GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_label(label);
	}

	public static GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_mnemonic(label);
	}
}
