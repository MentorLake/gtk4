namespace MentorLake.Gtk4.Gsk4;

public class GskGLRendererHandle : GskRendererHandle
{
	public static GskGLRendererHandle GskGlRendererNew()
	{
		return GskGLRendererExterns.gsk_gl_renderer_new();
	}

}

public static class GskGLRendererHandleExtensions
{
}

internal class GskGLRendererExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskGLRendererHandle gsk_gl_renderer_new();

}
