using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontMetricsExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_ref")]
	internal static extern PangoFontMetricsHandle pango_font_metrics_ref(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_unref")]
	internal static extern void pango_font_metrics_unref(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_ascent")]
	internal static extern int pango_font_metrics_get_ascent(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_descent")]
	internal static extern int pango_font_metrics_get_descent(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_height")]
	internal static extern int pango_font_metrics_get_height(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_approximate_char_width")]
	internal static extern int pango_font_metrics_get_approximate_char_width(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_approximate_digit_width")]
	internal static extern int pango_font_metrics_get_approximate_digit_width(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_underline_position")]
	internal static extern int pango_font_metrics_get_underline_position(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_underline_thickness")]
	internal static extern int pango_font_metrics_get_underline_thickness(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_strikethrough_position")]
	internal static extern int pango_font_metrics_get_strikethrough_position(this PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_metrics_get_strikethrough_thickness")]
	internal static extern int pango_font_metrics_get_strikethrough_thickness(this PangoFontMetricsHandle metrics);
}
