using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_regionAdaptors
{
    public static cairo_regionHandle CairoRegionCopy(this cairo_regionHandle original)
    {
        return cairo_regionExterns.cairo_region_copy(original);
    }

    public static cairo_regionHandle CairoRegionReference(this cairo_regionHandle region)
    {
        return cairo_regionExterns.cairo_region_reference(region);
    }

    public static cairo_regionHandle CairoRegionDestroy(this cairo_regionHandle region)
    {
        cairo_regionExterns.cairo_region_destroy(region);
        return region;
    }

    public static int CairoRegionEqual(this cairo_regionHandle a, cairo_regionHandle b)
    {
        return cairo_regionExterns.cairo_region_equal(a, b);
    }

    public static _cairo_status CairoRegionStatus(this cairo_regionHandle region)
    {
        return cairo_regionExterns.cairo_region_status(region);
    }

    public static cairo_regionHandle CairoRegionGetExtents(this cairo_regionHandle region, cairo_rectangle_intHandle extents)
    {
        cairo_regionExterns.cairo_region_get_extents(region, extents);
        return region;
    }

    public static int CairoRegionNumRectangles(this cairo_regionHandle region)
    {
        return cairo_regionExterns.cairo_region_num_rectangles(region);
    }

    public static cairo_regionHandle CairoRegionGetRectangle(this cairo_regionHandle region, int nth, cairo_rectangle_intHandle rectangle)
    {
        cairo_regionExterns.cairo_region_get_rectangle(region, nth, rectangle);
        return region;
    }

    public static int CairoRegionIsEmpty(this cairo_regionHandle region)
    {
        return cairo_regionExterns.cairo_region_is_empty(region);
    }

    public static _cairo_region_overlap CairoRegionContainsRectangle(this cairo_regionHandle region, cairo_rectangle_intHandle rectangle)
    {
        return cairo_regionExterns.cairo_region_contains_rectangle(region, rectangle);
    }

    public static int CairoRegionContainsPoint(this cairo_regionHandle region, int x, int y)
    {
        return cairo_regionExterns.cairo_region_contains_point(region, x, y);
    }

    public static cairo_regionHandle CairoRegionTranslate(this cairo_regionHandle region, int dx, int dy)
    {
        cairo_regionExterns.cairo_region_translate(region, dx, dy);
        return region;
    }

    public static _cairo_status CairoRegionSubtract(this cairo_regionHandle dst, cairo_regionHandle other)
    {
        return cairo_regionExterns.cairo_region_subtract(dst, other);
    }

    public static _cairo_status CairoRegionSubtractRectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle)
    {
        return cairo_regionExterns.cairo_region_subtract_rectangle(dst, rectangle);
    }

    public static _cairo_status CairoRegionIntersect(this cairo_regionHandle dst, cairo_regionHandle other)
    {
        return cairo_regionExterns.cairo_region_intersect(dst, other);
    }

    public static _cairo_status CairoRegionIntersectRectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle)
    {
        return cairo_regionExterns.cairo_region_intersect_rectangle(dst, rectangle);
    }

    public static _cairo_status CairoRegionUnion(this cairo_regionHandle dst, cairo_regionHandle other)
    {
        return cairo_regionExterns.cairo_region_union(dst, other);
    }

    public static _cairo_status CairoRegionUnionRectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle)
    {
        return cairo_regionExterns.cairo_region_union_rectangle(dst, rectangle);
    }

    public static _cairo_status CairoRegionXor(this cairo_regionHandle dst, cairo_regionHandle other)
    {
        return cairo_regionExterns.cairo_region_xor(dst, other);
    }

    public static _cairo_status CairoRegionXorRectangle(this cairo_regionHandle dst, cairo_rectangle_intHandle rectangle)
    {
        return cairo_regionExterns.cairo_region_xor_rectangle(dst, rectangle);
    }
}
