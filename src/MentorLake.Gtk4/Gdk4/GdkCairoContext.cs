namespace MentorLake.Gtk4.Gdk4;

public class GdkCairoContextHandle : GdkDrawContextHandle
{
}

public static class GdkCairoContextHandleExtensions
{
	public static cairo_tHandle CairoCreate(this GdkCairoContextHandle self)
	{
		return GdkCairoContextExterns.gdk_cairo_context_cairo_create(self);
	}

}

internal class GdkCairoContextExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_tHandle gdk_cairo_context_cairo_create(GdkCairoContextHandle self);

}
