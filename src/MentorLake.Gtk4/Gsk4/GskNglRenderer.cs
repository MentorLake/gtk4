namespace MentorLake.Gtk4.Gsk4;

public class GskNglRendererHandle : GskRendererHandle
{
	public static GskNglRendererHandle New()
	{
		return GskNglRendererExterns.gsk_ngl_renderer_new();
	}

}

public static class GskNglRendererHandleExtensions
{
}

internal class GskNglRendererExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskNglRendererHandle gsk_ngl_renderer_new();

}
