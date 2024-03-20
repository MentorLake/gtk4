using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_font_optionsAdaptors
{
    public static cairo_font_optionsHandle CairoFontOptionsCopy(this cairo_font_optionsHandle original)
    {
        return cairo_font_optionsExterns.cairo_font_options_copy(original);
    }

    public static cairo_font_optionsHandle CairoFontOptionsDestroy(this cairo_font_optionsHandle options)
    {
        cairo_font_optionsExterns.cairo_font_options_destroy(options);
        return options;
    }

    public static _cairo_status CairoFontOptionsStatus(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_status(options);
    }

    public static cairo_font_optionsHandle CairoFontOptionsMerge(this cairo_font_optionsHandle options, cairo_font_optionsHandle other)
    {
        cairo_font_optionsExterns.cairo_font_options_merge(options, other);
        return options;
    }

    public static int CairoFontOptionsEqual(this cairo_font_optionsHandle options, cairo_font_optionsHandle other)
    {
        return cairo_font_optionsExterns.cairo_font_options_equal(options, other);
    }

    public static nuint CairoFontOptionsHash(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_hash(options);
    }

    public static cairo_font_optionsHandle CairoFontOptionsSetAntialias(this cairo_font_optionsHandle options, _cairo_antialias antialias)
    {
        cairo_font_optionsExterns.cairo_font_options_set_antialias(options, antialias);
        return options;
    }

    public static _cairo_antialias CairoFontOptionsGetAntialias(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_get_antialias(options);
    }

    public static cairo_font_optionsHandle CairoFontOptionsSetSubpixelOrder(this cairo_font_optionsHandle options, _cairo_subpixel_order subpixel_order)
    {
        cairo_font_optionsExterns.cairo_font_options_set_subpixel_order(options, subpixel_order);
        return options;
    }

    public static _cairo_subpixel_order CairoFontOptionsGetSubpixelOrder(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_get_subpixel_order(options);
    }

    public static cairo_font_optionsHandle CairoFontOptionsSetHintStyle(this cairo_font_optionsHandle options, _cairo_hint_style hint_style)
    {
        cairo_font_optionsExterns.cairo_font_options_set_hint_style(options, hint_style);
        return options;
    }

    public static _cairo_hint_style CairoFontOptionsGetHintStyle(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_get_hint_style(options);
    }

    public static cairo_font_optionsHandle CairoFontOptionsSetHintMetrics(this cairo_font_optionsHandle options, _cairo_hint_metrics hint_metrics)
    {
        cairo_font_optionsExterns.cairo_font_options_set_hint_metrics(options, hint_metrics);
        return options;
    }

    public static _cairo_hint_metrics CairoFontOptionsGetHintMetrics(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_get_hint_metrics(options);
    }

    public static string CairoFontOptionsGetVariations(this cairo_font_optionsHandle options)
    {
        return cairo_font_optionsExterns.cairo_font_options_get_variations(options);
    }

    public static cairo_font_optionsHandle CairoFontOptionsSetVariations(this cairo_font_optionsHandle options, string variations)
    {
        cairo_font_optionsExterns.cairo_font_options_set_variations(options, variations);
        return options;
    }
}
