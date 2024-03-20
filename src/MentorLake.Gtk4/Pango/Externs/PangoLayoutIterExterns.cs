using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoLayoutIterExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_copy")]
	internal static extern PangoLayoutIterHandle pango_layout_iter_copy(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_free")]
	internal static extern void pango_layout_iter_free(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_index")]
	internal static extern int pango_layout_iter_get_index(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_run")]
	internal static extern PangoGlyphItemHandle pango_layout_iter_get_run(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_run_readonly")]
	internal static extern PangoGlyphItemHandle pango_layout_iter_get_run_readonly(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_line")]
	internal static extern PangoLayoutLineHandle pango_layout_iter_get_line(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_line_readonly")]
	internal static extern PangoLayoutLineHandle pango_layout_iter_get_line_readonly(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_at_last_line")]
	internal static extern int pango_layout_iter_at_last_line(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_layout")]
	internal static extern PangoLayoutHandle pango_layout_iter_get_layout(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_next_char")]
	internal static extern int pango_layout_iter_next_char(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_next_cluster")]
	internal static extern int pango_layout_iter_next_cluster(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_next_run")]
	internal static extern int pango_layout_iter_next_run(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_next_line")]
	internal static extern int pango_layout_iter_next_line(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_char_extents")]
	internal static extern void pango_layout_iter_get_char_extents(this PangoLayoutIterHandle iter, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_cluster_extents")]
	internal static extern void pango_layout_iter_get_cluster_extents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_run_extents")]
	internal static extern void pango_layout_iter_get_run_extents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_line_extents")]
	internal static extern void pango_layout_iter_get_line_extents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_line_yrange")]
	internal static extern void pango_layout_iter_get_line_yrange(this PangoLayoutIterHandle iter, out int y0_, out int y1_);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_layout_extents")]
	internal static extern void pango_layout_iter_get_layout_extents(this PangoLayoutIterHandle iter, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_baseline")]
	internal static extern int pango_layout_iter_get_baseline(this PangoLayoutIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_layout_iter_get_run_baseline")]
	internal static extern int pango_layout_iter_get_run_baseline(this PangoLayoutIterHandle iter);
}
