using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkHeaderBarAdaptors
{
	public static GtkHeaderBarHandle SetTitleWidget(this GtkHeaderBarHandle bar, GtkWidgetHandle title_widget)
	{
		GtkHeaderBarExterns.gtk_header_bar_set_title_widget(bar, title_widget);
		return bar;
	}

	public static GtkWidgetHandle GetTitleWidget(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_title_widget(bar);
	}

	public static GtkHeaderBarHandle PackStart(this GtkHeaderBarHandle bar, GtkWidgetHandle child)
	{
		GtkHeaderBarExterns.gtk_header_bar_pack_start(bar, child);
		return bar;
	}

	public static GtkHeaderBarHandle PackEnd(this GtkHeaderBarHandle bar, GtkWidgetHandle child)
	{
		GtkHeaderBarExterns.gtk_header_bar_pack_end(bar, child);
		return bar;
	}

	public static GtkHeaderBarHandle Remove(this GtkHeaderBarHandle bar, GtkWidgetHandle child)
	{
		GtkHeaderBarExterns.gtk_header_bar_remove(bar, child);
		return bar;
	}

	public static int GetShowTitleButtons(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_show_title_buttons(bar);
	}

	public static GtkHeaderBarHandle SetShowTitleButtons(this GtkHeaderBarHandle bar, int setting)
	{
		GtkHeaderBarExterns.gtk_header_bar_set_show_title_buttons(bar, setting);
		return bar;
	}

	public static GtkHeaderBarHandle SetDecorationLayout(this GtkHeaderBarHandle bar, string layout)
	{
		GtkHeaderBarExterns.gtk_header_bar_set_decoration_layout(bar, layout);
		return bar;
	}

	public static string GetDecorationLayout(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_decoration_layout(bar);
	}
}
