using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_font_optionsExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_copy")]
	internal static extern cairo_font_optionsHandle cairo_font_options_copy(this cairo_font_optionsHandle original);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_destroy")]
	internal static extern void cairo_font_options_destroy(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_status")]
	internal static extern _cairo_status cairo_font_options_status(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_merge")]
	internal static extern void cairo_font_options_merge(this cairo_font_optionsHandle options, cairo_font_optionsHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_equal")]
	internal static extern int cairo_font_options_equal(this cairo_font_optionsHandle options, cairo_font_optionsHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_hash")]
	internal static extern nuint cairo_font_options_hash(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_antialias")]
	internal static extern void cairo_font_options_set_antialias(this cairo_font_optionsHandle options, _cairo_antialias antialias);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_antialias")]
	internal static extern _cairo_antialias cairo_font_options_get_antialias(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_subpixel_order")]
	internal static extern void cairo_font_options_set_subpixel_order(this cairo_font_optionsHandle options, _cairo_subpixel_order subpixel_order);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_subpixel_order")]
	internal static extern _cairo_subpixel_order cairo_font_options_get_subpixel_order(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_hint_style")]
	internal static extern void cairo_font_options_set_hint_style(this cairo_font_optionsHandle options, _cairo_hint_style hint_style);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_hint_style")]
	internal static extern _cairo_hint_style cairo_font_options_get_hint_style(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_hint_metrics")]
	internal static extern void cairo_font_options_set_hint_metrics(this cairo_font_optionsHandle options, _cairo_hint_metrics hint_metrics);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_hint_metrics")]
	internal static extern _cairo_hint_metrics cairo_font_options_get_hint_metrics(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_get_variations")]
	internal static extern string cairo_font_options_get_variations(this cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_options_set_variations")]
	internal static extern void cairo_font_options_set_variations(this cairo_font_optionsHandle options, string variations);
}
