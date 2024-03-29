using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkSearchEntryHandle : GtkWidgetHandle
{
	public static GtkSearchEntryHandle New()
	{
		return GtkSearchEntryExterns.gtk_search_entry_new();
	}

}

public class GtkSearchEntrySignal
{
	public string Value { get; set; }
	public GtkSearchEntrySignal(string value) => Value = value;
}

public static class GtkSearchEntrySignals
{
	public static GtkSearchEntrySignal Activate = new("activate");
	public static GtkSearchEntrySignal NextMatch = new("next-match");
	public static GtkSearchEntrySignal PreviousMatch = new("previous-match");
	public static GtkSearchEntrySignal SearchChanged = new("search-changed");
	public static GtkSearchEntrySignal SearchStarted = new("search-started");
	public static GtkSearchEntrySignal StopSearch = new("stop-search");
}

public static class GtkSearchEntryHandleExtensions
{
	public static GtkInputHints GetInputHints(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_input_hints(entry);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_input_purpose(entry);
	}

	public static GtkWidgetHandle GetKeyCaptureWidget(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_key_capture_widget(entry);
	}

	public static string GetPlaceholderText(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_placeholder_text(entry);
	}

	public static uint GetSearchDelay(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_search_delay(entry);
	}

	public static GtkSearchEntryHandle SetInputHints(this GtkSearchEntryHandle entry, GtkInputHints hints)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static GtkSearchEntryHandle SetInputPurpose(this GtkSearchEntryHandle entry, GtkInputPurpose purpose)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static GtkSearchEntryHandle SetKeyCaptureWidget(this GtkSearchEntryHandle entry, GtkWidgetHandle widget)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_key_capture_widget(entry, widget);
		return entry;
	}

	public static GtkSearchEntryHandle SetPlaceholderText(this GtkSearchEntryHandle entry, string text)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static GtkSearchEntryHandle SetSearchDelay(this GtkSearchEntryHandle entry, uint delay)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_search_delay(entry, delay);
		return entry;
	}

	public static GtkSearchEntryHandle Connect(this GtkSearchEntryHandle instance, GtkSearchEntrySignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkSearchEntryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSearchEntryHandle gtk_search_entry_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_search_entry_get_input_hints(GtkSearchEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_search_entry_get_input_purpose(GtkSearchEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_search_entry_get_key_capture_widget(GtkSearchEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_search_entry_get_placeholder_text(GtkSearchEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_search_entry_get_search_delay(GtkSearchEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_input_hints(GtkSearchEntryHandle entry, GtkInputHints hints);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_input_purpose(GtkSearchEntryHandle entry, GtkInputPurpose purpose);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_key_capture_widget(GtkSearchEntryHandle entry, GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_placeholder_text(GtkSearchEntryHandle entry, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_search_delay(GtkSearchEntryHandle entry, uint delay);
}
