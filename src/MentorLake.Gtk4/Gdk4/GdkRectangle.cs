namespace MentorLake.Gtk4.Gdk4;

public class GdkRectangleHandle : BaseSafeHandle
{
}


public static class GdkRectangleHandleExtensions
{
	public static bool ContainsPoint(this GdkRectangleHandle rect, int x, int y)
	{
		return GdkRectangleExterns.gdk_rectangle_contains_point(rect, x, y);
	}

	public static bool Equal(this GdkRectangleHandle rect1, GdkRectangleHandle rect2)
	{
		return GdkRectangleExterns.gdk_rectangle_equal(rect1, rect2);
	}

	public static bool Intersect(this GdkRectangleHandle src1, GdkRectangleHandle src2, out GdkRectangle dest)
	{
		return GdkRectangleExterns.gdk_rectangle_intersect(src1, src2, out dest);
	}

	public static GdkRectangleHandle Union(this GdkRectangleHandle src1, GdkRectangleHandle src2, out GdkRectangle dest)
	{
		GdkRectangleExterns.gdk_rectangle_union(src1, src2, out dest);
		return src1;
	}

}
internal class GdkRectangleExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_rectangle_contains_point(GdkRectangleHandle rect, int x, int y);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_rectangle_equal(GdkRectangleHandle rect1, GdkRectangleHandle rect2);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_rectangle_intersect(GdkRectangleHandle src1, GdkRectangleHandle src2, out GdkRectangle dest);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_rectangle_union(GdkRectangleHandle src1, GdkRectangleHandle src2, out GdkRectangle dest);

}

public struct GdkRectangle
{
	public int x;
	public int y;
	public int width;
	public int height;
}
