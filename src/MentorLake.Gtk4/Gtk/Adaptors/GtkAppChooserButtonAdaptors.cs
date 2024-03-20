using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAppChooserButtonAdaptors
{
	public static GtkAppChooserButtonHandle AppendSeparator(this GtkAppChooserButtonHandle self)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_separator(self);
		return self;
	}

	public static GtkAppChooserButtonHandle AppendCustomItem(this GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_custom_item(self, name, label, icon);
		return self;
	}

	public static GtkAppChooserButtonHandle SetActiveCustomItem(this GtkAppChooserButtonHandle self, string name)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_active_custom_item(self, name);
		return self;
	}

	public static GtkAppChooserButtonHandle SetShowDialogItem(this GtkAppChooserButtonHandle self, int setting)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_dialog_item(self, setting);
		return self;
	}

	public static int GetShowDialogItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_dialog_item(self);
	}

	public static GtkAppChooserButtonHandle SetHeading(this GtkAppChooserButtonHandle self, string heading)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_heading(self, heading);
		return self;
	}

	public static string GetHeading(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_heading(self);
	}

	public static GtkAppChooserButtonHandle SetShowDefaultItem(this GtkAppChooserButtonHandle self, int setting)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_default_item(self, setting);
		return self;
	}

	public static int GetShowDefaultItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_default_item(self);
	}

	public static int GetModal(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_modal(self);
	}

	public static GtkAppChooserButtonHandle SetModal(this GtkAppChooserButtonHandle self, int modal)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_modal(self, modal);
		return self;
	}
}
