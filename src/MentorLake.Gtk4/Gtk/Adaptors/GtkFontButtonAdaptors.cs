using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFontButtonAdaptors
{
	public static string GetTitle(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_title(font_button);
	}

	public static GtkFontButtonHandle SetTitle(this GtkFontButtonHandle font_button, string title)
	{
		GtkFontButtonExterns.gtk_font_button_set_title(font_button, title);
		return font_button;
	}

	public static int GetModal(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_modal(font_button);
	}

	public static GtkFontButtonHandle SetModal(this GtkFontButtonHandle font_button, int modal)
	{
		GtkFontButtonExterns.gtk_font_button_set_modal(font_button, modal);
		return font_button;
	}

	public static int GetUseFont(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_use_font(font_button);
	}

	public static GtkFontButtonHandle SetUseFont(this GtkFontButtonHandle font_button, int use_font)
	{
		GtkFontButtonExterns.gtk_font_button_set_use_font(font_button, use_font);
		return font_button;
	}

	public static int GetUseSize(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_use_size(font_button);
	}

	public static GtkFontButtonHandle SetUseSize(this GtkFontButtonHandle font_button, int use_size)
	{
		GtkFontButtonExterns.gtk_font_button_set_use_size(font_button, use_size);
		return font_button;
	}

	public static GtkFontButtonHandle NewWithFont(string fontname)
	{
		return GtkFontButtonExterns.gtk_font_button_new_with_font(fontname);
	}
}
