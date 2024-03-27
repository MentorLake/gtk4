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

public class GtkTooltipHandle : GObjectHandle
{
}

public static class GtkTooltipSignals
{
}

public static class GtkTooltipHandleExtensions
{
	public static GtkTooltipHandle SetCustom(this GtkTooltipHandle tooltip, GtkWidgetHandle custom_widget)
	{
		GtkTooltipExterns.gtk_tooltip_set_custom(tooltip, custom_widget);
		return tooltip;
	}

	public static GtkTooltipHandle SetIcon(this GtkTooltipHandle tooltip, GdkPaintableHandle paintable)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon(tooltip, paintable);
		return tooltip;
	}

	public static GtkTooltipHandle SetIconFromGicon(this GtkTooltipHandle tooltip, GIconHandle gicon)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon_from_gicon(tooltip, gicon);
		return tooltip;
	}

	public static GtkTooltipHandle SetIconFromIconName(this GtkTooltipHandle tooltip, string icon_name)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon_from_icon_name(tooltip, icon_name);
		return tooltip;
	}

	public static GtkTooltipHandle SetMarkup(this GtkTooltipHandle tooltip, string markup)
	{
		GtkTooltipExterns.gtk_tooltip_set_markup(tooltip, markup);
		return tooltip;
	}

	public static GtkTooltipHandle SetText(this GtkTooltipHandle tooltip, string text)
	{
		GtkTooltipExterns.gtk_tooltip_set_text(tooltip, text);
		return tooltip;
	}

	public static GtkTooltipHandle SetTipArea(this GtkTooltipHandle tooltip, GdkRectangleHandle rect)
	{
		GtkTooltipExterns.gtk_tooltip_set_tip_area(tooltip, rect);
		return tooltip;
	}

}

internal class GtkTooltipExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_custom(GtkTooltipHandle tooltip, GtkWidgetHandle custom_widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_icon(GtkTooltipHandle tooltip, GdkPaintableHandle paintable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_icon_from_gicon(GtkTooltipHandle tooltip, GIconHandle gicon);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_icon_from_icon_name(GtkTooltipHandle tooltip, string icon_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_markup(GtkTooltipHandle tooltip, string markup);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_text(GtkTooltipHandle tooltip, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tooltip_set_tip_area(GtkTooltipHandle tooltip, GdkRectangleHandle rect);
}
