using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gsk;
public static class GBytesAdaptors
{
    public static GskRenderNodeHandle GskRenderNodeDeserialize(this GBytesHandle bytes, GskParseErrorFunc error_func, IntPtr user_data)
    {
        return GBytesExterns.gsk_render_node_deserialize(bytes, error_func, user_data);
    }
}
