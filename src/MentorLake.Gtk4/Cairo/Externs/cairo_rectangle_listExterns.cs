using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_rectangle_listExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rectangle_list_destroy")]
	internal static extern void cairo_rectangle_list_destroy(this cairo_rectangle_listHandle rectangle_list);
}
