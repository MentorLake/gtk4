using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkColorButtonAdaptors
{
	public static GtkColorButtonHandle SetTitle(this GtkColorButtonHandle button, string title)
	{
		GtkColorButtonExterns.gtk_color_button_set_title(button, title);
		return button;
	}

	public static string GetTitle(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_title(button);
	}

	public static int GetModal(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_modal(button);
	}

	public static GtkColorButtonHandle SetModal(this GtkColorButtonHandle button, int modal)
	{
		GtkColorButtonExterns.gtk_color_button_set_modal(button, modal);
		return button;
	}

	public static GtkColorButtonHandle NewWithRgba(GdkRGBAHandle rgba)
	{
		return GtkColorButtonExterns.gtk_color_button_new_with_rgba(rgba);
	}
}
