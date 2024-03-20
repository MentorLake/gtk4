using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTooltipExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_markup")]
	internal static extern void gtk_tooltip_set_markup(this GtkTooltipHandle tooltip, string markup);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_text")]
	internal static extern void gtk_tooltip_set_text(this GtkTooltipHandle tooltip, string text);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_icon")]
	internal static extern void gtk_tooltip_set_icon(this GtkTooltipHandle tooltip, GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_icon_from_icon_name")]
	internal static extern void gtk_tooltip_set_icon_from_icon_name(this GtkTooltipHandle tooltip, string icon_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_icon_from_gicon")]
	internal static extern void gtk_tooltip_set_icon_from_gicon(this GtkTooltipHandle tooltip, GIconHandle gicon);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_custom")]
	internal static extern void gtk_tooltip_set_custom(this GtkTooltipHandle tooltip, GtkWidgetHandle custom_widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tooltip_set_tip_area")]
	internal static extern void gtk_tooltip_set_tip_area(this GtkTooltipHandle tooltip, GdkRectangleHandle rect);
}
