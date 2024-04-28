using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_rectangle_int_tHandle : BaseSafeHandle { }

public struct cairo_rectangle_int_t
{
	public int x;
	public int y;
	public int width;
	public int height;
}

public static class cairo_rectangle_intAdaptors
{
	public static cairo_region_tHandle CairoRegionCreateRectangle(this cairo_rectangle_int_tHandle rectangle)
	{
		return cairo_rectangle_intExterns.cairo_region_create_rectangle(rectangle);
	}

	public static cairo_region_tHandle CairoRegionCreateRectangles(this cairo_rectangle_int_tHandle rects, int count)
	{
		return cairo_rectangle_intExterns.cairo_region_create_rectangles(rects, count);
	}
}

public static class cairo_rectangle_intExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_create_rectangle")]
	internal static extern cairo_region_tHandle cairo_region_create_rectangle(this cairo_rectangle_int_tHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_create_rectangles")]
	internal static extern cairo_region_tHandle cairo_region_create_rectangles(this cairo_rectangle_int_tHandle rects, int count);
}
