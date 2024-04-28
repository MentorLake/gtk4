namespace MentorLake.Gtk4.Cairo;

public class cairo_text_extents_tHandle : BaseSafeHandle { }

public struct cairo_text_extents_t
{
	public double x_bearing;
	public double y_bearing;
	public double width;
	public double height;
	public double x_advance;
	public double y_advance;
}
