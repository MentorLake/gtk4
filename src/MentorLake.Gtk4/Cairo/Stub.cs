namespace MentorLake.Gtk4.Cairo;

public struct cairo_tHandle { }
public struct cairo_region_tHandle { }
public struct cairo_surface_tHandle { }
public struct cairo_font_options_tHandle { }

public enum cairo_content_t : uint
{
	CAIRO_CONTENT_COLOR = 0x1000,
	CAIRO_CONTENT_ALPHA = 0x2000,
	CAIRO_CONTENT_COLOR_ALPHA = 0x3000
}