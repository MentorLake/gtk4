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

public class GtkSearchBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkSearchBarHandle New()
	{
		return GtkSearchBarExterns.gtk_search_bar_new();
	}

}

public static class GtkSearchBarHandleExtensions
{
	public static GtkSearchBarHandle ConnectEntry(this GtkSearchBarHandle bar, GtkEditableHandle entry)
	{
		GtkSearchBarExterns.gtk_search_bar_connect_entry(bar, entry);
		return bar;
	}

	public static GtkWidgetHandle GetChild(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_child(bar);
	}

	public static GtkWidgetHandle GetKeyCaptureWidget(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_key_capture_widget(bar);
	}

	public static bool GetSearchMode(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_search_mode(bar);
	}

	public static bool GetShowCloseButton(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_show_close_button(bar);
	}

	public static GtkSearchBarHandle SetChild(this GtkSearchBarHandle bar, GtkWidgetHandle child)
	{
		GtkSearchBarExterns.gtk_search_bar_set_child(bar, child);
		return bar;
	}

	public static GtkSearchBarHandle SetKeyCaptureWidget(this GtkSearchBarHandle bar, GtkWidgetHandle widget)
	{
		GtkSearchBarExterns.gtk_search_bar_set_key_capture_widget(bar, widget);
		return bar;
	}

	public static GtkSearchBarHandle SetSearchMode(this GtkSearchBarHandle bar, bool search_mode)
	{
		GtkSearchBarExterns.gtk_search_bar_set_search_mode(bar, search_mode);
		return bar;
	}

	public static GtkSearchBarHandle SetShowCloseButton(this GtkSearchBarHandle bar, bool visible)
	{
		GtkSearchBarExterns.gtk_search_bar_set_show_close_button(bar, visible);
		return bar;
	}

}

internal class GtkSearchBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSearchBarHandle gtk_search_bar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_bar_connect_entry(GtkSearchBarHandle bar, GtkEditableHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_search_bar_get_child(GtkSearchBarHandle bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_search_bar_get_key_capture_widget(GtkSearchBarHandle bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_search_bar_get_search_mode(GtkSearchBarHandle bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_search_bar_get_show_close_button(GtkSearchBarHandle bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_bar_set_child(GtkSearchBarHandle bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_bar_set_key_capture_widget(GtkSearchBarHandle bar, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_bar_set_search_mode(GtkSearchBarHandle bar, bool search_mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_bar_set_show_close_button(GtkSearchBarHandle bar, bool visible);

}
