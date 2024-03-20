using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;

public static class cairoExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_set_source_rgba")]
	internal static extern void gdk_cairo_set_source_rgba(this cairoHandle cr, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_set_source_pixbuf")]
	internal static extern void gdk_cairo_set_source_pixbuf(this cairoHandle cr, GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_rectangle")]
	internal static extern void gdk_cairo_rectangle(this cairoHandle cr, GdkRectangleHandle rectangle);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_region")]
	internal static extern void gdk_cairo_region(this cairoHandle cr, cairo_regionHandle region);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_draw_from_gl")]
	[Obsolete]
		internal static extern void gdk_cairo_draw_from_gl(this cairoHandle cr, GdkSurfaceHandle surface, int source, int source_type, int buffer_scale, int x, int y, int width, int height);
}
