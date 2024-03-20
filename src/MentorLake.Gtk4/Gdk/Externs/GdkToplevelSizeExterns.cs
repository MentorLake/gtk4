using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkToplevelSizeExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_size_get_bounds")]
	internal static extern void gdk_toplevel_size_get_bounds(this GdkToplevelSizeHandle size, out int bounds_width, out int bounds_height);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_size_set_size")]
	internal static extern void gdk_toplevel_size_set_size(this GdkToplevelSizeHandle size, int width, int height);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_size_set_min_size")]
	internal static extern void gdk_toplevel_size_set_min_size(this GdkToplevelSizeHandle size, int min_width, int min_height);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_size_set_shadow_width")]
	internal static extern void gdk_toplevel_size_set_shadow_width(this GdkToplevelSizeHandle size, int left, int right, int top, int bottom);
}
