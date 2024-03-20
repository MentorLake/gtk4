using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;

public static class cairo_surfaceExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_pixbuf_get_from_surface")]
	internal static extern GdkPixbufHandle gdk_pixbuf_get_from_surface(this cairo_surfaceHandle surface, int src_x, int src_y, int width, int height);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_region_create_from_surface")]
	internal static extern cairo_regionHandle gdk_cairo_region_create_from_surface(this cairo_surfaceHandle surface);
}
