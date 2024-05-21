namespace MentorLake.Gtk4.Pango;

public class PangoFontMetricsHandle : BaseSafeHandle
{
}


public static class PangoFontMetricsHandleExtensions
{
	public static int GetApproximateCharWidth(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_approximate_char_width(metrics);
	}

	public static int GetApproximateDigitWidth(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_approximate_digit_width(metrics);
	}

	public static int GetAscent(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_ascent(metrics);
	}

	public static int GetDescent(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_descent(metrics);
	}

	public static int GetHeight(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_height(metrics);
	}

	public static int GetStrikethroughPosition(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_strikethrough_position(metrics);
	}

	public static int GetStrikethroughThickness(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_strikethrough_thickness(metrics);
	}

	public static int GetUnderlinePosition(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_underline_position(metrics);
	}

	public static int GetUnderlineThickness(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_get_underline_thickness(metrics);
	}

	public static PangoFontMetricsHandle Ref(this PangoFontMetricsHandle metrics)
	{
		return PangoFontMetricsExterns.pango_font_metrics_ref(metrics);
	}

	public static PangoFontMetricsHandle Unref(this PangoFontMetricsHandle metrics)
	{
		PangoFontMetricsExterns.pango_font_metrics_unref(metrics);
		return metrics;
	}

}
internal class PangoFontMetricsExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_approximate_char_width(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_approximate_digit_width(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_ascent(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_descent(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_height(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_strikethrough_position(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_strikethrough_thickness(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_underline_position(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_font_metrics_get_underline_thickness(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMetricsHandle pango_font_metrics_ref(PangoFontMetricsHandle metrics);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_metrics_unref(PangoFontMetricsHandle metrics);

}

public struct PangoFontMetrics
{
}
