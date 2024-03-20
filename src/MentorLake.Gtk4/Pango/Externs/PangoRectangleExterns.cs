using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class PangoRectangleExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_extents_to_pixels")]
	internal static extern void pango_extents_to_pixels(this PangoRectangleHandle inclusive, PangoRectangleHandle nearest);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_shape_new")]
	internal static extern PangoAttributeHandle pango_attr_shape_new(this PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_shape_new_with_data")]
	internal static extern PangoAttributeHandle pango_attr_shape_new_with_data(this PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect, IntPtr data, PangoAttrDataCopyFunc copy_func, GDestroyNotify destroy_func);
}
