using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;

namespace MentorLake.Gtk4.Gdk;

public static class GdkCairoContextExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_cairo_context_cairo_create")]
	internal static extern cairoHandle gdk_cairo_context_cairo_create(this GdkCairoContextHandle self);
}
