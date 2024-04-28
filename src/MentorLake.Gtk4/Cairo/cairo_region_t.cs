using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_region_tHandle : BaseSafeHandle { }
public struct cairo_region_t { }

public static class cairo_regionAdaptors
{
	public static cairo_region_tHandle CairoRegionCopy(this cairo_region_tHandle original)
	{
		return cairo_regionExterns.cairo_region_copy(original);
	}

	public static cairo_region_tHandle CairoRegionReference(this cairo_region_tHandle regionT)
	{
		return cairo_regionExterns.cairo_region_reference(regionT);
	}

	public static cairo_region_tHandle CairoRegionDestroy(this cairo_region_tHandle regionT)
	{
		cairo_regionExterns.cairo_region_destroy(regionT);
		return regionT;
	}

	public static int CairoRegionEqual(this cairo_region_tHandle a, cairo_region_tHandle b)
	{
		return cairo_regionExterns.cairo_region_equal(a, b);
	}

	public static cairo_status_t CairoRegionStatus(this cairo_region_tHandle regionT)
	{
		return cairo_regionExterns.cairo_region_status(regionT);
	}

	public static cairo_region_tHandle CairoRegionGetExtents(this cairo_region_tHandle regionT, cairo_rectangle_int_tHandle extents)
	{
		cairo_regionExterns.cairo_region_get_extents(regionT, extents);
		return regionT;
	}

	public static int CairoRegionNumRectangles(this cairo_region_tHandle regionT)
	{
		return cairo_regionExterns.cairo_region_num_rectangles(regionT);
	}

	public static cairo_region_tHandle CairoRegionGetRectangle(this cairo_region_tHandle regionT, int nth, cairo_rectangle_int_tHandle rectangle)
	{
		cairo_regionExterns.cairo_region_get_rectangle(regionT, nth, rectangle);
		return regionT;
	}

	public static int CairoRegionIsEmpty(this cairo_region_tHandle regionT)
	{
		return cairo_regionExterns.cairo_region_is_empty(regionT);
	}

	public static cairo_region_overlap_t CairoRegionContainsRectangle(this cairo_region_tHandle regionT, cairo_rectangle_int_tHandle rectangle)
	{
		return cairo_regionExterns.cairo_region_contains_rectangle(regionT, rectangle);
	}

	public static int CairoRegionContainsPoint(this cairo_region_tHandle regionT, int x, int y)
	{
		return cairo_regionExterns.cairo_region_contains_point(regionT, x, y);
	}

	public static cairo_region_tHandle CairoRegionTranslate(this cairo_region_tHandle regionT, int dx, int dy)
	{
		cairo_regionExterns.cairo_region_translate(regionT, dx, dy);
		return regionT;
	}

	public static cairo_status_t CairoRegionSubtract(this cairo_region_tHandle dst, cairo_region_tHandle other)
	{
		return cairo_regionExterns.cairo_region_subtract(dst, other);
	}

	public static cairo_status_t CairoRegionSubtractRectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle)
	{
		return cairo_regionExterns.cairo_region_subtract_rectangle(dst, rectangle);
	}

	public static cairo_status_t CairoRegionIntersect(this cairo_region_tHandle dst, cairo_region_tHandle other)
	{
		return cairo_regionExterns.cairo_region_intersect(dst, other);
	}

	public static cairo_status_t CairoRegionIntersectRectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle)
	{
		return cairo_regionExterns.cairo_region_intersect_rectangle(dst, rectangle);
	}

	public static cairo_status_t CairoRegionUnion(this cairo_region_tHandle dst, cairo_region_tHandle other)
	{
		return cairo_regionExterns.cairo_region_union(dst, other);
	}

	public static cairo_status_t CairoRegionUnionRectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle)
	{
		return cairo_regionExterns.cairo_region_union_rectangle(dst, rectangle);
	}

	public static cairo_status_t CairoRegionXor(this cairo_region_tHandle dst, cairo_region_tHandle other)
	{
		return cairo_regionExterns.cairo_region_xor(dst, other);
	}

	public static cairo_status_t CairoRegionXorRectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle)
	{
		return cairo_regionExterns.cairo_region_xor_rectangle(dst, rectangle);
	}
}

public static class cairo_regionExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_copy")]
	internal static extern cairo_region_tHandle cairo_region_copy(this cairo_region_tHandle original);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_reference")]
	internal static extern cairo_region_tHandle cairo_region_reference(this cairo_region_tHandle regionT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_destroy")]
	internal static extern void cairo_region_destroy(this cairo_region_tHandle regionT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_equal")]
	internal static extern int cairo_region_equal(this cairo_region_tHandle a, cairo_region_tHandle b);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_status")]
	internal static extern cairo_status_t cairo_region_status(this cairo_region_tHandle regionT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_get_extents")]
	internal static extern void cairo_region_get_extents(this cairo_region_tHandle regionT, cairo_rectangle_int_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_num_rectangles")]
	internal static extern int cairo_region_num_rectangles(this cairo_region_tHandle regionT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_get_rectangle")]
	internal static extern void cairo_region_get_rectangle(this cairo_region_tHandle regionT, int nth, cairo_rectangle_int_tHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_is_empty")]
	internal static extern int cairo_region_is_empty(this cairo_region_tHandle regionT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_contains_rectangle")]
	internal static extern cairo_region_overlap_t cairo_region_contains_rectangle(this cairo_region_tHandle regionT, cairo_rectangle_int_tHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_contains_point")]
	internal static extern int cairo_region_contains_point(this cairo_region_tHandle regionT, int x, int y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_translate")]
	internal static extern void cairo_region_translate(this cairo_region_tHandle regionT, int dx, int dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_subtract")]
	internal static extern cairo_status_t cairo_region_subtract(this cairo_region_tHandle dst, cairo_region_tHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_subtract_rectangle")]
	internal static extern cairo_status_t cairo_region_subtract_rectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_intersect")]
	internal static extern cairo_status_t cairo_region_intersect(this cairo_region_tHandle dst, cairo_region_tHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_intersect_rectangle")]
	internal static extern cairo_status_t cairo_region_intersect_rectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_union")]
	internal static extern cairo_status_t cairo_region_union(this cairo_region_tHandle dst, cairo_region_tHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_union_rectangle")]
	internal static extern cairo_status_t cairo_region_union_rectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_xor")]
	internal static extern cairo_status_t cairo_region_xor(this cairo_region_tHandle dst, cairo_region_tHandle other);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_region_xor_rectangle")]
	internal static extern cairo_status_t cairo_region_xor_rectangle(this cairo_region_tHandle dst, cairo_rectangle_int_tHandle rectangle);
}
