using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkRGBAExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rgba_copy")]
	internal static extern GdkRGBAHandle gdk_rgba_copy(this GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rgba_free")]
	internal static extern void gdk_rgba_free(this GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rgba_is_clear")]
	internal static extern int gdk_rgba_is_clear(this GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rgba_is_opaque")]
	internal static extern int gdk_rgba_is_opaque(this GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rgba_parse")]
	internal static extern int gdk_rgba_parse(this GdkRGBAHandle rgba, string spec);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rgba_to_string")]
	internal static extern string gdk_rgba_to_string(this GdkRGBAHandle rgba);
}
