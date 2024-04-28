using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_rectangle_list_tHandle : BaseSafeHandle { }

public struct cairo_rectangle_list_t
{
	public cairo_status_t status;
	public cairo_rectangle_t[] rectangles;
	public int num_rectangles;
}

public static class cairo_rectangle_listAdaptors
{
	public static cairo_rectangle_list_tHandle CairoRectangleListDestroy(this cairo_rectangle_list_tHandle rectangleListT)
	{
		cairo_rectangle_listExterns.cairo_rectangle_list_destroy(rectangleListT);
		return rectangleListT;
	}
}

public static class cairo_rectangle_listExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rectangle_list_destroy")]
	internal static extern void cairo_rectangle_list_destroy(this cairo_rectangle_list_tHandle rectangleListT);
}
