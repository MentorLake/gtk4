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

public class GtkHeaderBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkHeaderBarHandle New()
	{
		return GtkHeaderBarExterns.gtk_header_bar_new();
	}

}

public static class GtkHeaderBarHandleExtensions
{
	public static string GetDecorationLayout(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_decoration_layout(bar);
	}

	public static bool GetShowTitleButtons(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_show_title_buttons(bar);
	}

	public static GtkWidgetHandle GetTitleWidget(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_title_widget(bar);
	}

	public static GtkHeaderBarHandle PackEnd(this GtkHeaderBarHandle bar, GtkWidgetHandle child)
	{
		GtkHeaderBarExterns.gtk_header_bar_pack_end(bar, child);
		return bar;
	}

	public static GtkHeaderBarHandle PackStart(this GtkHeaderBarHandle bar, GtkWidgetHandle child)
	{
		GtkHeaderBarExterns.gtk_header_bar_pack_start(bar, child);
		return bar;
	}

	public static GtkHeaderBarHandle Remove(this GtkHeaderBarHandle bar, GtkWidgetHandle child)
	{
		GtkHeaderBarExterns.gtk_header_bar_remove(bar, child);
		return bar;
	}

	public static GtkHeaderBarHandle SetDecorationLayout(this GtkHeaderBarHandle bar, string layout)
	{
		GtkHeaderBarExterns.gtk_header_bar_set_decoration_layout(bar, layout);
		return bar;
	}

	public static GtkHeaderBarHandle SetShowTitleButtons(this GtkHeaderBarHandle bar, bool setting)
	{
		GtkHeaderBarExterns.gtk_header_bar_set_show_title_buttons(bar, setting);
		return bar;
	}

	public static GtkHeaderBarHandle SetTitleWidget(this GtkHeaderBarHandle bar, GtkWidgetHandle title_widget)
	{
		GtkHeaderBarExterns.gtk_header_bar_set_title_widget(bar, title_widget);
		return bar;
	}

}

internal class GtkHeaderBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkHeaderBarHandle gtk_header_bar_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_header_bar_get_decoration_layout(GtkHeaderBarHandle bar);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_header_bar_get_show_title_buttons(GtkHeaderBarHandle bar);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_header_bar_get_title_widget(GtkHeaderBarHandle bar);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_header_bar_pack_end(GtkHeaderBarHandle bar, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_header_bar_pack_start(GtkHeaderBarHandle bar, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_header_bar_remove(GtkHeaderBarHandle bar, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_header_bar_set_decoration_layout(GtkHeaderBarHandle bar, string layout);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_header_bar_set_show_title_buttons(GtkHeaderBarHandle bar, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_header_bar_set_title_widget(GtkHeaderBarHandle bar, GtkWidgetHandle title_widget);
}
