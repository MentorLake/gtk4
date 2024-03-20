using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSearchBarAdaptors
{
	public static GtkSearchBarHandle ConnectEntry(this GtkSearchBarHandle bar, GtkEditableHandle entry)
	{
		GtkSearchBarExterns.gtk_search_bar_connect_entry(bar, entry);
		return bar;
	}

	public static int GetSearchMode(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_search_mode(bar);
	}

	public static GtkSearchBarHandle SetSearchMode(this GtkSearchBarHandle bar, int search_mode)
	{
		GtkSearchBarExterns.gtk_search_bar_set_search_mode(bar, search_mode);
		return bar;
	}

	public static int GetShowCloseButton(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_show_close_button(bar);
	}

	public static GtkSearchBarHandle SetShowCloseButton(this GtkSearchBarHandle bar, int visible)
	{
		GtkSearchBarExterns.gtk_search_bar_set_show_close_button(bar, visible);
		return bar;
	}

	public static GtkSearchBarHandle SetKeyCaptureWidget(this GtkSearchBarHandle bar, GtkWidgetHandle widget)
	{
		GtkSearchBarExterns.gtk_search_bar_set_key_capture_widget(bar, widget);
		return bar;
	}

	public static GtkWidgetHandle GetKeyCaptureWidget(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_key_capture_widget(bar);
	}

	public static GtkSearchBarHandle SetChild(this GtkSearchBarHandle bar, GtkWidgetHandle child)
	{
		GtkSearchBarExterns.gtk_search_bar_set_child(bar, child);
		return bar;
	}

	public static GtkWidgetHandle GetChild(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_child(bar);
	}
}
