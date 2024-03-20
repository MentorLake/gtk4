using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskRoundedRectAdaptors
{
    public static GskRoundedRectHandle Init(this GskRoundedRectHandle self, graphene_rect_tHandle bounds, graphene_size_tHandle top_left, graphene_size_tHandle top_right, graphene_size_tHandle bottom_right, graphene_size_tHandle bottom_left)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_init(self, bounds, top_left, top_right, bottom_right, bottom_left);
    }

    public static GskRoundedRectHandle InitCopy(this GskRoundedRectHandle self, GskRoundedRectHandle src)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_init_copy(self, src);
    }

    public static GskRoundedRectHandle InitFromRect(this GskRoundedRectHandle self, graphene_rect_tHandle bounds, float radius)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_init_from_rect(self, bounds, radius);
    }

    public static GskRoundedRectHandle Normalize(this GskRoundedRectHandle self)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_normalize(self);
    }

    public static GskRoundedRectHandle Offset(this GskRoundedRectHandle self, float dx, float dy)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_offset(self, dx, dy);
    }

    public static GskRoundedRectHandle Shrink(this GskRoundedRectHandle self, float top, float right, float bottom, float left)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_shrink(self, top, right, bottom, left);
    }

    public static int IsRectilinear(this GskRoundedRectHandle self)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_is_rectilinear(self);
    }

    public static int ContainsPoint(this GskRoundedRectHandle self, graphene_point_tHandle point)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_contains_point(self, point);
    }

    public static int ContainsRect(this GskRoundedRectHandle self, graphene_rect_tHandle rect)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_contains_rect(self, rect);
    }

    public static int IntersectsRect(this GskRoundedRectHandle self, graphene_rect_tHandle rect)
    {
        return GskRoundedRectExterns.gsk_rounded_rect_intersects_rect(self, rect);
    }

    public static GskRenderNodeHandle GskBorderNodeNew(this GskRoundedRectHandle outline, float[] border_width, GdkRGBA border_color)
    {
        return GskRoundedRectExterns.gsk_border_node_new(outline, border_width, border_color);
    }

    public static GskRenderNodeHandle GskInsetShadowNodeNew(this GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
    {
        return GskRoundedRectExterns.gsk_inset_shadow_node_new(outline, color, dx, dy, spread, blur_radius);
    }

    public static GskRenderNodeHandle GskOutsetShadowNodeNew(this GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
    {
        return GskRoundedRectExterns.gsk_outset_shadow_node_new(outline, color, dx, dy, spread, blur_radius);
    }
}
