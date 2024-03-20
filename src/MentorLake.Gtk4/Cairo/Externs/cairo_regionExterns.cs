using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_regionExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_copy")]
	internal static extern cairo_regionHandle cairo_region_copy(this cairo_regionHandle original);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_reference")]
	internal static extern cairo_regionHandle cairo_region_reference(this cairo_regionHandle region);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_destroy")]
	internal static extern void cairo_region_destroy(this cairo_regionHandle region);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_equal")]
	internal static extern int cairo_region_equal(this cairo_regionHandle a, cairo_regionHandle b);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_status")]
	internal static extern _cairo_status cairo_region_status(this cairo_regionHandle region);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_get_extents")]
	internal static extern void cairo_region_get_extents(this cairo_regionHandle region, cairo_rectangle_intHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_num_rectangles")]
	internal static extern int cairo_region_num_rectangles(this cairo_regionHandle region);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_get_rectangle")]
	internal static extern void cairo_region_get_rectangle(this cairo_regionHandle region, int nth, cairo_rectangle_intHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_is_empty")]
	internal static extern int cairo_region_is_empty(this cairo_regionHandle region);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_contains_rectangle")]
	internal static extern _cairo_region_overlap cairo_region_contains_rectangle(this cairo_regionHandle region, cairo_rectangle_intHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_contains_point")]
	internal static extern int cairo_region_contains_point(this cairo_regionHandle region, int x, int y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_translate")]
	internal static extern void cairo_region_translate(this cairo_regionHandle region, int dx, int dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_subtract")]
	internal static extern _cairo_status cairo_region_subtract(this cairo_regionHandle dst, cairo_regionHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_subtract_rectangle")]
	internal static extern _cairo_status cairo_region_subtract_rectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_intersect")]
	internal static extern _cairo_status cairo_region_intersect(this cairo_regionHandle dst, cairo_regionHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_intersect_rectangle")]
	internal static extern _cairo_status cairo_region_intersect_rectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_union")]
	internal static extern _cairo_status cairo_region_union(this cairo_regionHandle dst, cairo_regionHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_union_rectangle")]
	internal static extern _cairo_status cairo_region_union_rectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_xor")]
	internal static extern _cairo_status cairo_region_xor(this cairo_regionHandle dst, cairo_regionHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_xor_rectangle")]
	internal static extern _cairo_status cairo_region_xor_rectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle);
}
