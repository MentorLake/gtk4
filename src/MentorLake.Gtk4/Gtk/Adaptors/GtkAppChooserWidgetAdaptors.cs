using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAppChooserWidgetAdaptors
{
	public static GtkAppChooserWidgetHandle SetShowDefault(this GtkAppChooserWidgetHandle self, int setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_default(self, setting);
		return self;
	}

	public static int GetShowDefault(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_default(self);
	}

	public static GtkAppChooserWidgetHandle SetShowRecommended(this GtkAppChooserWidgetHandle self, int setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_recommended(self, setting);
		return self;
	}

	public static int GetShowRecommended(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_recommended(self);
	}

	public static GtkAppChooserWidgetHandle SetShowFallback(this GtkAppChooserWidgetHandle self, int setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_fallback(self, setting);
		return self;
	}

	public static int GetShowFallback(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_fallback(self);
	}

	public static GtkAppChooserWidgetHandle SetShowOther(this GtkAppChooserWidgetHandle self, int setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_other(self, setting);
		return self;
	}

	public static int GetShowOther(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_other(self);
	}

	public static GtkAppChooserWidgetHandle SetShowAll(this GtkAppChooserWidgetHandle self, int setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_all(self, setting);
		return self;
	}

	public static int GetShowAll(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_all(self);
	}

	public static GtkAppChooserWidgetHandle SetDefaultText(this GtkAppChooserWidgetHandle self, string text)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_default_text(self, text);
		return self;
	}

	public static string GetDefaultText(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_default_text(self);
	}
}
