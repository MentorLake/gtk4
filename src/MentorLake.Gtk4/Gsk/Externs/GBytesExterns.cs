using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gsk;

public static class GBytesExterns
{
	[DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_deserialize")]
	internal static extern GskRenderNodeHandle gsk_render_node_deserialize(this GBytesHandle bytes, GskParseErrorFunc error_func, IntPtr user_data);
}
