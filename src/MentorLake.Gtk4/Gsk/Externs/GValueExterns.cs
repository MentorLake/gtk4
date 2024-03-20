using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gsk;

public static class GValueExterns
{
	[DllImport(Libraries.Gsk, EntryPoint = "gsk_value_set_render_node")]
	internal static extern void gsk_value_set_render_node(this GValueHandle value, GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_value_take_render_node")]
	internal static extern void gsk_value_take_render_node(this GValueHandle value, GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_value_get_render_node")]
	internal static extern GskRenderNodeHandle gsk_value_get_render_node(this GValueHandle value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_value_dup_render_node")]
	internal static extern GskRenderNodeHandle gsk_value_dup_render_node(this GValueHandle value);
}
