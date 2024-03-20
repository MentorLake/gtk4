using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLinkButtonAdaptors
{
	public static string GetUri(this GtkLinkButtonHandle link_button)
	{
		return GtkLinkButtonExterns.gtk_link_button_get_uri(link_button);
	}

	public static GtkLinkButtonHandle SetUri(this GtkLinkButtonHandle link_button, string uri)
	{
		GtkLinkButtonExterns.gtk_link_button_set_uri(link_button, uri);
		return link_button;
	}

	public static int GetVisited(this GtkLinkButtonHandle link_button)
	{
		return GtkLinkButtonExterns.gtk_link_button_get_visited(link_button);
	}

	public static GtkLinkButtonHandle SetVisited(this GtkLinkButtonHandle link_button, int visited)
	{
		GtkLinkButtonExterns.gtk_link_button_set_visited(link_button, visited);
		return link_button;
	}

	public static GtkLinkButtonHandle NewWithLabel(string uri, string label)
	{
		return GtkLinkButtonExterns.gtk_link_button_new_with_label(uri, label);
	}
}
