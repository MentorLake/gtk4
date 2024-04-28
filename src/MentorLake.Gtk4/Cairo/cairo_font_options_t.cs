using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_font_options_tHandle : BaseSafeHandle { }
public struct cairo_font_options_t { }

public static class cairo_font_optionsAdaptors
{
	public static cairo_font_options_tHandle CairoFontOptionsCopy(this cairo_font_options_tHandle original)
	{
		return cairo_font_optionsExterns.cairo_font_options_copy(original);
	}

	public static cairo_font_options_tHandle CairoFontOptionsDestroy(this cairo_font_options_tHandle optionsT)
	{
		cairo_font_optionsExterns.cairo_font_options_destroy(optionsT);
		return optionsT;
	}

	public static cairo_status_t CairoFontOptionsStatus(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_status(optionsT);
	}

	public static cairo_font_options_tHandle CairoFontOptionsMerge(this cairo_font_options_tHandle optionsT, cairo_font_options_tHandle other)
	{
		cairo_font_optionsExterns.cairo_font_options_merge(optionsT, other);
		return optionsT;
	}

	public static int CairoFontOptionsEqual(this cairo_font_options_tHandle optionsT, cairo_font_options_tHandle other)
	{
		return cairo_font_optionsExterns.cairo_font_options_equal(optionsT, other);
	}

	public static nuint CairoFontOptionsHash(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_hash(optionsT);
	}

	public static cairo_font_options_tHandle CairoFontOptionsSetAntialias(this cairo_font_options_tHandle optionsT, cairo_antialias_t antialias)
	{
		cairo_font_optionsExterns.cairo_font_options_set_antialias(optionsT, antialias);
		return optionsT;
	}

	public static cairo_antialias_t CairoFontOptionsGetAntialias(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_get_antialias(optionsT);
	}

	public static cairo_font_options_tHandle CairoFontOptionsSetSubpixelOrder(this cairo_font_options_tHandle optionsT, cairo_subpixel_order_t subpixel_order)
	{
		cairo_font_optionsExterns.cairo_font_options_set_subpixel_order(optionsT, subpixel_order);
		return optionsT;
	}

	public static cairo_subpixel_order_t CairoFontOptionsGetSubpixelOrder(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_get_subpixel_order(optionsT);
	}

	public static cairo_font_options_tHandle CairoFontOptionsSetHintStyle(this cairo_font_options_tHandle optionsT, cairo_hint_style_t hint_style)
	{
		cairo_font_optionsExterns.cairo_font_options_set_hint_style(optionsT, hint_style);
		return optionsT;
	}

	public static cairo_hint_style_t CairoFontOptionsGetHintStyle(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_get_hint_style(optionsT);
	}

	public static cairo_font_options_tHandle CairoFontOptionsSetHintMetrics(this cairo_font_options_tHandle optionsT, cairo_hint_metrics_t hint_metrics)
	{
		cairo_font_optionsExterns.cairo_font_options_set_hint_metrics(optionsT, hint_metrics);
		return optionsT;
	}

	public static cairo_hint_metrics_t CairoFontOptionsGetHintMetrics(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_get_hint_metrics(optionsT);
	}

	public static string CairoFontOptionsGetVariations(this cairo_font_options_tHandle optionsT)
	{
		return cairo_font_optionsExterns.cairo_font_options_get_variations(optionsT);
	}

	public static cairo_font_options_tHandle CairoFontOptionsSetVariations(this cairo_font_options_tHandle optionsT, string variations)
	{
		cairo_font_optionsExterns.cairo_font_options_set_variations(optionsT, variations);
		return optionsT;
	}
}

public static class cairo_font_optionsExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_copy")]
	internal static extern cairo_font_options_tHandle cairo_font_options_copy(this cairo_font_options_tHandle original);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_destroy")]
	internal static extern void cairo_font_options_destroy(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_status")]
	internal static extern cairo_status_t cairo_font_options_status(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_merge")]
	internal static extern void cairo_font_options_merge(this cairo_font_options_tHandle optionsT, cairo_font_options_tHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_equal")]
	internal static extern int cairo_font_options_equal(this cairo_font_options_tHandle optionsT, cairo_font_options_tHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_hash")]
	internal static extern nuint cairo_font_options_hash(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_antialias")]
	internal static extern void cairo_font_options_set_antialias(this cairo_font_options_tHandle optionsT, cairo_antialias_t antialias);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_antialias")]
	internal static extern cairo_antialias_t cairo_font_options_get_antialias(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_subpixel_order")]
	internal static extern void cairo_font_options_set_subpixel_order(this cairo_font_options_tHandle optionsT, cairo_subpixel_order_t subpixel_order);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_subpixel_order")]
	internal static extern cairo_subpixel_order_t cairo_font_options_get_subpixel_order(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_hint_style")]
	internal static extern void cairo_font_options_set_hint_style(this cairo_font_options_tHandle optionsT, cairo_hint_style_t hint_style);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_hint_style")]
	internal static extern cairo_hint_style_t cairo_font_options_get_hint_style(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_hint_metrics")]
	internal static extern void cairo_font_options_set_hint_metrics(this cairo_font_options_tHandle optionsT, cairo_hint_metrics_t hint_metrics);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_hint_metrics")]
	internal static extern cairo_hint_metrics_t cairo_font_options_get_hint_metrics(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_variations")]
	internal static extern string cairo_font_options_get_variations(this cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_variations")]
	internal static extern void cairo_font_options_set_variations(this cairo_font_options_tHandle optionsT, string variations);
}
