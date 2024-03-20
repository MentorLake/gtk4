using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_rectangle_intExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_create_rectangle")]
	internal static extern cairo_regionHandle cairo_region_create_rectangle(this cairo_rectangle_intHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_create_rectangles")]
	internal static extern cairo_regionHandle cairo_region_create_rectangles(this cairo_rectangle_intHandle rects, int count);
}
