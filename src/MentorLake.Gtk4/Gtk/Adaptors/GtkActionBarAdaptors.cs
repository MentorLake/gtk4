using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkActionBarAdaptors
{
	public static GtkWidgetHandle GetCenterWidget(this GtkActionBarHandle action_bar)
	{
		return GtkActionBarExterns.gtk_action_bar_get_center_widget(action_bar);
	}

	public static GtkActionBarHandle SetCenterWidget(this GtkActionBarHandle action_bar, GtkWidgetHandle center_widget)
	{
		GtkActionBarExterns.gtk_action_bar_set_center_widget(action_bar, center_widget);
		return action_bar;
	}

	public static GtkActionBarHandle PackStart(this GtkActionBarHandle action_bar, GtkWidgetHandle child)
	{
		GtkActionBarExterns.gtk_action_bar_pack_start(action_bar, child);
		return action_bar;
	}

	public static GtkActionBarHandle PackEnd(this GtkActionBarHandle action_bar, GtkWidgetHandle child)
	{
		GtkActionBarExterns.gtk_action_bar_pack_end(action_bar, child);
		return action_bar;
	}

	public static GtkActionBarHandle Remove(this GtkActionBarHandle action_bar, GtkWidgetHandle child)
	{
		GtkActionBarExterns.gtk_action_bar_remove(action_bar, child);
		return action_bar;
	}

	public static GtkActionBarHandle SetRevealed(this GtkActionBarHandle action_bar, int revealed)
	{
		GtkActionBarExterns.gtk_action_bar_set_revealed(action_bar, revealed);
		return action_bar;
	}

	public static int GetRevealed(this GtkActionBarHandle action_bar)
	{
		return GtkActionBarExterns.gtk_action_bar_get_revealed(action_bar);
	}
}
