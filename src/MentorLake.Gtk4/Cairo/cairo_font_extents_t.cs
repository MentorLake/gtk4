namespace MentorLake.Gtk4.Cairo;

public class cairo_font_extents_tHandle : BaseSafeHandle { }

public struct cairo_font_extents_t
{
	public double ascent;
	public double descent;
	public double height;
	public double max_x_advance;
	public double max_y_advance;
}
