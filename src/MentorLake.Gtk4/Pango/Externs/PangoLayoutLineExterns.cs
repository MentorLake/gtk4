using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoLayoutLineExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_ref")]
	internal static extern PangoLayoutLineHandle pango_layout_line_ref(this PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_unref")]
	internal static extern void pango_layout_line_unref(this PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_start_index")]
	internal static extern int pango_layout_line_get_start_index(this PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_length")]
	internal static extern int pango_layout_line_get_length(this PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_is_paragraph_start")]
	internal static extern int pango_layout_line_is_paragraph_start(this PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_resolved_direction")]
	internal static extern PangoDirection pango_layout_line_get_resolved_direction(this PangoLayoutLineHandle line);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_x_to_index")]
	internal static extern int pango_layout_line_x_to_index(this PangoLayoutLineHandle line, int x_pos, out int index_, out int trailing);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_index_to_x")]
	internal static extern void pango_layout_line_index_to_x(this PangoLayoutLineHandle line, int index_, int trailing, out int x_pos);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_x_ranges")]
	internal static extern void pango_layout_line_get_x_ranges(this PangoLayoutLineHandle line, int start_index, int end_index, out int[] ranges, out int n_ranges);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_extents")]
	internal static extern void pango_layout_line_get_extents(this PangoLayoutLineHandle line, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_height")]
	internal static extern void pango_layout_line_get_height(this PangoLayoutLineHandle line, out int height);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_line_get_pixel_extents")]
	internal static extern void pango_layout_line_get_pixel_extents(this PangoLayoutLineHandle layout_line, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);
}
