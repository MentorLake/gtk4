using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSearchEntryAdaptors
{
	public static GtkSearchEntryHandle SetKeyCaptureWidget(this GtkSearchEntryHandle entry, GtkWidgetHandle widget)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_key_capture_widget(entry, widget);
		return entry;
	}

	public static GtkWidgetHandle GetKeyCaptureWidget(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_key_capture_widget(entry);
	}
}
