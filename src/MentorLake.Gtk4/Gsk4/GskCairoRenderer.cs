namespace MentorLake.Gtk4.Gsk4;

public class GskCairoRendererHandle : GskRendererHandle
{
	public static GskCairoRendererHandle New()
	{
		return GskCairoRendererExterns.gsk_cairo_renderer_new();
	}

}

public static class GskCairoRendererHandleExtensions
{
}

internal class GskCairoRendererExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskCairoRendererHandle gsk_cairo_renderer_new();

}
