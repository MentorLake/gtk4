using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_pathExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_path_destroy")]
	internal static extern void cairo_path_destroy(this cairo_pathHandle path);
}
