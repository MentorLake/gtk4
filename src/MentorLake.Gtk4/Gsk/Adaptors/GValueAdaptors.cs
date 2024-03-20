using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gsk;
public static class GValueAdaptors
{
    public static GValueHandle GskValueSetRenderNode(this GValueHandle value, GskRenderNodeHandle node)
    {
        GValueExterns.gsk_value_set_render_node(value, node);
        return value;
    }

    public static GValueHandle GskValueTakeRenderNode(this GValueHandle value, GskRenderNodeHandle node)
    {
        GValueExterns.gsk_value_take_render_node(value, node);
        return value;
    }

    public static GskRenderNodeHandle GskValueGetRenderNode(this GValueHandle value)
    {
        return GValueExterns.gsk_value_get_render_node(value);
    }

    public static GskRenderNodeHandle GskValueDupRenderNode(this GValueHandle value)
    {
        return GValueExterns.gsk_value_dup_render_node(value);
    }
}
